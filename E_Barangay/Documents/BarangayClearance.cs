using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace E_Barangay.Forms
{
    public partial class BarangayClearance : Form
    {
        public BarangayClearance()
        {
            InitializeComponent();
        }
        Class.OfficersForInfoForPrinting o = new Class.OfficersForInfoForPrinting();
        private void BarangayClearanceForm_Load(object sender, EventArgs e)
        {
            printing.PrintPage += Printing_PrintPage;
            printing.SubscribeToFields(fullNameField, Age, Address, SexOption, CStatusOption, Purpose, IssuedOn, OrNo, ORIssueDate, OrValidityDate, officerOption);

            o = new Class.OfficersForInfoForPrinting();
            foreach (var x in o.sbMemebers)
            {
                officerOption.Items.Add(x);
                officerOption.AutoCompleteCustomSource.Add(x);
            }
        }

        private void Printing_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.BarangayClearance_tmp, new PointF(0, 0));

            Pen pen = new Pen(Color.Black);
            Font font = new Font("Arial Narrow", 12, FontStyle.Regular);

            Rectangle rect = new Rectangle(e.PageBounds.Width / 3 - 30, e.PageBounds.Height / 3, 548, 300);
            string name = Printing.IfControlEmpty(fullNameField);
            var h = new Class.NameSeparatingHelper(name);
            string text = Printing.Indention + "This is to certify that as per record of this Barangay " + name + ", " + Printing.IfControlEmpty(Age) + " years old, " + Printing.IfControlEmpty(CStatusOption) + ", Filipino and a resident of " + Printing.IfControlEmpty(Address) + ", whose signature appears below has no criminal, civil or administrative charges before this office and has good moral standing in the community." + Printing.LineSpace
                          + Printing.Indention + "This certification is issued upon the request of " + Printing.MrOrMrs(SexOption.Text) + " " + h.Last + (string.IsNullOrEmpty(h.Extension) ? "" : " " + h.Extension) + " for the purpose of " + Printing.HisOrHer(SexOption.Text) + " " + Printing.IfControlEmpty(Purpose) + "." + Printing.LineSpace
                          + "WITNESS MY HAND SEAL, this " + IssuedOn.Value.Day + "th  day of " + IssuedOn.Value.ToString("MMMM") + ", " + IssuedOn.Value.Year + " at Barangay Poblacion, Kalibo, Aklan, Philippines.";

            e.Graphics.DrawString(text, font, Brushes.Black, rect);
            DrawDebugRecs(rect, e);

            var rectangleTest = new Rectangle(e.PageBounds.Width / 3 - 30, e.PageBounds.Height - 300, 240, 100);

            string orTxt = "Paid Under OR No: " + Printing.IfControlEmpty(OrNo) + "\n" +
                           "Issued On: " + ORIssueDate.Value.ToString("MMMM") + " " + ORIssueDate.Value.Day.ToString() + ", " + ORIssueDate.Value.Year.ToString() + "\n" +
                           "Note: Valid Until: " + OrValidityDate.Value.ToString("MMMM") + " " + OrValidityDate.Value.Day.ToString() + ", " + OrValidityDate.Value.Year.ToString();

            e.Graphics.DrawString(orTxt, font, Brushes.Black, rectangleTest);
            DrawDebugRecs(rectangleTest, e);

            SizeF capBoxSize = e.Graphics.MeasureString(o.captName, Printing.fontBold);
            SizeF titleBoxSize = e.Graphics.MeasureString(o.captName, Printing.font);


            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;

            Rectangle captRec = new Rectangle(e.PageBounds.Width * 3 / 5 + 20, e.PageBounds.Height * 2 / 3, 270, (int)capBoxSize.Height);
            e.Graphics.DrawString(o.captName.ToUpper(), Printing.fontBold, Brushes.Black, captRec, format);
            DrawDebugRecs(captRec, e);

            Rectangle capRecTitle = new Rectangle(e.PageBounds.Width * 3 / 5 + 20, e.PageBounds.Height * 2 / 3 + (int)capBoxSize.Height, 270, (int)titleBoxSize.Height * 2);
            e.Graphics.DrawString("Punong Barangay", Printing.font, Brushes.Black, capRecTitle, format);
            DrawDebugRecs(capRecTitle, e);

            Rectangle sbRect = new Rectangle(e.PageBounds.Width * 3 / 5 + 20, e.PageBounds.Height * 3 / 4 + 14, 270, (int)capBoxSize.Height);
            e.Graphics.DrawString(Printing.IfControlEmpty(officerOption).ToUpper(), Printing.fontBold, Brushes.Black, sbRect, format);
            DrawDebugRecs(sbRect, e);

            Rectangle sbRectTitle = new Rectangle(e.PageBounds.Width * 3 / 5 + 20, e.PageBounds.Height * 3 / 4 + 14 + (int)capBoxSize.Height, 270, (int)titleBoxSize.Height * 2);
            e.Graphics.DrawString("Sangguniang Barangay Member Officer of the Day", Printing.font, Brushes.Black, sbRectTitle, format);
            DrawDebugRecs(sbRectTitle, e);
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
            fullNameField.Text = c.Name;

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
            clearFields(fullNameField, Age, Address, CStatusOption, SexOption, Purpose, OrNo, officerOption);
        }
        void clearFields(params Control[] controls)
        {
            foreach (Control c in controls)
            {
                c.ResetText();
            }
        }
        bool debug = false;
        void DrawDebugRecs(Rectangle rec, PrintPageEventArgs e)
        {
            if (debug)
            {
                e.Graphics.DrawRectangle(Printing.pen, rec);
            }
        }

        #endregion

        private void BarangayClearance_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                debug = !debug;
                printing.UpdateDocument();
            }
        }
    }
}
