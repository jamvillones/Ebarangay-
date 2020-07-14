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
using E_Barangay.Forms;

namespace E_Barangay.Documents
{
    public partial class CertificateAppearance : DocumentForm
    {
        OfficerInfo o = new OfficerInfo();
        public CertificateAppearance()
        {
            InitializeComponent();
        }
        public override void Printing_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.Certificate_Template, new PointF(0, 0));
            // Rectangle rect = new Rectangle(e.PageBounds.Width / 3 - 30, e.PageBounds.Height / 3 + 50, 550, 380);
            InitBodyRect(e);
            string first = Printing.Indention + "This is to certify that " + Printing.MrOrMrs(SexOption.Text) + " " + Printing.GetFullName(firstName, middleName, lastName, extension) + " has appeared in my office." + Printing.LineSpace +
                           Printing.Indention + "This certification is issued to " + Printing.MrOrMrs(SexOption.Text) + " " + lastName.Text + (string.IsNullOrEmpty(extension.Text) ? "" : " " + extension.Text) + "  for whatever legal intent it may serve " + Printing.HimOrHer(SexOption.Text) + "." + Printing.LineSpace +
                           Printing.Indention + "Issued this " + IssuedOn.customFormat() + " Barangay Poblacion, Kalibo, Aklan.";

            e.Graphics.DrawString(first, Printing.font, Brushes.Black, rect);
            DrawDebugRecs(rect, e);
            Printing.DrawCap(e, o.captName);
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
            extension.Text = c.Extension;
            SexOption.Text = c.Gender;
            Address.Text = c.Address;
        }
        public override void InitializeControls()
        {
            AddControls(firstName,
                        middleName,
                        lastName,
                        extension,
                        Address,
                        SexOption,
                        IssuedOn);
        }

    }
}
