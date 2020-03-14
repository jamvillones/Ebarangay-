using E_Barangay.Class;
using E_Barangay.Forms;
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

namespace E_Barangay.Documents
{
    public partial class BrgyCertificationforbusiness : DocumentForm
    {
        OfficerInfo o = new OfficerInfo();
        public BrgyCertificationforbusiness()
        {
            InitializeComponent();
        }
        public override void InitializeControls()
        {
            AddControls(firstName,
                        middleName,
                        lastName,
                        ext,
                        sexOption,
                        cStatus,
                        address,
                        age,
                        profession,
                        profStatus,
                        institution,
                        income,
                        issuedOn,
                        officerOption);

            o.InitDropdowns(officerOption);
        }
        public override void Printing_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.DeathCertificate, Point.Empty);
            InitBodyRect(e);

            string name = firstName.Text + " " + middleName.Text + " " + lastName.Text + (string.IsNullOrEmpty(ext.Text) ? "" : " " + ext.Text);
            string text = "To whom it may concern:" + Printing.LineSpace +
                          Printing.Indention + "This is to certify that "+sexOption.MrMs()+" "+name+" "+age.Text+" years old, "+cStatus.Text+", Filipino and a  resident of "+address.Text+"." + Printing.LineSpace +
                          Printing.Indention + "This is to certify further that "+sexOption.MrMs()+" "+name+" is employed as a "+profession.Text+" in a "+profStatus.Text+" status in "+institution.Text+",  and earning an income more or less Php "+income.Text+" monthly." + Printing.LineSpace +
                          Printing.Indention + "This certification is issued upon the request of  "+sexOption.MrMs()+" "+lastName.Text+"  for the purpose of his Application for "+purpose.Text+"." + Printing.LineSpace +
                          Printing.Indention + "Issued this "+issuedOn.Value.Day+"th day of "+issuedOn.Value.ToString("MMMM, yyyy")+" Barangay Poblacion, Kalibo, Aklan.";
            e.Graphics.DrawString(text, Printing.font, Brushes.Black, rect);

            Printing.DrawSpecimenSignature(e, name);

        
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
            cStatus.Text = c.CivilStatus;
            address.Text = c.Address;
            age.Text = c.Birthday.ToAge().years.ToString();
        }
    }
}
