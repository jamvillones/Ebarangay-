using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace E_Barangay.Forms
{
    public partial class BarangayBussClearance : Form
    {
        public BarangayBussClearance()
        {
            InitializeComponent();
        }

        private void BarangaCertificationforBusiness_Load(object sender, EventArgs e)
        {
            printing.PrintPage += Printing_PrintPage;
            printing.SubscribeToFields(firstName,middleName,lastName);
        }

        private void Printing_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.BussinessClearance,0,0);
            //throw new NotImplementedException();
        }
    }
}
