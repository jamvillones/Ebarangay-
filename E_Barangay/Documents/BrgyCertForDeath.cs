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
using E_Barangay.Documents;
using E_Barangay.Forms;

namespace E_Barangay.Documents
{
    public partial class BrgyCertForDeath : DocumentForm
    {
        OfficerInfo o = new OfficerInfo();
        public BrgyCertForDeath()
        {
            InitializeComponent();
        }
        public override void Printing_PrintPage(object sender, PrintPageEventArgs e)
        {
            base.Printing_PrintPage(sender, e);

            string name = Printing.GetFullName(firstName, middleName, lastName, ext);
            string _name = Printing.GetName(firstName, middleName, lastName, ext);

            string first = "To whom it may concern:" + Printing.LineSpace +
                            Printing.Indention + "This is to certify that as per record of this Barangay " + name + ", " + age.PrintAge() + ", " + civilStatusOption.Text + ", Filipino has been a resident of " + Address.Text + (isIndigent.Checked ? ", belongs to an indigent family." : ".") + (yearsOfStay.Value > 0 ? " " + sexOption.HeShe(true) + "'s been stayin at Barangay Poblacion for " + yearsOfStay.Value + " years." : "") + Printing.LineSpace +
                            Printing.Indention + "This is to certify further that " + name + " died last " + DeathDate.Value.ToString("MMMM dd,yyyy") + " at " + deathPlace.Text + "." + Printing.LineSpace +
                            Printing.Indention + "This certification is issued upon the request of " + Printing.HisOrHer(sexOption.Text) + " " + Relation.Text + " " + By.Text + " for "+(string.IsNullOrEmpty(purpose.Text)? "whatever legal purpose it may serve " + reqSexOption.HimHer():purpose.Text) + "." + Printing.LineSpace +
                            Printing.Indention + "Issued this " + IssuedOn.customFormat() + " Barangay Poblacion, Kalibo, Aklan.";

            e.Graphics.DrawString(first, Printing.font, Brushes.Black, rect);
            DrawDebugRecs(rect, e);

            Printing.DrawCapSb(e, o.captName, officerOption.Text);
            Printing.DrawSpecimenSignature(e, _name);
        }
        public override void InitializeControls()
        {
            base.InitializeControls();
            AddControls(firstName, middleName, lastName, ext, age, sexOption, civilStatusOption, Address, By, reqSexOption, Relation, IssuedOn, officerOption, DeathDate, deathPlace); ;

            foreach (var x in o.sbMemebers)
            {
                officerOption.Items.Add(x);
                officerOption.AutoCompleteCustomSource.Add(x);
            }
        }
        public override void AcceptCitizen(Citizen c)
        {
            if (c == null)
            {
                MessageBox.Show("Not found");
                return;
            }
            firstName.Text = c.FirstName;
            middleName.Text = c.MiddleName;
            lastName.Text = c.LastName;
            ext.Text = c.Extension;

            civilStatusOption.Text = c.CivilStatus;
            sexOption.Text = c.Gender;
            Address.Text = c.Address;
            age.Value = c.getAGe();
            isIndigent.Checked = c.Indigent;
        }
    }
}
