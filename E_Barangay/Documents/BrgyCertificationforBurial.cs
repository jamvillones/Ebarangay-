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
    public partial class BrgyCertificationforBurial : Form
    {
        public BrgyCertificationforBurial()
        {
            InitializeComponent();
        }
        Class.OfficersForInfoForPrinting o;
        private void DeathCertificate_Load(object sender, EventArgs e)
        {
            printing.PrintPage += Printing_PrintPage;
            printing.SubscribeToFields(firstName, middleName, lastName, ext,sex, cStatus, Age, Address, FromThe, IssuedOn, By, reqSex, Relation, officerOption);

            o = new Class.OfficersForInfoForPrinting();
            foreach (var x in o.sbMemebers)
            {
                officerOption.Items.Add(x);
                officerOption.AutoCompleteCustomSource.Add(x);
            }
        }


        private void Printing_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.BrgyCertificationforBurial, new PointF(0, 0));
            Rectangle rect = new Rectangle(e.PageBounds.Width / 3 - 30, e.PageBounds.Height / 3 - 10, 550, 380);
            string name = Printing.GetFullName(firstName, middleName, lastName, ext);
            string first = "To whom it may concern:" + Printing.LineSpace +
                            Printing.Indention + "This is to certify that " + Printing.MrOrMrs(sex.Text) + " " + name + " of legal age, " + cStatus.Text + ", Filipino, has been a resident of " + Address.Text + " belongs to an  indigent family in this Barangay."+Printing.LineSpace+
                            Printing.Indention+ "This certification is issued upon the request of "+Printing.HisOrHer(reqSex.Text)+" "+Relation.Text+" "+Printing.MrOrMrs(reqSex.Text)+" "+By.Text+ " in support to "+Printing.HisOrHer(reqSex.Text)+" claim for the Burial Assistance from the "+FromThe.Text+ ", in behalf of their immediate family members."+Printing.LineSpace+
                            Printing.Indention+ "Issued this "+IssuedOn.Value.Day+"th day of "+IssuedOn.Value.ToString("MMMM, yyyy")+" Barangay Poblacion, Kalibo, Aklan.";

            e.Graphics.DrawString(first, Printing.font, Brushes.Black, rect);
            DrawDebugRecs(rect, e);

            Printing.DrawCapSb(e,o.captName,officerOption.Text.ToUpper());
            //SizeF capBoxSize = e.Graphics.MeasureString(o.captName, Printing.fontBold);
            //SizeF titleBoxSize = e.Graphics.MeasureString(o.captName, Printing.font);
            //StringFormat format = new StringFormat();
            //format.Alignment = StringAlignment.Center;

            //Rectangle captRec = new Rectangle(e.PageBounds.Width * 3 / 5 + 20, e.PageBounds.Height * 2 / 3 + 40, 270, (int)capBoxSize.Height);
            //e.Graphics.DrawString(o.captName.ToUpper(), Printing.fontBold, Brushes.Black, captRec, format);
            //DrawDebugRecs(captRec, e);

            //Rectangle capRecTitle = new Rectangle(e.PageBounds.Width * 3 / 5 + 20, captRec.Top + (int)capBoxSize.Height, 270, (int)titleBoxSize.Height * 2);
            //e.Graphics.DrawString("Punong Barangay", Printing.font, Brushes.Black, capRecTitle, format);
            //DrawDebugRecs(capRecTitle, e);

            //Rectangle sbRect = new Rectangle(e.PageBounds.Width * 3 / 5 + 20, capRecTitle.Bottom + 30, 270, (int)capBoxSize.Height);
            //e.Graphics.DrawString(Printing.IfControlEmpty(officerOption).ToUpper(), Printing.fontBold, Brushes.Black, sbRect, format);
            //DrawDebugRecs(sbRect, e);

            //Rectangle sbRectTitle = new Rectangle(e.PageBounds.Width * 3 / 5 + 20, sbRect.Top + (int)capBoxSize.Height, 270, (int)titleBoxSize.Height * 2);
            //e.Graphics.DrawString("Sangguniang Barangay Member Officer of the Day", Printing.font, Brushes.Black, sbRectTitle, format);
            //DrawDebugRecs(sbRectTitle, e);
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
            ext.Text = c.Extension;

            sex.Text = c.Gender;
            cStatus.Text = c.CivilStatus;
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
            clearFields(firstName, middleName, lastName, ext, Age, Address, FromThe, IssuedOn, By, reqSex, Relation);
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
