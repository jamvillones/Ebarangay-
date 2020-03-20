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
    public partial class CertForEducationalAssistance : DocumentForm
    {
        public CertForEducationalAssistance()
        {
            InitializeComponent();
        }
        public override void AcceptCitizen(Citizen c)
        {
            if (NullCheck(c)) return;
            firstName.Text = c.FirstName;
            middleName.Text = c.MiddleName;
            lastName.Text = c.LastName;
            extension.Text = c.Extension;

            age.Value = c.getAGe();
            sex.Text = c.Gender;
            civilStatus.Text = c.CivilStatus;
            address.Text = c.Address;
        }
        public override void InitializeControls()
        {
            o.InitDropdowns(offiicerOption);
            AddControls(firstName, middleName, lastName, extension,
                        age, sex, civilStatus, address,
                        institution, IssuedOn,
                        offiicerOption);
        }
        public override void Printing_PrintPage(object sender, PrintPageEventArgs e)
        {
            base.Printing_PrintPage(sender, e);
            string _name = Printing.GetName(firstName, middleName, lastName, extension);
            string text = "To whom it may concern:" + Printing.LineSpace +
                          Printing.Indention + "This is to certify that " + _name + ", " + age.Value + " years old, " + sex.Text + ", " + civilStatus.Text + ", Filipino and a resident of " + address.Text + " belong to an indigent family in this Barangay." + Printing.LineSpace +
                          Printing.Indention + "This certification is issued upon the request of " + sex.MrMrs() + " " + lastName.Text + " of legal age who would like to seek Educational Assistance from the " + institution.Text + " in behalf of their immediate family members." + Printing.LineSpace +
                          Printing.Indention + "Issued this " + IssuedOn.customFormat() + " Barangay Poblacion, Kalibo, Aklan.";
            e.Graphics.DrawString(text, Printing.font, Brushes.Black, rect);
            DrawDebugRecs(rect, e);
            Printing.DrawCapSb(e, o.captName, offiicerOption.Text);
        }
        OfficerInfo o = new OfficerInfo();
    }
}
