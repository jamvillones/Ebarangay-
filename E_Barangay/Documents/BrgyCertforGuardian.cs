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
using E_Barangay.Documents;
using E_Barangay.Forms;
using E_Barangay.Class;

namespace E_Barangay.Documents
{
    public partial class BrgyCertforGuardian : DocumentForm
    {
        OfficerInfo o = new OfficerInfo();
        public BrgyCertforGuardian()
        {
            InitializeComponent();
        }
        public override void AcceptCitizen(Citizen c)
        {
            if (NullCheck(c))
            {
                return;
            }
            firstText.Text = c.FirstName;
            middleText.Text = c.MiddleName;
            lastText.Text = c.LastName;
            extText.Text = c.Extension;

            SexOption.Text = c.Gender;
            Address.Text = c.Address;
            CStatusOption.Text = c.CivilStatus;
        }
        public override void InitializeControls()
        {
            o.InitDropdowns(officerOption);

            AddControls(firstText, middleText, lastText, extText,
                        SexOption, CStatusOption, Address,
                        officerOption, IssuedOn);
        }
        public override void Printing_PrintPage(object sender, PrintPageEventArgs e)
        {
            base.Printing_PrintPage(sender, e);

            string name = Printing.GetFullName(firstText, middleText, lastText, extText);

            string text = "To whom it may concern:" + Printing.LineSpace +
                          Printing.Indention + "This is to certify that "+name+" of legal age, "+CStatusOption.Text+", Filipino and is a resident of "+Address.Text+"." + Printing.LineSpace +
                          Printing.Indention + "This is to certify further that "+SexOption.MrMs()+" "+lastText.Text+" is the GUARDIAN of "+SexOption.HisHer()+" "+relations.Text+" Named: "+wardName.Text+"."+Printing.LineSpace+
                          Printing.Indention + "This certification issued upon the request of "+SexOption.MrMs()+" "+lastText.Text+" for whatever legal purpose it may serve to "+SexOption.HimHer()+"."+Printing.LineSpace+
                          Printing.Indention + "Issued this "+IssuedOn.Value.Day+"th day of "+IssuedOn.Value.ToString("MMMM, yyyy")+" Barangay Poblacion, Kalibo, Aklan.";

            e.Graphics.DrawString(text, Printing.font, Brushes.Black, rect);
            DrawDebugRecs(rect, e);
            Printing.DrawCapSb(e, o.captName, officerOption.Text);
        }
    }
}
