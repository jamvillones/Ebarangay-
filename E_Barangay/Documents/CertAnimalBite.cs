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
using E_Barangay.Class;
using System.Drawing.Printing;

namespace E_Barangay.Documents
{
    public partial class CertAnimalBite : DocumentForm
    {
        OfficerInfo o = new OfficerInfo();
        public CertAnimalBite()
        {
            InitializeComponent();
        }
        public override void AcceptCitizen(Citizen c)
        {
            if (NullCheck(c)) return;

            firstName.Text = c.FirstName;
            middleName.Text = c.MiddleName;
            lastName.Text = c.LastName;
            ext.Text = c.Extension;
            Age.Value = c.getAGe();
            sex.Text = c.Gender;
            Address.Text = c.Address;
        }
        public override void InitializeControls()
        {
            o.InitDropdowns(officerOption);
            AddControls(firstName, middleName, lastName, ext,
                          Age, sex, Address,
                          By, Relation, reqSexOption,
                          Institution,IssuedOn,dtIncident, officerOption);
        }
        public override void Printing_PrintPage(object sender, PrintPageEventArgs e)
        {
            base.Printing_PrintPage(sender, e);
            string name = Printing.GetFullName(firstName, middleName, lastName, ext);
            string text = ToWhom + Printing.LineSpace +
                          Printing.Indention + "This is to certify that "+name+", "+Age.GetYears()+" old, Filipino is a resident of "+Address.Text+"." + Printing.LineSpace +
                          Printing.Indention + "This further  certifies that "+name+" was bitten by a stray dog last "+dtIncident.Value.ToString("MMMM dd, yyyy")+"." + Printing.LineSpace +
                          Printing.Indention + "This certification is issued upon the request of "+sex.HisHer()+" "+Relation.Text+" "+reqSexOption.MrMs()+" "+By.Text+" in  support to "+reqSexOption.HisHer()+" claim  for the Medical/Financial Assistance from "+Institution.Text+"." + Printing.LineSpace +
                          Printing.Indention + "Issued this "+IssuedOn.Value.Day+"th day of "+IssuedOn.Value.ToString("MMMM ,yyyy")+" Barangay Poblacion, Kalibo, Aklan.";

            e.Graphics.DrawString(text, Printing.font, Brushes.Black, rect);
            DrawDebugRecs(rect, e);
            Printing.DrawCapSb(e, o.captName, officerOption.Text);
        }
    }
}
