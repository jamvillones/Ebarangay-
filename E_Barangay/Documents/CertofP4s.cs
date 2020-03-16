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

namespace E_Barangay.Documents
{
    public partial class CertofP4s : DocumentForm
    {
        Class.OfficerInfo o = new Class.OfficerInfo();
        public CertofP4s()
        {
            InitializeComponent();
        }
        public override void InitializeControls()
        {
            o.InitDropdowns(officerOption);
            AddControls(firstText, middleText, lastText, extText,
                        Address, SexOption, CStatusOption,officerOption);
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
            SexOption.Text = c.Gender;
            CStatusOption.Text = c.CivilStatus;
        }
        public override void Printing_PrintPage(object sender, PrintPageEventArgs e)
        {
            base.Printing_PrintPage(sender, e);
            string name = Printing.GetFullName(firstText, middleText, lastText, extText);
            string text = "To whom it may concern:" + Printing.LineSpace +
                          Printing.Indention + "This is to certify that " + name + " of legal age, "+CStatusOption.Text+" Filipino and is a resident of "+Address.Text+", belongs to an indigent family in this Barangay." + Printing.LineSpace +
                          Printing.Indention + "This certification is issued upon the request of "+SexOption.MrMs()+" "+lastText.Text+" in support to on "+SexOption.HisHer()+" requirements for Pantawid Pamilya Pilipino Program (4P’S) application." + Printing.LineSpace +
                          Printing.Indention + "Issued this "+IssuedOn.Value.Day+"th day of "+IssuedOn.Value.ToString("MMMM, yyyy")+" Barangay Poblacion, Kalibo, Aklan.";
            e.Graphics.DrawString(text, Printing.font, Brushes.Black, rect);
            DrawDebugRecs(rect, e);

            Printing.DrawCapSb(e, o.captName, officerOption.Text);
        }
    }
}
