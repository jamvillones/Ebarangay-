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
    public partial class CertIndigentMedicalAssistance : DocumentForm
    {
        OfficerInfo o = new OfficerInfo();
        public CertIndigentMedicalAssistance()
        {
            InitializeComponent();
        }

        public override void Printing_PrintPage(object sender, PrintPageEventArgs e)
        {
            CustomHeaderCert(e, "BARANGAY CERTIFICATION/INDIGENCY");
            InitBodyRect(e);
            string name = Printing.GetFullName(firstName, middleName, lastName, ext);
            string first = "To whom it may concern:" + Printing.LineSpace +
                            Printing.Indention + "This is to certify that " + name + ", " + Age.Text + " years old " + reqSexOption.Text + ", Filipino and a resident of " + Address.Text + " and a duly resident of this Barangay belongs to an indigent family." + Printing.LineSpace +
                            Printing.Indention + "This certification is issued upon the request of " + reqSexOption.MrMs() + " " + By.Text + ", " + sexOption.HisHer() + " " + Relation.Text + " of legal age, who would like to seek Financial/Medical Assistance from the " + FromTo.Text + " in behalf of their immediate family member." + Printing.LineSpace +
                            Printing.Indention + "Issued this " + IssuedOn.customFormat() + " Barangay Poblacion, Kalibo, Aklan.";

            e.Graphics.DrawString(first, Printing.font, Brushes.Black, rect);
            DrawDebugRecs(rect, e);

            Printing.DrawCapSb(e, o.captName, officerOption.Text);
        }


        public override void AcceptCitizen(Citizen c)
        {
            if (c == null)
            {
                ShowNotFound();
                return;
            }

            firstName.Text = c.FirstName;
            middleName.Text = c.MiddleName;
            lastName.Text = c.LastName;
            ext.Text = c.Extension;
            sexOption.Text = c.Gender;
            int age = DateTime.Today.Year - c.Birthday.Year;
            Age.Text = age > 0 ? age.ToString() : 1.ToString();
            Address.Text = c.Address;
        }
        public override void InitializeControls()
        {
            o.InitDropdowns(officerOption);
            AddControls(firstName,
                        middleName,
                        lastName,
                        ext,
                        Address,
                        sexOption,
                        Age,
                        By,
                        reqSexOption,
                        Relation,
                        FromTo,
                        IssuedOn,
                        officerOption);
        }

    }
}
