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
using E_Barangay.Forms;
using E_Barangay.Class;

namespace E_Barangay.Documents
{
    public partial class BrgyClearance_Akelco : DocumentForm
    {
        OfficerInfo o = new OfficerInfo();
        public BrgyClearance_Akelco()
        {
            InitializeComponent();
        }
        public override void InitializeControls()
        {
            AddControls(firstName, middleName, lastName, ext,
                        cStatus, sexOption, Address,
                        IssuedOn, dtValidity, 
                        officerOption);

            o.InitDropdowns(officerOption);
        }
        public override void AcceptCitizen(Citizen c)
        {
            if (NullCheck(c))
                return;
            firstName.Text = c.FirstName;
            middleName.Text = c.MiddleName;
            lastName.Text = c.LastName;
            ext.Text = c.Extension;
            Address.Text = c.Address;
            cStatus.Text = c.CivilStatus;
            sexOption.Text = c.Gender;
        }
        public override void Printing_PrintPage(object sender, PrintPageEventArgs e)
        {
            base.Printing_PrintPage(sender, e);

            string name = Printing.GetName(firstName, middleName, lastName, ext);

            string text = "To whom it may concern:" + Printing.LineSpace +
                          Printing.Indention + "This is to certify that " + name + " of legal age, " + cStatus.Text + ", Filipino and a resident of " + Address.Text + "." + Printing.LineSpace +
                          Printing.Indention + "This certification is issued upon the request of " + sexOption.MrMs() + " " + lastName.Text + (string.IsNullOrEmpty(ext.Text) ? "" : " " + ext.Text) + " in connection with " + sexOption.HisHer() + " application for  Electric Connection at AKELCO." + Printing.LineSpace +
                          Printing.Indention + "Given this " + IssuedOn.Value.Day + "th day of " + IssuedOn.Value.ToString("MMMM, yyyy") + " at Barangay Hall Poblacion, Kalibo, Aklan.";

            e.Graphics.DrawString(text, Printing.font, Brushes.Black, rect);
            DrawDebugRecs(rect, e);
            Printing.DrawSpecimenSignature(e, name);
            Printing.DrawValidityOr(e,orNo.Text,orIssueDate.Value, dtValidity.Value);
            Printing.DrawCapSb(e, o.captName, officerOption.Text);
        }
    }
}
