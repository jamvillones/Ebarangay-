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
    public partial class BarangayCertPao : DocumentForm
    {
        public BarangayCertPao()
        {
            InitializeComponent();
        }
        public override void AcceptCitizen(Citizen c)
        {
            if (NullCheck(c))
                return;
            firstText.Text = c.FirstName;
            middleText.Text = c.MiddleName;
            lastText.Text = c.LastName;
            extText.Text = c.Extension;
            Age.Value = c.getAGe();
            Address.Text = c.Address;
            SexOption.Text = c.Gender;
            CStatusOption.Text = c.CivilStatus;
        }
        public override void InitializeControls()
        {
            base.InitializeControls();
            o.InitDropdowns(officerOption);
        }
        public override void Printing_PrintPage(object sender, PrintPageEventArgs e)
        {
            base.Printing_PrintPage(sender, e);
            string _name = Printing.GetFullName(firstText, middleText, lastText, extText);
            string text = "To whom it may concern:" + Printing.LineSpace +
                          Printing.Indention + "This is to certify that " + _name + ", " + Age.PrintAge() + ", Filipino, " + CStatusOption.Text + " and a resident of " + Address.Text + ", belongs to an indigent family in this Barangay." + Printing.LineSpace +
                          Printing.Indention + SexOption.HeShe(true) + " is asking for utmost humanitarian consideration and possible Legal Assistance." + Printing.LineSpace +
                          Printing.Indention + "This certification is issued upon the request of " + SexOption.MrMrs() + " " + lastText.Text + " in support to " + SexOption.HisHer() + " request for Legal Assistance from the Public Attorney's Office (PAO)." + Printing.LineSpace +
                          Printing.Indention + "Issued this " + IssuedOn.customFormat() + " Barangay Poblacion, Kalibo, Aklan.";

            e.Graphics.DrawString(text, Printing.font, Brushes.Black, rect);
            DrawDebugRecs(rect, e);
            Printing.DrawCapSb(e, o.captName, officerOption.Text);
        }
        OfficerInfo o = new OfficerInfo();
    }
}
