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
    public partial class BrgyCertForNGO : DocumentForm
    {
        public BrgyCertForNGO()
        {
            InitializeComponent();
        }
        public override void AcceptCitizen(Citizen c)
        {
            base.AcceptCitizen(c);
        }
        public override void Printing_PrintPage(object sender, PrintPageEventArgs e)
        {
            base.Printing_PrintPage(sender, e);
        }
        public override void InitializeControls()
        {
            base.InitializeControls();
        }
    }
}
