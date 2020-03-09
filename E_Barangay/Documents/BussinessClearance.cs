using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using E_Barangay.Class;

namespace E_Barangay.Forms
{
    public partial class BussinessClearance : Form, Interface.ICitizenAcceptor
    {
        List<Control> controls = new List<Control>();
        public BussinessClearance()
        {
            InitializeComponent();

            controls.Add(firstName);
            controls.Add(Address);
            controls.Add(OrNo);
            controls.Add(OrAmount);
            controls.Add(IssuedOn);
            controls.Add(ORIssueDate);
            controls.Add(Establishment);
            controls.Add(BussAdress);
        }

        private void BarangaCertificationforBusiness_Load(object sender, EventArgs e)
        {
            printing.PrintPage += Printing_PrintPage;
            printing.SubscribeToFields(controls.ToArray());
        }

        private void Printing_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.BussinessClearance, 0, 0);
            string name = Printing.IfControlEmpty(this.firstName);
            //var helper = new Class.NameHelper(name);

            #region firstbatch
            Rectangle firstRect = new Rectangle(e.PageBounds.Width / 3 - 30, e.PageBounds.Height / 3 - 10, 548, 50);
            string FirstBatch = Printing.Indention + Printing.GetFullName(firstName, middleName, lastName, extension) + " of legal age, Filipino and residing at " +
                                Printing.IfControlEmpty(Address) + " to operate:";
            e.Graphics.DrawString(FirstBatch, Printing.font, Brushes.Black, firstRect);
            DrawDebugRecs(firstRect, e);
            #endregion

            #region Businessname
            Rectangle bussRect = new Rectangle(e.PageBounds.Width / 3 - 30, e.PageBounds.Height / 3 + 65, 548, 30);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;

            e.Graphics.DrawString(Printing.IfControlEmpty(Establishment), Printing.fontBold, Brushes.Black, bussRect, format);
            // e.Graphics.DrawRectangle(Printing.pen, rect1);
            DrawDebugRecs(bussRect, e);
            #endregion

            #region thirdbatch
            Rectangle rect2 = new Rectangle(e.PageBounds.Width / 3 - 30, e.PageBounds.Height / 3 + 120, 548, 295);
            string details = "With business address at " + Printing.IfControlEmpty(BussAdress) + ".\n" +
                             "This further certifies that the said applicant applying for Business Permit has no records of violations or pending case in this Barangay that could affect the general welfare in the area." +
                             Printing.LineSpace + "This BARANGAY CLEARANCE is hereby issued to the above application in Accordance with Section 152 ©. Of the Local Government Code of 1991." +
                             Printing.LineSpace + "This " + IssuedOn.Value.Day + "th day of " + IssuedOn.Value.ToString("MMMM") + ", " + IssuedOn.Value.Year + " at Barangay Hall, Poblacion, Kalibo, Aklan." +
                             Printing.LineSpace + "Conforme";
            e.Graphics.DrawString(details, Printing.font, Brushes.Black, rect2);
            // e.Graphics.DrawRectangle(Printing.pen, rect2);
            DrawDebugRecs(rect2, e);
            #endregion

            #region Signature
            string s =(string.IsNullOrEmpty(middleName.Text)?string.Empty: middleName.Text[0].ToString());
            string signName = firstName.Text + " " + s + ". " + lastName.Text + (string.IsNullOrEmpty(extension.Text) ? "" : " " + extension.Text);
            ///sign
            var SignRect = new Rectangle(e.PageBounds.Width / 3 - 30, e.PageBounds.Height + 10 - 290, 240, 30);
            //string Name = Printing.IfControlEmpty(this.nameField) + " " + Printing.IfControlEmpty(middleName) + ". " + Printing.IfControlEmpty(lastName);
            e.Graphics.DrawString(signName, Printing.fontBold, Brushes.Black, SignRect);
            //e.Graphics.DrawRectangle(Printing.pen, SignRect);
            DrawDebugRecs(SignRect, e);
            ///end

            /// line
            PointF from = new PointF(e.PageBounds.Width / 3 - 30, e.PageBounds.Height - 260);
            SizeF size = e.Graphics.MeasureString(signName, Printing.fontBold);
            PointF to = new PointF(e.PageBounds.Width / 3 - 30 + size.Width, e.PageBounds.Height - 260);
            e.Graphics.DrawLine(Printing.pen, from, to);
            ///end
            #endregion

            #region OR
            var ORRect = new Rectangle(e.PageBounds.Width / 3 - 30, e.PageBounds.Height + 10 - 260, 240, 85);
            string orTxt = "OR No: " + Printing.IfControlEmpty(OrNo) + "\n" +
                           "DATE: " + ORIssueDate.Value.ToString("MMMM") + " " + ORIssueDate.Value.Day.ToString() + ", " + ORIssueDate.Value.Year.ToString() + "\n" +
                           "AMOUNT:" + Printing.IfControlEmpty(OrAmount) + "\n" +
                           "Note: Valid Until: " + OrValidityDate.Value.ToString("MMMM") + " " + OrValidityDate.Value.Day.ToString() + ", " + OrValidityDate.Value.Year.ToString();

            e.Graphics.DrawString(orTxt, Printing.font, Brushes.Black, ORRect);

            DrawDebugRecs(ORRect, e);
            //e.Graphics.DrawRectangle(Printing.pen, ORRect);
            #endregion

        }

        bool debug = false;
        void DrawDebugRecs(Rectangle rec, PrintPageEventArgs e)
        {
            if (debug)
            {
                e.Graphics.DrawRectangle(Printing.pen, rec);
            }
        }

        #region Assigning
        private void AssignBtn_Click(object sender, EventArgs e)
        {
            using (var entity = new EBarangayEntities())
            {
                var citizen = entity.Citizens.Find(IDField.Text);
                AcceptCitizen(citizen);
            }
        }

        public void AcceptCitizen(Citizen citizen)
        {
            if (citizen == null)
            {
                MessageBox.Show("User Not found");
                IDField.SelectAll();
                this.ActiveControl = IDField;
                return;
            }
            firstName.Text = citizen.FirstName;
            middleName.Text = citizen.MiddleName;
            lastName.Text = citizen.LastName;
            extension.Text = citizen.Extension;
            Address.Text = citizen.Address;
        }
        #endregion

        #region Clearing
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            clearFields(controls.ToArray());
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
