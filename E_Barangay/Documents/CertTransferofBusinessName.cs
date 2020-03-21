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
    public partial class CertTransferofBusinessName : DocumentForm
    {
        public CertTransferofBusinessName()
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
        }
        public override void InitializeControls()
        {
            o.InitDropdowns(offiicerOption);
            AddControls(firstName, middleName, lastName, extension,
                        sex,Establishment,busAddress,relations,currentOwner,reason,IssuedOn,offiicerOption);
        }
        public override void Printing_PrintPage(object sender, PrintPageEventArgs e)
        {
            base.Printing_PrintPage(sender, e);
            string name = Printing.GetName(firstName, middleName, lastName, extension);
            string text = "To whom it may concern:"+Printing.LineSpace+
                           Printing.Indention+ "This is to certify that "+Establishment.Text+" at "+busAddress.Text+" in the name of "+sex.HimHer()+" "+relations.Text+", "+currentOwner.Text+" who "+reason.Text+" has been transfer to "+name+Printing.LineSpace+
                           Printing.Indention+ "This certification is issued upon the request of "+sex.MrMrs()+" "+lastName.Text+", for whatever legal intent it may serve "+sex.HimHer()+"."+Printing.LineSpace+
                           Printing.Indention+ "Issued this "+IssuedOn.customFormat()+" Barangay Poblacion, Kalibo, Aklan.";

            e.Graphics.DrawString(text, Printing.font, Brushes.Black, rect);
            DrawDebugRecs(rect, e);


            Printing.DrawCapSb(e, o.captName, offiicerOption.Text);
        }

        OfficerInfo o = new OfficerInfo();
    }
}
