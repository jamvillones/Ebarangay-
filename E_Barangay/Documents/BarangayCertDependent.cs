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

namespace E_Barangay.Forms
{
    public partial class BarangayCertDependent : Form
    {
        public BarangayCertDependent()
        {
            InitializeComponent();
        }

        Class.OfficersForInfoForPrinting o;
        private void DeathCertificate_Load(object sender, EventArgs e)
        {
            printing.PrintPage += Printing_PrintPage;
            printing.SubscribeToFields(sinceDate,IDField,firstName, middleName, lastName, extension, address, IssuedOn, supportNameField, sexOption, supportAddressField, officerOption);

            o = new Class.OfficersForInfoForPrinting();
            foreach (var x in o.sbMemebers)
            {
                officerOption.Items.Add(x);
                officerOption.AutoCompleteCustomSource.Add(x);
            }
        }

        private void Printing_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.BarangayCertDEPENDENT, new PointF(0, 0));
            Rectangle rect = new Rectangle(e.PageBounds.Width / 3 - 30, e.PageBounds.Height / 3 + 50, 548, 320);
            string name = Printing.IfControlEmpty(firstName);
            //var h = new Class.NameHelper(name);
            string first = Printing.Indention + "This is to certify that " + Printing.GetFullName(firstName,middleName,lastName,extension)+ " of legal age, Filipino and a resident of " + Printing.IfControlEmpty(address) + "." + Printing.LineSpace +
                           Printing.Indention + "This is to certify further that " + name + " is the dependent of " + Printing.IfControlEmpty(supportNameField) + " who is presently staying at " + Printing.IfControlEmpty(supportAddressField) + " since " + sinceDate.Value.Year.ToString() + "." + Printing.LineSpace +
                           Printing.Indention + "This certification is issued upon the request of " + Printing.MrOrMrs(sexOption.Text) + " " + lastName.Text+(string.IsNullOrEmpty(extension.Text)?"":" "+extension.Text) + " for whatever legal purpose it may serve " + Printing.HisOrHer(sexOption.Text) + "." + Printing.LineSpace +
                           Printing.Indention + "Issued this " + IssuedOn.Value.Day + "th of " + IssuedOn.Value.ToString("MMMM yyyy") + " Barangay Poblacion, Kalibo, Aklan.";
            e.Graphics.DrawString(first, Printing.font, Brushes.Black, rect);
            DrawDebugRecs(rect, e);

            SizeF capBoxSize = e.Graphics.MeasureString(o.captName, Printing.fontBold);
            SizeF titleBoxSize = e.Graphics.MeasureString(o.captName, Printing.font);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;

            Rectangle captRec = new Rectangle(e.PageBounds.Width * 3 / 5 + 20, e.PageBounds.Height * 2 / 3 + 40, 270, (int)capBoxSize.Height);
            e.Graphics.DrawString(o.captName.ToUpper(), Printing.fontBold, Brushes.Black, captRec, format);
            DrawDebugRecs(captRec, e);

            Rectangle capRecTitle = new Rectangle(e.PageBounds.Width * 3 / 5 + 20, captRec.Top + (int)capBoxSize.Height, 270, (int)titleBoxSize.Height * 2);
            e.Graphics.DrawString("Punong Barangay", Printing.font, Brushes.Black, capRecTitle, format);
            DrawDebugRecs(capRecTitle, e);

            Rectangle sbRect = new Rectangle(e.PageBounds.Width * 3 / 5 + 20, capRecTitle.Bottom + 30, 270, (int)capBoxSize.Height);
            e.Graphics.DrawString(Printing.IfControlEmpty(officerOption).ToUpper(), Printing.fontBold, Brushes.Black, sbRect, format);
            DrawDebugRecs(sbRect, e);

            Rectangle sbRectTitle = new Rectangle(e.PageBounds.Width * 3 / 5 + 20, sbRect.Top + (int)capBoxSize.Height, 270, (int)titleBoxSize.Height * 2);
            e.Graphics.DrawString("Sangguniang Barangay Member Officer of the Day", Printing.font, Brushes.Black, sbRectTitle, format);
            DrawDebugRecs(sbRectTitle, e);
        }

        bool debug = false;
        void DrawDebugRecs(Rectangle rec, PrintPageEventArgs e)
        {
            if (debug)
            {
                e.Graphics.DrawRectangle(Printing.pen, rec);
            }
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
            //Class.NameSeparatingHelper helper = new Class.NameSeparatingHelper(c.Name);
            firstName.Text = c.FirstName;
            middleName.Text = c.MiddleName;
            lastName.Text = c.LastName;
            extension.Text = c.Extension;

            sexOption.Text = c.Gender;
            address.Text = c.Address;
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
            clearFields(firstName,middleName,lastName,extension,IDField, address, IssuedOn, supportNameField, sexOption, supportAddressField);
        }
        void clearFields(params Control[] controls)
        {
            foreach (Control c in controls)
            {
                c.ResetText();
            }
        }

        #endregion

        private void DeathCertificate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                debug = !debug;
                printing.UpdateDocument();
            }
        }
    }
}
