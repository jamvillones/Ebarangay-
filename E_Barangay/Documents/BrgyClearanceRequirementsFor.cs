using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using E_Barangay.Forms;
using E_Barangay.Class;
using System.Drawing.Printing;

namespace E_Barangay.Documents
{
    /// <summary>
    /// This is a type of clearance for MKWD and other certification used as part of their requirements
    /// </summary>
    public partial class BrgyClearanceRequirementsFor : DocumentForm
    {
        public BrgyClearanceRequirementsFor()
        {
            InitializeComponent();
        }
        public override void InitializeControls()
        {
            o.InitDropdowns(officerOption);
            AddControls(firstName, middleName, lastName, ext,
                        age, addressField, SexOption, civilStatusOption,
                        applicationFor, IssuedOn, orValidityDate, orNo, IssuedOn,
                        officerOption);

        }
        public override void AcceptCitizen(Citizen c)
        {
            if (NullCheck(c))
                return;
            firstName.Text = c.FirstName;
            middleName.Text = c.MiddleName;
            lastName.Text = c.LastName;
            ext.Text = c.Extension;
            age.Value = c.getAGe();
            addressField.Text = c.Address;
            SexOption.Text = c.Gender;
            civilStatusOption.Text = c.CivilStatus;
        }
        public override void Printing_PrintPage(object sender, PrintPageEventArgs e)
        {
            base.Printing_PrintPage(sender, e);

            string _name = Printing.GetName(firstName, middleName, lastName, ext);
            string name = Printing.GetFullName(firstName, middleName, lastName, ext);
            string t = "To whom it may concern:" + Printing.LineSpace +
                       Printing.Indention + "This is to certify that "+name+", "+age.PrintAge()+", "+civilStatusOption.Text+", Filipino, and presently residing at "+addressField.Text+"." + Printing.LineSpace +
                       Printing.Indention + "This is to certify further that the above applicant has no derogatory records or pending case in this Barangay." + Printing.LineSpace +
                       Printing.Indention + "This Barangay Certification is hereby issued upon the request of "+SexOption.MrMrs()+" "+lastName.Text+" in support to "+SexOption.HisHer()+" requirements for "+applicationFor.Text+"." + Printing.LineSpace +
                       Printing.Indention + "Issued this " + IssuedOn.customFormat() + " Barangay Poblacion, Kalibo, Aklan.";
            e.Graphics.DrawString(t, Printing.font, Brushes.Black, rect);

            Printing.DrawCapSb(e, o.captName, officerOption.Text);
            Printing.DrawSpecimenSignature(e, _name);
            Printing.DrawValidityOr(e, orNo.Text, orIssueDate.Value, orValidityDate.Value);

        }
        OfficerInfo o = new OfficerInfo();
    }
}
