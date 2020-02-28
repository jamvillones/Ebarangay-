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

namespace E_Barangay.Forms
{
    public partial class DeathCertificate : Form
    {
        public DeathCertificate()
        {
            InitializeComponent();
        }
        Class.OfficersForInfoForPrinting o;
        private void DeathCertificate_Load(object sender, EventArgs e)
        {
            printing.PrintPage += Printing_PrintPage;
            printing.SubscribeToFields(fullName, Age, Address, DeathPlace, DeathDate, IssuedOn, By, SexOption, Relation,officerOption);

            o = new Class.OfficersForInfoForPrinting();
            foreach (var x in o.sbMemebers)
            {
                officerOption.Items.Add(x);
                officerOption.AutoCompleteCustomSource.Add(x);
            }
        }
       

        private void Printing_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.DeathCertificate, new PointF(0, 0));
            Rectangle rect = new Rectangle(e.PageBounds.Width / 3 - 30, e.PageBounds.Height / 3 + 50, 550, 380);
            string name = Printing.IfControlEmpty(fullName);
            string first = Printing.Indention + "This is to certify that as per record of this Barangay, " + name + " " + Printing.IfControlEmpty(Age) + " years old, Filipino and a resident of " + Printing.IfControlEmpty(Address) + "." + Printing.LineSpace +
                           Printing.Indention + "This is to certify further that " + name + " died last " + DeathDate.Value.ToString("MMMM dd, yyyy") + " at " + Printing.IfControlEmpty(DeathPlace) + "." + Printing.LineSpace +
                           Printing.Indention + "This certification is issued upon the request of " + Printing.HisOrHer(SexOption.Text) + " " + Relation.Text + " " + By.Text + " for whatever legal purpose it may serve "+Printing.HimOrHer(SexOption.Text)+"." + Printing.LineSpace +
                           Printing.Indention + "Issued this " + IssuedOn.Value.Day + "th of " + IssuedOn.Value.ToString("MMMM yyyy") + " Barangay Poblacion, Kalibo, Aklan.";
            e.Graphics.DrawString(first, Printing.font, Brushes.Black, rect);
            DrawDebugRecs(rect, e);

            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;

            Rectangle captRec = new Rectangle(e.PageBounds.Width * 3 / 5-2, e.PageBounds.Height * 2 / 3 +45, 270, 28);
            e.Graphics.DrawString(o.captName.ToUpper(), Printing.fontBold, Brushes.Black, captRec, format);
            DrawDebugRecs(captRec, e);

            Rectangle sbRect = new Rectangle(e.PageBounds.Width * 3 / 5-2 , e.PageBounds.Height * 3 / 4 + 22, 270, 28);
            e.Graphics.DrawString(Printing.IfControlEmpty(officerOption).ToUpper(), Printing.fontBold, Brushes.Black, sbRect, format);
            DrawDebugRecs(sbRect, e);
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
            fullName.Text = c.getNameWithSpace();
            int age = DateTime.Today.Year - c.Birthday.Year;
            Age.Text = age > 0 ? age.ToString() : 1.ToString();
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
            clearFields(fullName, Age, Address, DeathPlace, DeathDate, IssuedOn, By, SexOption, Relation);
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
            if(e.KeyCode == Keys.F4)
            {
                debug = !debug;
                printing.UpdateDocument();
            }
        }
    }
}
