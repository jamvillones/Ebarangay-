using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using E_Barangay.Documents;
using E_Barangay.Forms;
using E_Barangay.Class;
using System.Drawing.Printing;

namespace E_Barangay.Documents
{
    public partial class BrgyCertforResidency : DocumentForm
    {
        OfficerInfo o = new OfficerInfo();
        public BrgyCertforResidency()
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

            age.Text = c.getAGe().ToString();
            sex.Text = c.Gender;
            CStatusOption.Text = c.CivilStatus;
            Address.Text = c.Address;
        }
        public override void InitializeControls()
        {
            o.InitDropdowns(officerOption);
            AddControls(firstText, middleText, lastText, extText,
                        age, sex, CStatusOption, Address,
                        residencyYear,orNo, orValidityDate, orIssueDate);
        }
        public override void Printing_PrintPage(object sender, PrintPageEventArgs e)
        {
            base.Printing_PrintPage(sender, e);

            string name = Printing.GetFullName(firstText, middleText, lastText, extText);
            string _name = Printing.GetName(firstText, middleText, lastText, extText);
            string yearNum = residencyYear.GetYears();

            string text = ToWhom + Printing.LineSpace +
                          Printing.Indention + "This is to certify that  "+name+", "+age.Text+" years old, "+CStatusOption.Text+", Filipino, and a resident of Purok "+Address.Text+", and "+sex.HeShe()+"’s been staying at barangay Poblacion for almost "+yearNum+"." + Printing.LineSpace +
                          Printing.Indention + "This certification issued upon the request of "+sex.MrMs()+" "+lastText.Text+" for the purpose of "+sex.HisHer()+" residency." + Printing.LineSpace +
                          Printing.Indention + "Issued this "+IssuedOn.Value.Day+"th day of "+IssuedOn.Value.ToString("MMMM, yyyy")+" Barangay Poblacion, Kalibo, Aklan.";

            e.Graphics.DrawString(text, Printing.font, Brushes.Black, rect);
            DrawDebugRecs(rect, e);
            Printing.DrawSpecimenSignature(e, _name);
            Printing.DrawCapSb(e, o.captName, officerOption.Text);
            Printing.DrawValidityOr(e, orNo.Text, orIssueDate.Value, orValidityDate.Value);
        }
    }
}
