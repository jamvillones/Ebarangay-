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
    public partial class BuildingPermit : Form
    {
        public BuildingPermit()
        {
            InitializeComponent();
        }

        private void DeathCertificate_Load(object sender, EventArgs e)
        {
            printing.PrintPage += Printing_PrintPage;
            printing.SubscribeToFields(fullNameField, Address,tdNoField, specField, IssuedOn, SexOption);
        }

        private void Printing_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.BuildingPermit, new PointF(0, 0));
            Rectangle rect = new Rectangle(e.PageBounds.Width / 3 - 30, e.PageBounds.Height / 3 + 50, 550, 380);
            string name = Printing.IfControlEmpty(fullNameField);
            string first = Printing.Indention + "This certification is issued to " + name + ", of legal age, Filipino and a residing at "+Printing.IfControlEmpty(Address)+", per TD No." + Printing.IfControlEmpty(tdNoField) + " in support of " + Printing.HisOrHer(SexOption.Text) + " application for " + Printing.IfControlEmpty(specField) + " permit with the Local Government Unit (LGU) Kalibo." + Printing.LineSpace +
                           Printing.Indention + "Issued this " + IssuedOn.Value.Day + "th day of " + IssuedOn.Value.ToString("MMMM, yyyy") + " at Barangay Poblacion, Kalibo, Aklan.";

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
            fullNameField.Text = c.Name;
            //int age = Class.DateTimeExtension.ToAge(c.Birthday).years;
            SexOption.Text = c.Gender;
            Address.Text = c.Address;
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
            clearFields(fullNameField, Address, tdNoField, specField, IssuedOn, SexOption);
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
