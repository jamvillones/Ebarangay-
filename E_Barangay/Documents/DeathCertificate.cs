using E_Barangay.Class;
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
    public partial class DeathCertificate : DocumentForm
    {
        OfficerInfo o = new OfficerInfo();
        public DeathCertificate()
        {
            InitializeComponent();
        }
        public override void Printing_PrintPage(object sender, PrintPageEventArgs e)
        {
            base.Printing_PrintPage(sender,e);

            string name = Printing.GetFullName(firstName, middleName, lastName, ext);
            string first = "To whom it may concern:" + Printing.LineSpace +
                           Printing.Indention + "This is to certify that as per record of this Barangay, " + name + " " + Printing.IfControlEmpty(Age) + " years old, Filipino and a resident of " + Printing.IfControlEmpty(Address) + "." + Printing.LineSpace +
                           Printing.Indention + "This is to certify further that " + name + " died last " + DeathDate.Value.ToString("MMMM dd, yyyy") + " at " + Printing.IfControlEmpty(DeathPlace) + "." + Printing.LineSpace +
                           Printing.Indention + "This certification is issued upon the request of " + Printing.HisOrHer(sex.Text) + " " + Relation.Text + " " + By.Text + " for whatever legal purpose it may serve " + Printing.HimOrHer(reqSexOption.Text) + "." + Printing.LineSpace +
                           Printing.Indention + "Issued this " + IssuedOn.Value.Day + "th of " + IssuedOn.Value.ToString("MMMM yyyy") + " Barangay Poblacion, Kalibo, Aklan.";

            e.Graphics.DrawString(first, Printing.font, Brushes.Black, rect);
            DrawDebugRecs(rect, e);

            Printing.DrawCapSb(e, o.captName, officerOption.Text);
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

            sex.Text = c.Gender;
            int age = DateTime.Today.Year - c.Birthday.Year;
            Age.Text = age > 0 ? age.ToString() : 1.ToString();
            Address.Text = c.Address;
        }
        public override void InitializeControls()
        {
            o.InitDropdowns(officerOption);
            AddControls(firstName,
                        middleName,
                        lastName,
                        ext,
                        Address,
                        Age,
                        sex,
                        By,
                        reqSexOption,
                        Relation,
                        DeathPlace,
                        DeathDate,
                        IssuedOn);
        }
    }
}
