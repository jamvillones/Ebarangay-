using E_Barangay.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using E_Barangay.Forms;
using System.Drawing.Printing;

namespace E_Barangay.Documents
{
    public partial class CertforPRC : DocumentForm
    {
        public CertforPRC()
        {
            InitializeComponent();
        }
        public override void InitializeControls()
        {
            o.InitDropdowns(officerOption);
            AddControls(firstName, middleName, lastName, extension,
                        age, sex, address, civilStatus,
                        issuedOn, officerOption);
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
        public override void Printing_PrintPage(object sender, PrintPageEventArgs e)
        {
            base.Printing_PrintPage(sender, e);

            string _name = Printing.GetName(firstName, middleName, lastName, extension);
            string text = "To whom it may concern:" + Printing.LineSpace +
                           Printing.Indention + "This is to certify that " + _name + ", " + age.Value + " years old, " + civilStatus.Text + ", Filipino is a resident of " + address.Text + ". " + sex.HeShe() + " is a person of Good Moral character and bears no records of misdemeanor on this Barangay." + Printing.LineSpace +
                           Printing.Indention + "This certification is issued upon the request of " + sex.MrMrs() + " " + lastName.Text + " " + (string.IsNullOrEmpty(extension.Text) ? "" : " " + extension.Text) + " in support to " + sex.HisHer() + " requirements for PRC Examination." + Printing.LineSpace +
                           Printing.Indention + "Issued this " + issuedOn.customFormat() + " at Poblacion, Kalibo, Aklan.";
            e.Graphics.DrawString(text, Printing.font, Brushes.Black, rect);
            Printing.DrawSpecimenSignature(e, _name);
            Printing.DrawCapSb(e, o.captName, officerOption.Text);
        }
        OfficerInfo o = new OfficerInfo();
    }
}
