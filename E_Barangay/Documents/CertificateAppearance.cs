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
    public partial class CertificateAppearance : Form
    {
        public CertificateAppearance()
        {
            InitializeComponent();
        }

        private void DeathCertificate_Load(object sender, EventArgs e)
        {
            printing.PrintPage += Printing_PrintPage;
            printing.SubscribeToFields(firstName, lastName, Address, IssuedOn, SexOption);
        }

        private void Printing_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.CertAppearance, new PointF(0, 0));
            Rectangle rect = new Rectangle(e.PageBounds.Width / 3 - 30, e.PageBounds.Height / 3 + 50, 550, 380);
            string name = Printing.IfControlEmpty(firstName) + " " + Printing.IfControlEmpty(lastName);
            string first = Printing.Indention + "This is to certify that "+Printing.MrOrMrs(SexOption.Text)+" "+name+" has appeared in my office."+ Printing.LineSpace +
                           Printing.Indention + "This certification is issued to "+Printing.MrOrMrs(SexOption.Text)+" "+Printing.IfControlEmpty(lastName)+"  for whatever legal intent it may serve "+Printing.HimOrHer(SexOption.Text)+"."+Printing.LineSpace+
                           Printing.Indention + "Issued this "+IssuedOn.Value.Day+"th day of "+IssuedOn.Value.ToString("MMMM, yyyy")+" Barangay Poblacion, Kalibo, Aklan.";

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
            clearFields(firstName, lastName, Address, IssuedOn, SexOption);
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
