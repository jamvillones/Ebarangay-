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
        string[] docNames = {
            "Barangay Clearance",
            "Business Clearance",
            "Death Certificate",
            "Building Permit",
            "Certificate of Appearance",
            "Certificate of Indigency",
            "Cert Dependent"
        };
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
            setDataList();
        }
        void setDataList()
        {
            DocumentList.Rows.Clear();

            foreach (var name in docNames)
                DocumentList.Rows.Add("Open", name);
            DocumentList.Sort(DocumentList.Columns[0], ListSortDirection.Ascending);

        }
        public event EventHandler<bool> OpeningForm;

        void CreateForm<T>() where T : Form, new()
        {
            if (form == null)
            {
                OpeningForm?.Invoke(this, true);
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

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    CreateForm<BarangayClearance>();
        //}
        //private void BussClearanceBtn_Click(object sender, EventArgs e)
        //{
        //    CreateForm<BussinessClearance>();
        //}
        //private void deathCertBtn_Click(object sender, EventArgs e)
        //{
        //    CreateForm<DeathCertificate>();
        //}
        //private void buildingPermitBtn_Click(object sender, EventArgs e)
        //{
        //    CreateForm<BuildingPermit>();
        //}
        //private void certAppearanceBtn_Click(object sender, EventArgs e)
        //{
        //    CreateForm<CertificateAppearance>();
        //}
        //private void certIndigencyBtn_Click(object sender, EventArgs e)
        //{
        //    CreateForm<CertificateOfIndigency>();
        //}

        private void DocumentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                OpenDocByName(senderGrid.SelectedCells[1].Value.ToString());
            }
        }
        private void OpenDocByName(string name)
        {
            switch (name)
            {
                case "Barangay Clearance":
                    CreateForm<BarangayClearance>();
                    break;
                case "Business Clearance":
                    CreateForm<BussinessClearance>();
                    break;
                case "Death Certificate":
                    CreateForm<DeathCertificate>();
                    break;
                case "Building Permit":
                    CreateForm<BuildingPermit>();
                    break;
                case "Certificate of Appearance":
                    CreateForm<DeathCertificate>();
                    break;
                case "Certificate of Indigency":
                    CreateForm<DeathCertificate>();
                    break;
                case "Cert Dependent":
                    CreateForm<BarangayCertDependent>();
                    break;
                default:
                    break;
            }
        }
    }
}
