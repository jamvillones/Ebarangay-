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
    public partial class CertificationForGoodMoral : DocumentForm
    {
        public CertificationForGoodMoral()
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

            sex.Text = c.Gender;
            address.Text = c.Address;
        }
        public override void InitializeControls()
        {
            o.InitDropdowns(officerOption);
            AddControls(firstName, middleName, lastName, extension,
                        address, sex, issuedOn, officerOption);
        }
        public override void Printing_PrintPage(object sender, PrintPageEventArgs e)
        {
            base.Printing_PrintPage(sender, e);

            string _name = Printing.GetName(firstName, middleName, lastName, extension);
            string text = "To whom it may concern:" + Printing.LineSpace +
                          Printing.Indention + "This is to certify that "+_name+", is a resident of "+address.Text+". "+sex.HeShe()+" is a person of Good Moral character and bears no records of misdemeanor on this barangay." + Printing.LineSpace +
                          Printing.Indention + "This certification is issued for whatever legal purpose it may serve "+sex.HimHer()+"." + Printing.LineSpace +
                          Printing.Indention + "Issued this "+issuedOn.customFormat()+" at Poblacion Kalibo, Aklan.";
            e.Graphics.DrawString(text, Printing.font, Brushes.Black, rect);
            DrawDebugRecs(rect, e);
            Printing.DrawCapSb(e, o.captName, officerOption.Text);
        }
        OfficerInfo o = new OfficerInfo();
    }
}
