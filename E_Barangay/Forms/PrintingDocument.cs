using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Barangay.Forms
{
    public partial class PrintingDocument : UserControl, Interface.IAccept
    {
        Form form;
        public PrintingDocument()
        {
            InitializeComponent();
        }

        public Button getAcceptButton()
        {
            return null;
        }

      

        private void PrintingDocument_Load(object sender, EventArgs e)
        {
            //CreateMyListView();
        }
        public event EventHandler<bool> OpeningForm;

        void CreateForm<T>() where T : Form, new()
        {
            if (form == null)
            {
                OpeningForm?.Invoke(this,true);
                form = new T();
               // form.TopMost = true;
                form.FormClosed += Form_FormClosed;
                form.Show();
                //form.Activate();
            }
            else
            {
                MessageBox.Show("A form is already open");
            }

        }
        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            OpeningForm?.Invoke(this, false);
            form = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateForm<BarangayClearanceForm>();
        }
        private void BussClearanceBtn_Click(object sender, EventArgs e)
        {
            CreateForm<BarangayBussClearance>();
        }
        private void deathCertBtn_Click(object sender, EventArgs e)
        {
            CreateForm<DeathCertificate>();
        }

        private void buildingPermitBtn_Click(object sender, EventArgs e)
        {
            CreateForm<BuildingPermit>();
        }

        private void certAppearanceBtn_Click(object sender, EventArgs e)
        {
            CreateForm<CertificateAppearance>();
        }

        private void certIndigencyBtn_Click(object sender, EventArgs e)
        {
            CreateForm<CertificateOfIndigency>();
        }
    }
}
