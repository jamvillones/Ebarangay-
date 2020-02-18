using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Barangay.Forms
{
    public partial class BarangayClearance : Form
    {
        public BarangayClearance()
        {
            InitializeComponent();
        }

        private void BarangayClearanceForm_Load(object sender, EventArgs e)
        {
            printing.PrintPage += Printing_PrintPage;
            printing.SubscribeToFields(firstName, middleName, lastName, Age, Address, SexOption, CStatusOption, Purpose, IssuedOn, OrNo, ORIssueDate, OrValidityDate);
        }

        private void Printing_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.BARANGAY_CLEARANCE, new PointF(0, 0));

            Pen pen = new Pen(Color.Black);
            Font font = new Font("Arial Narrow", 12, FontStyle.Regular);

            RectangleF rect = new RectangleF(e.PageBounds.Width / 3 - 30, e.PageBounds.Height / 3, 548, 300);
            string name = Printing.IfControlEmpty(firstName) + " " + Printing.IfControlEmpty(middleName) + ". " + Printing.IfControlEmpty(lastName) + (extensionField.Text == string.Empty ? "" : " " + extensionField.Text);
            string text = Printing.Indention + "This is to certify that as per record of this Barangay " + name + ", " + Printing.IfControlEmpty(Age) + " years old, " + Printing.IfControlEmpty(CStatusOption) + ", Filipino and a resident of " + Printing.IfControlEmpty(Address) + ", whose signature appears below has no criminal, civil or administrative charges before this office and has good moral standing in the community." + Printing.LineSpace
                          + Printing.Indention + "This certification is issued upon the request of " + Printing.MrOrMrs(SexOption.Text) + " " + Printing.IfControlEmpty(lastName)+(extensionField.Text == string.Empty?"":" "+extensionField.Text) + " for the purpose of " + Printing.HisOrHer(SexOption.Text) + " " + Printing.IfControlEmpty(Purpose) + "." + Printing.LineSpace
                          + "WITNESS MY HAND SEAL, this " + IssuedOn.Value.Day + "th  day of " + IssuedOn.Value.ToString("MMMM") + ", " + IssuedOn.Value.Year + " at Barangay Poblacion, Kalibo, Aklan, Philippines.";

            e.Graphics.DrawString(text, font, Brushes.Black, rect);

            var rectangleTest = new RectangleF(e.PageBounds.Width / 3 - 30, e.PageBounds.Height - 300, 240, 100);

            string orTxt = "Paid Under OR No: " + Printing.IfControlEmpty(OrNo) + "\n" +
                           "Issued On: " + ORIssueDate.Value.ToString("MMMM") + " " + ORIssueDate.Value.Day.ToString() + ", " + ORIssueDate.Value.Year.ToString() + "\n" +
                           "Note: Valid Until: " + OrValidityDate.Value.ToString("MMMM") + " " + OrValidityDate.Value.Day.ToString() + ", " + OrValidityDate.Value.Year.ToString();

            e.Graphics.DrawString(orTxt, font, Brushes.Black, rectangleTest);
        }

        #region autoAssign
        public void AcceptCitizen(Citizen c)
        {
            if (c == null)
            {
                MessageBox.Show("Not found");
                IDField.SelectAll();
                this.ActiveControl = IDField;
                return;
            }
            Class.NameSeparatingHelper helper = new Class.NameSeparatingHelper(c.Name);
            firstName.Text = helper.First;
            middleName.Text = helper.Middle;
            lastName.Text = helper.Last;
            extensionField.Text = helper.Extension;

            int age = DateTime.Today.Year - c.Birthday.Year;
            Age.Text = age > 0 ? age.ToString() : 1.ToString();
            Address.Text = c.Address;
            CStatusOption.Text = c.CivilStatus;
            SexOption.Text = c.Gender;
        }
        private void AssignBtn_Click(object sender, EventArgs e)
        {
            using (var entity = new EBarangayEntities())
            {
                var citizen = entity.Citizens.Find(IDField.Text);
                AcceptCitizen(citizen);
            }
        }
        #endregion

        #region Clearing
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            clearFields(firstName, middleName, lastName, Age, Address, CStatusOption, SexOption, Purpose, OrNo);
        }
        void clearFields(params Control[] controls)
        {
            foreach (Control c in controls)
            {
                c.ResetText();
            }
        }

        #endregion
    }
}
