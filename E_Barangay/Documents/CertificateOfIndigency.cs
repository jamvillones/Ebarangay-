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

namespace E_Barangay.Forms
{
    public partial class CertificateOfIndigency : Form
    {
        public CertificateOfIndigency()
        {
            InitializeComponent();
        }

        private void DeathCertificate_Load(object sender, EventArgs e)
        {
            printing.PrintPage += Printing_PrintPage;
            printing.SubscribeToFields(fullNameField, addressField, IssuedOn, SexOption);
        }

        private void Printing_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.CertificateOfIndigency, new PointF(0, 0));
            Rectangle rect = new Rectangle(e.PageBounds.Width / 3 - 30, e.PageBounds.Height / 3 + 20, 550, 300);

            string name = Printing.IfControlEmpty(fullNameField);
            var helper = new Class.NameSeparatingHelper(name);
            string first = Printing.Indention + "This is to certify that " + name + ", " + Printing.IfControlEmpty(ageField) + " years old, " + Printing.IfControlEmpty(SexOption) + ", " + Printing.IfControlEmpty(civilStatusOption) + ",    Filipino and a resident of " + Printing.IfControlEmpty(addressField) + ", belongs to an indigent family in this Barangay" + Printing.LineSpace +
                           Printing.Indention + "This certification is issued to " + Printing.MrOrMrs(SexOption.Text) + " " + helper.Last + (string.IsNullOrEmpty(helper.Extension) ? "" : " " + helper.Extension) + "  for whatever legal purposes it may serve " + Printing.HimOrHer(SexOption.Text) + " best." + Printing.LineSpace +
                           Printing.Indention + "Issued this " + IssuedOn.Value.Day + "th day of " + IssuedOn.Value.ToString("MMMM, yyyy") + " Barangay Poblacion, Kalibo, Aklan.";

            e.Graphics.DrawString(first, Printing.font, Brushes.Black, rect);
            DrawDebugRecs(rect, e);
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

            //firstName.Text = helper.First;
            //middleInitialField.Text = helper.Middle;
            //lastName.Text = helper.Last;
            //extField.Text = helper.Extension;
            fullNameField.Text = c.Name;
            int age = Class.DateTimeExtension.ToAge(c.Birthday).years;
            ageField.Text = age.ToString();
            civilStatusOption.Text = c.CivilStatus;
            SexOption.Text = c.Gender;
            addressField.Text = c.Address;
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
            clearFields(fullNameField, addressField, IssuedOn, SexOption);
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
