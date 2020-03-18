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
using E_Barangay.Documents;
using System.Drawing.Printing;
using E_Barangay.Class;

namespace E_Barangay.Documents
{
    public partial class BrgyCertforNoIncome : DocumentForm
    {
        OfficerInfo o = new OfficerInfo();
        public BrgyCertforNoIncome()
        {
            InitializeComponent();
        }
        public override void InitializeControls()
        {
            o.InitDropdowns(officerOption);
            AddControls(firstText, middleText, lastText, extText,
                        SexOption, CStatusOption, Address,
                        employment,income,
                        wardName,relations,status,
                        purpose,institution,IssuedOn,
                        officerOption);
        }
        public override void AcceptCitizen(Citizen c)
        {
            if (NullCheck(c))
                return;

            firstText.Text = c.FirstName;
            middleText.Text = c.MiddleName;
            lastText.Text = c.LastName;
            extText.Text = c.Extension;

            SexOption.Text = c.Gender;
            CStatusOption.Text = c.CivilStatus;
            Address.Text = c.Address;
        }
        public override void Printing_PrintPage(object sender, PrintPageEventArgs e)
        {
            base.Printing_PrintPage(sender, e);
            string name = Printing.GetFullName(firstText, middleText, lastText, extText);

            string text = "To whom it may concern:" + Printing.LineSpace +
                          Printing.Indention + "This is to certify that " + name + " of legal age, " + CStatusOption.Text + ", Filipino, and a resident of " + Address.Text + "." + Printing.LineSpace +
                          Printing.Indention + "This is to certify further that " + SexOption.MrMs() + " " + name + " is a " + employment.Text + " and has limited source of income averaging " + income.Text + " per month." + Printing.LineSpace +
                          Printing.Indention + "This certification is issued to upon the request of " + SexOption.MrMs() + " " + lastText.Text + " as requirements for the " + purpose.Text + " of " + SexOption.HisHer() + " " + relations.Text + " " + wardName.Text + " who is " + status.Text + " in " + institution.Text + "." + Printing.LineSpace +
                          Printing.Indention + "Issued this " + IssuedOn.Value.Day + "th day of " + IssuedOn.customFormat() + " Barangay Poblacion, Kalibo, Aklan.";

            e.Graphics.DrawString(text, Printing.font, Brushes.Black, rect);
            DrawDebugRecs(rect, e);
            Printing.DrawCapSb(e, o.captName, officerOption.Text);
        }
    }
}
