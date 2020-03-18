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
    public partial class BrgyCertificationforBurial : DocumentForm
    {
        OfficerInfo o = new OfficerInfo();
        public BrgyCertificationforBurial()
        {
            InitializeComponent();
        }

        public override void Printing_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.BrgyCertificationforBurial, Point.Empty);
            Rectangle rect = new Rectangle(e.PageBounds.Width / 3 - 30, e.PageBounds.Height / 3 - 10, 550, 380);

            string name = Printing.GetFullName(firstName, middleName, lastName, ext);
            string first = "To whom it may concern:" + Printing.LineSpace +
                            Printing.Indention + "This is to certify that " + Printing.MrOrMrs(sex.Text) + " " + name + " of legal age, " + cStatus.Text + ", Filipino, has been a resident of " + Address.Text + " belongs to an  indigent family in this Barangay."+Printing.LineSpace+
                            Printing.Indention+ "This certification is issued upon the request of "+sex.HisHer()+" "+Relation.Text+" "+reqSex.MrMs()+" "+By.Text+ " in support to "+Printing.HisOrHer(reqSex.Text)+" claim for the Burial Assistance from the "+FromThe.Text+ ", in behalf of their immediate family members."+Printing.LineSpace+
                            Printing.Indention+ "Issued this "+IssuedOn.customFormat()+" Barangay Poblacion, Kalibo, Aklan.";

            e.Graphics.DrawString(first, Printing.font, Brushes.Black, rect);
            DrawDebugRecs(rect, e);

            Printing.DrawCapSb(e,o.captName,officerOption.Text.ToUpper());
            
        }
        public override void InitializeControls()
        {
            AddControls(firstName, middleName, lastName, ext, sex, cStatus, Age, Address, By, FromThe, IssuedOn, Relation, reqSex, officerOption);
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

            sex.Text = c.Gender;
            cStatus.Text = c.CivilStatus;
            int age = DateTime.Today.Year - c.Birthday.Year;
            Age.Text = age > 0 ? age.ToString() : 1.ToString();
            Address.Text = c.Address;
        }
       
    }
}
