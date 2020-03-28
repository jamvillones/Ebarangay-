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
using E_Barangay.Class;
using E_Barangay.Forms;

namespace E_Barangay.Documents
{
    public partial class BrgyCertforBusiness : DocumentForm
    {
        public BrgyCertforBusiness()
        {
            InitializeComponent();
        }
        public override void AcceptCitizen(Citizen c)
        {
            if (NullCheck(c))
                return;
            firstName.Text = c.FirstName;
            middleName.Text = c.MiddleName;
            lastName.Text = c.LastName;
            ext.Text = c.Extension;
            sexOption.Text = c.Gender;
            civilStatusOption.Text = c.CivilStatus;
            Address.Text = c.Address;
            age.Value = c.getAGe();
        }
        public override void InitializeControls()
        {
            base.InitializeControls();
            getOfficerInfo.InitDropdowns(officerOption);
            //o.InitDropdowns(officerOption);
        }
        public override void Printing_PrintPage(object sender, PrintPageEventArgs e)
        {
            base.Printing_PrintPage(sender, e);
            string _name = Printing.GetName(firstName, middleName, lastName, ext);
            rect.Height = rect.Height + 100;
            string text = "To whom it may concern:" + Printing.LineSpace +
                           Printing.Indention + "This is to certify that "+sexOption.MrMrs()+" "+_name+", "+age.PrintAge()+", "+civilStatusOption.Text+", Filipino is a resident of "+Address.Text+"." + Printing.ShortLineSpace +
                           Printing.Indention + "This is to certify further that "+sexOption.HeShe()+" operated a Business of "+busName.Text+" since "+busSince.Value.ToString("MMMM, yyyy")+" up to present located at "+busAddress.Text+", and is hereby given Barangay clearance to operate such business." + Printing.ShortLineSpace +
                           Printing.Indention + sexOption.HeShe(true)+" is likewise advised to observe and strictly comply all laws, regulations and municipal ordinance pertinent thereto." + Printing.ShortLineSpace +
                           Printing.Indention + "This certification is issued upon the request of "+sexOption.MrMrs()+" "+lastName.Text+" for the purpose of "+sexOption.HisHer()+" application for "+purpose.Text+"." + Printing.ShortLineSpace +
                           "WITNESS MY HAND SEAL, this "+issuedOn.customFormat()+" at Barangay Poblacion, Kalibo, Aklan, Philippines.";

            e.Graphics.DrawString(text, Printing.font, Brushes.Black, rect);
            DrawDebugRecs(rect, e);

            Printing.DrawCapSb(e, getOfficerInfo.captName, officerOption.Text);
            Printing.DrawSpecimenSignature(e, _name);
            Printing.DrawValidityOr(e, orNo.Text, orIssueDate.Value, orValidityDate.Value);
        }
    }
}
