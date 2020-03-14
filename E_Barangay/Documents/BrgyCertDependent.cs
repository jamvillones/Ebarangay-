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
    public partial class BrgyCertDependent : Forms.DocumentForm
    {
        OfficerInfo o = new OfficerInfo();
        public BrgyCertDependent()
        {
            InitializeComponent();
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
            extension.Text = c.Extension;
            address.Text = c.Address;
            sexOption.Text = c.Gender;
        }
        public override void InitializeControls()
        {
            o.InitDropdowns(officerOption);
            AddControls(firstName,
                        middleName,
                        lastName,
                        extension,
                        supportNameField,
                        supportAddressField,
                        sinceDate,
                        IssuedOn,
                        officerOption);
        }
        public override void Printing_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(E_Barangay.Properties.Resources.BarangayCertDEPENDENT, new PointF(0, 0));
            InitBodyRect(e);
            string name = Printing.GetFullName(firstName, middleName, lastName, extension);
            string text = "To whom it may concern:" + Printing.LineSpace +
                           Printing.Indention + "This is to certify that " + name + " of legal age, Filipino and a resident of " + Printing.IfControlEmpty(address) + "." + Printing.LineSpace +
                           Printing.Indention + "This is to certify further that " + name + " is the dependent of " + Printing.IfControlEmpty(supportNameField) + " who is presently staying at " + Printing.IfControlEmpty(supportAddressField) + " since " + sinceDate.Value.Year.ToString() + "." + Printing.LineSpace +
                           Printing.Indention + "This certification is issued upon the request of " + Printing.MrOrMrs(sexOption.Text) + " " + lastName.Text + (string.IsNullOrEmpty(extension.Text) ? "" : " " + extension.Text) + " for whatever legal purpose it may serve " + Printing.HisOrHer(sexOption.Text) + "." + Printing.LineSpace +
                           Printing.Indention + "Issued this " + IssuedOn.Value.Day + "th of " + IssuedOn.Value.ToString("MMMM yyyy") + " Barangay Poblacion, Kalibo, Aklan.";
            e.Graphics.DrawString(text, Printing.font, Brushes.Black, rect);
            DrawDebugRecs(rect, e);
            Printing.DrawCapSb(e, o.captName, officerOption.Text);
        }
    }
}
