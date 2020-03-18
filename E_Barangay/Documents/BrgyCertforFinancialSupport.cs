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
    public partial class BrgyCertforFinancialSupport : DocumentForm
    {
        OfficerInfo o = new OfficerInfo();
        public BrgyCertforFinancialSupport()
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
            ext.Text = c.Extension;
            sexOption.Text = c.Gender;
            address.Text = c.Address;
            cStatus.Text = c.CivilStatus;

        }
        public override void InitializeControls()
        {
            o.InitDropdowns(officerOption);
            AddControls(firstName,
                        middleName,
                        lastName,
                        ext,
                        sexOption,
                        cStatus,
                        address,
                        inBehalf,
                        relations,
                        reqSex,
                        institution,
                        forWhat,
                        issuedOn,
                        officerOption);

        }
        public override void Printing_PrintPage(object sender, PrintPageEventArgs e)
        {
            base.Printing_PrintPage(sender, e);

            string name = firstName.Text + " " + middleName.Text + " " + lastName.Text + (string.IsNullOrEmpty(ext.Text) ? "" : " " + ext.Text);
            string text = "To whom it may concern:" + Printing.LineSpace +
                          Printing.Indention + "This is to certify further that " + sexOption.MrMs() + " " + name + " belongs to an indigent family in this barangay and is asking for utmost humanitarian consideration and possible assistance from the " + institution.Text + " for " + forWhat.Text + ", in behalf of " + sexOption.HisHer() + " " + relations.Text + " " + inBehalf.Text + "." + Printing.LineSpace +
                          Printing.Indention + "This certification is issued upon the request of " + name + "  in support to " + sexOption.HisHer() + " claim for the assistance extended to their family." + Printing.LineSpace +
                          Printing.Indention + "Issued this " + issuedOn.customFormat() + " Barangay Poblacion, Kalibo, Aklan.";
            e.Graphics.DrawString(text, Printing.font, Brushes.Black, rect);
            DrawDebugRecs(rect, e);
            Printing.DrawCapSb(e, o.captName, officerOption.Text);
        }
    }
}
