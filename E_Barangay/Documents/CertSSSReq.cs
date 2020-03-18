using E_Barangay.Class;
using E_Barangay.Forms;
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

namespace E_Barangay.Documents
{
    public partial class CertSSSReq : DocumentForm
    {
        OfficerInfo o = new OfficerInfo();
        public CertSSSReq()
        {
            InitializeComponent();
        }
        public override void Printing_PrintPage(object sender, PrintPageEventArgs e)
        {
            base.Printing_PrintPage(sender, e);
            string name = Printing.GetFullName(firstText, middleText, lastText, extText);
            string text = "To whom it may concern:" + Printing.LineSpace +
                           Printing.Indention + "This is to certify that " + SexOption.MrMs() + " " + name + " " + Age.Text + " years old, " + CStatusOption.Text + ", and a resident of " + Address.Text + "." + Printing.LineSpace +
                           Printing.Indention + "Further certify that " + SexOption.MrMs() + " " + name + "  is " + caseText.Text + ". This was confirmed upon the visit of one of our Barangay Staff." + Printing.LineSpace +
                           Printing.Indention + "This certification is hereby issued upon the request of " + SexOption.MrMs() + " " + lastText.Text + " in support to her request for Social Security System (SSS) requirements." + Printing.LineSpace +
                           Printing.Indention + "Issued this " + IssuedOn.customFormat() + " Barangay Poblacion, Kalibo, Aklan.";

            e.Graphics.DrawString(text, Printing.font, Brushes.Black, rect);
            DrawDebugRecs(rect, e);
            Printing.DrawCapSb(e, o.captName, officerOption.Text);
        }
        public override void InitializeControls()
        {
            o.InitDropdowns(officerOption);
            AddControls(firstText, middleText, lastText, extText,
                        caseText, IssuedOn, officerOption);
        }
        public override void AcceptCitizen(Citizen c)
        {
            if (NullCheck(c))
                return;

            firstText.Text = c.FirstName;
            middleText.Text = c.MiddleName;
            lastText.Text = c.LastName;
            extText.Text = c.Extension;
            Address.Text = c.Address;
            CStatusOption.Text = c.CivilStatus;
            SexOption.Text = c.Gender;
            Age.Text = c.getAGe().ToString();
        }
    }
}
