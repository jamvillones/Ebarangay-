using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using E_Barangay.Class;
using E_Barangay.Forms;

namespace E_Barangay.Documents
{
    public partial class SSSPension : DocumentForm
    {
        public SSSPension()
        {
            InitializeComponent();
        }
        public override void AcceptCitizen(Citizen c)
        {
            if (NullCheck(c)) return;
            firstName.Text = c.FirstName;
            middleName.Text = c.MiddleName;
            lastName.Text = c.LastName;
            extension.Text = c.Extension;

            age.Value = c.getAGe();
            sex.Text = c.Gender;
            civilStatus.Text = c.CivilStatus;
            address.Text = c.Address;
        }
        public override void InitializeControls()
        {
            o.InitDropdowns(officerOption);
            AddControls(firstName, middleName, lastName, extension,
                        age, sex, address, civilStatus,
                        employment, profession, dtEmployedSince, institution,
                        officerOption, orNo, orIssueDate, orValidityDate);
        }
        public override void Printing_PrintPage(object sender, PrintPageEventArgs e)
        {
            base.Printing_PrintPage(sender, e);
            string _name = Printing.GetName(firstName, middleName, lastName, extension);
            string text = "To whom it may concern:" + Printing.LineSpace +
                           Printing.Indention + "This is to certify that " + sex.MrMrs() + " " + _name + ", " + age.Value + " years old, " + civilStatus.Text + ", " + sex.Text + ", Filipino and a resident of " + address.Text + "." + Printing.LineSpace +
                           Printing.Indention + "This certifies further that " + sex.MrMrs() + " " + _name + " has ceased from " + sex.HisHer() + " " + employment.Text + " as " + profession.Text + " in "+institution.Text+" and no income since " + dtEmployedSince.Value.ToString("MMMM dd, yyyy") + "." + Printing.LineSpace +
                           Printing.Indention + "This certification is hereby issued upon the request of " + sex.MrMrs() + " " + lastName.Text + " " + (string.IsNullOrEmpty(extension.Text) ? "" : " " + extension.Text) + " in support to "+sex.HisHer()+" application for retirement with the Social Security System (SSS)." + Printing.LineSpace +
                           Printing.Indention + "Issued this " + IssuedOn.customFormat() + "Barangay Poblacion, Kalibo, Aklan";

            e.Graphics.DrawString(text, Printing.font, Brushes.Black, rect);

            DrawDebugRecs(rect, e);
            Printing.DrawSpecimenSignature(e, _name);
            Printing.DrawCapSb(e, o.captName, officerOption.Text);
            Printing.DrawValidityOr(e, orNo.Text, orIssueDate.Value, orValidityDate.Value);

        }
        OfficerInfo o = new OfficerInfo();
    }
}
