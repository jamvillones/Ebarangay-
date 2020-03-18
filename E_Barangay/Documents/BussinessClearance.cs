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
using E_Barangay.Forms;
namespace E_Barangay.Documents
{
    public partial class BussinessClearance : DocumentForm
    {
        public BussinessClearance()
        {
            InitializeComponent();
        }

        public override void Printing_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.BussinessClearance, 0, 0);
            string name = Printing.GetFullName(firstName, middleName, lastName, extension);
            //var helper = new Class.NameHelper(name);

            #region firstbatch
            Rectangle firstRect = new Rectangle(e.PageBounds.Width / 3 - 30, e.PageBounds.Height / 3 - 10, 548, 50);
            string FirstBatch = Printing.Indention + name + " of legal age, Filipino and residing at " +
                                Printing.IfControlEmpty(address) + " to operate:";
            e.Graphics.DrawString(FirstBatch, Printing.font, Brushes.Black, firstRect);
            DrawDebugRecs(firstRect, e);
            #endregion

            #region Businessname
            Rectangle bussRect = new Rectangle(e.PageBounds.Width / 3 - 30, e.PageBounds.Height / 3 + 65, 548, 30);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;

            e.Graphics.DrawString(Printing.IfControlEmpty(establishmentName), Printing.fontBold, Brushes.Black, bussRect, format);
            // e.Graphics.DrawRectangle(Printing.pen, rect1);
            DrawDebugRecs(bussRect, e);
            #endregion

            #region thirdbatch
            Rectangle rect2 = new Rectangle(e.PageBounds.Width / 3 - 30, e.PageBounds.Height / 3 + 120, 548, 295);
            string details = "With business address at " + Printing.IfControlEmpty(bussAdd) + ".\n" +
                             "This further certifies that the said applicant applying for Business Permit has no records of violations or pending case in this Barangay that could affect the general welfare in the area." +
                             Printing.LineSpace + "This BARANGAY CLEARANCE is hereby issued to the above application in Accordance with Section 152 ©. Of the Local Government Code of 1991." +
                             Printing.LineSpace + "This " + issuedOn.customFormat()+ ", " + issuedOn.Value.Year + " at Barangay Hall, Poblacion, Kalibo, Aklan." +
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
            string orTxt = "OR No: " + Printing.IfControlEmpty(orNo) + "\n" +
                           "DATE: " + orIssueDate.Value.ToString("MMMM") + " " + orIssueDate.Value.Day.ToString() + ", " + orIssueDate.Value.Year.ToString() + "\n" +
                           "AMOUNT:" + Printing.IfControlEmpty(orAmount) + "\n" +
                           "Note: Valid Until: " + orValidityDate.Value.ToString("MMMM") + " " + orValidityDate.Value.Day.ToString() + ", " + orValidityDate.Value.Year.ToString();

            e.Graphics.DrawString(orTxt, Printing.font, Brushes.Black, ORRect);

            DrawDebugRecs(ORRect, e);
            //e.Graphics.DrawRectangle(Printing.pen, ORRect);
            #endregion

        }
        public override void InitializeControls()
        {
            AddControls(firstName,
                        middleName,
                        lastName,
                        extension,
                        address,
                        establishmentName,
                        bussAdd,
                        orNo,
                        orAmount,
                        orIssueDate,
                        orValidityDate,
                        issuedOn);
        }
        public override void AcceptCitizen(Citizen citizen)
        {
            if (citizen == null)
            {
                MessageBox.Show("User Not found");
                return;
            }
            firstName.Text = citizen.FirstName;
            middleName.Text = citizen.MiddleName;
            lastName.Text = citizen.LastName;
            extension.Text = citizen.Extension;
            address.Text = citizen.Address;
        }
       
    }
}
