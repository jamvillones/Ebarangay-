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
    public partial class CertificateOfIndigency : DocumentForm
    {
        OfficerInfo o = new OfficerInfo();
        public CertificateOfIndigency()
        {
            InitializeComponent();
        }
        public override void Printing_PrintPage(object sender, PrintPageEventArgs e)
        {
            // base.Printing_PrintPage(sender, e);
            e.Graphics.DrawImage(Properties.Resources.CertificateOfIndigency, new PointF(0, 0));
            Rectangle rect = new Rectangle(e.PageBounds.Width / 3 - 32,
                                           e.PageBounds.Height / 3 - 5,
                                           550, 300);

            string name = Printing.GetFullName(firstName, middleName, lastName, ext);
            string first = "To whom it may concern:"+Printing.LineSpace+
                           Printing.Indention + "This is to certify that " + name + ", " + Printing.IfControlEmpty(ageField) + " years old, " + Printing.IfControlEmpty(SexOption) + ", " + Printing.IfControlEmpty(civilStatusOption) + ",    Filipino and a resident of " + Printing.IfControlEmpty(addressField) + ", belongs to an indigent family in this Barangay" + Printing.LineSpace +
                           Printing.Indention + "This certification is issued to " + Printing.MrOrMrs(SexOption.Text) + " " + lastName.Text + (string.IsNullOrEmpty(ext.Text) ? "" : " " + ext.Text) + "  for whatever legal purposes it may serve " + Printing.HimOrHer(SexOption.Text) + " best." + Printing.LineSpace +
                           Printing.Indention + "Issued this " + IssuedOn.Value.Day + "th day of " + IssuedOn.Value.ToString("MMMM, yyyy") + " Barangay Poblacion, Kalibo, Aklan.";

            e.Graphics.DrawString(first, Printing.font, Brushes.Black, rect);
            DrawDebugRecs(rect, e);

            Printing.DrawCapSb(e, o.captName, officerOption.Text);

            //StringFormat format = new StringFormat();
            //format.Alignment = StringAlignment.Center;

            //Rectangle captRec = new Rectangle(e.PageBounds.Width * 3 / 5, e.PageBounds.Height * 2 / 3 + 35, 270, 28);
            //e.Graphics.DrawString(o.captName.ToUpper(), Printing.fontBold, Brushes.Black, captRec, format);
            //DrawDebugRecs(captRec, e);

            //Rectangle sbRect = new Rectangle(e.PageBounds.Width * 3 / 5, e.PageBounds.Height * 3 / 4 + 28, 270, 28);
            //e.Graphics.DrawString(Printing.IfControlEmpty(officerOption).ToUpper(), Printing.fontBold, Brushes.Black, sbRect, format);
            //DrawDebugRecs(sbRect, e);
        }

        public override void AcceptCitizen(Citizen c)
        {
            if (c == null)
            {
                MessageBox.Show("Not found");
                return;
            }

            firstName.Text = c.FirstName;
            middleName.Text = c.MiddleName;
            lastName.Text = c.LastName;
            ext.Text = c.Extension;

            int age = Class.DateTimeExtension.ToAge(c.Birthday).years;
            ageField.Text = age.ToString();
            civilStatusOption.Text = c.CivilStatus;
            SexOption.Text = c.Gender;
            addressField.Text = c.Address;
        }
        public override void InitializeControls()
        {
            o.InitDropdowns(officerOption);
            AddControls(firstName,
                        middleName,
                        lastName,
                        ext,
                        ageField,
                        addressField,
                        SexOption,
                        civilStatusOption,
                        IssuedOn);
        }

    }
}
