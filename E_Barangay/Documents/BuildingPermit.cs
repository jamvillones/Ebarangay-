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
            printing.SubscribeToFields(firstName, lastName, Address, DeathPlace, DeathDate, IssuedOn, By, SexOption, Relation);
        }

        private void Printing_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.BuildingPermit, new PointF(0, 0));
            Rectangle rect = new Rectangle(e.PageBounds.Width / 3 - 30, e.PageBounds.Height / 3 + 50, 550, 380);
            //string name = Printing.IfControlEmpty(firstName) + " " + Printing.IfControlEmpty(middleName) + " " + Printing.IfControlEmpty(lastName);
            string first = Printing.Indention + "This certification is issued to AQUILINO BUYOC, of legal age, Filipino and a residing at Cor. Oyo Torong Street Poblacion, Kalibo, Aklan, per TD No.17-01-001-00819/ 17-01-001-00820 in support of her application for 3 storey’s Residential Commercial/Building permit with the Local Government Unit (LGU) Kalibo." + Printing.LineSpace +
                           Printing.Indention + "Issued this 7th day of October, 2019 at Barangay Poblacion, Kalibo, Aklan.";

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
            List<string> nameList = new List<string>();
            string word = "";
            string name = c.Name;
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == ' ' || i == name.Length - 1)
                {
                    if (i == name.Length - 1)
                        word += name[i];
                    nameList.Add(word);
                    word = "";
                }
                else
                {
                    word += name[i];
                }
            }
            firstName.Text = nameList[0];

            lastName.Text = nameList[2];
            int age = DateTime.Today.Year - c.Birthday.Year;

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
            clearFields(firstName, lastName, Address, DeathPlace, DeathDate, IssuedOn, By, SexOption, Relation);
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
