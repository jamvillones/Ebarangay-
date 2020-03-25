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
    public partial class CertificateOfIndigency : DocumentForm
    {
        OfficerInfo o = new OfficerInfo();
        public CertificateOfIndigency()
        {
            InitializeComponent();
        }
        public override void Printing_PrintPage(object sender, PrintPageEventArgs e)
        {
            CustomHeaderCert(e, "BARANGAY/CERTIFICATION/INDIGENCY");

            InitBodyRect(e);

            string name = Printing.GetFullName(firstName, middleName, lastName, ext);
            string purp = string.IsNullOrEmpty(purpose.Text) ? "for whatever legal purposes it may serve " + SexOption.HimHer() + " best." : purpose.Text;
            string first = "To whom it may concern:" + Printing.LineSpace +
                           Printing.Indention + "This is to certify that " + name + ", " + age.PrintAge() + ", " + Printing.IfControlEmpty(SexOption) + ", " + Printing.IfControlEmpty(civilStatusOption) + ",    Filipino and a resident of " + Printing.IfControlEmpty(addressField) + ", belongs to an indigent family in this Barangay" + Printing.LineSpace +
                           Printing.Indention + "This certification is issued to " + Printing.MrOrMrs(SexOption.Text) + " " + lastName.Text + (string.IsNullOrEmpty(ext.Text) ? "" : " " + ext.Text) + " " + purp + Printing.LineSpace +
                           Printing.Indention + "Issued this " + IssuedOn.customFormat() + " Barangay Poblacion, Kalibo, Aklan.";

            e.Graphics.DrawString(first, Printing.font, Brushes.Black, rect);
            DrawDebugRecs(rect, e);

            Printing.DrawCapSb(e, o.captName, officerOption.Text);           
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

            age.Value = c.getAGe();
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
                        age,
                        addressField,
                        SexOption,
                        civilStatusOption,
                        IssuedOn,
                        purpose);
        }

    }
}
