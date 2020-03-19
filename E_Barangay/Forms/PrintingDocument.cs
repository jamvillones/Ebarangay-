using System;
using System.ComponentModel;
using System.Windows.Forms;
using E_Barangay.Documents;

namespace E_Barangay.Forms
{
    public partial class PrintingDocument : UserControl
    {
        Form form;

        string[] docNames = {
            "Barangay Clearance",
            "Business Clearance",
            "Death Certificate",
            "Building Permit",
            "Certificate of Appearance",
            "Certificate of Indigency",
            "Cert. Dependent",
            "Brgy Certificate for Burial",
            "Cert. Indigent Medical Assistance",
            "Brgy. Certificate for Death",
            "Brgy. Certification for Business",
            "Brgy. Certification for Financial Support",
            "Brgy. Clearance Akelco",
            "Cert. SSS Requirement",
            "Cert. of 4P's",
            "Brgy. Certification for Guardian",
            "Brgy. Certification for no Income",
            "Brgy. Certification for Residency",
            "Cert. Animal Bite",
            "Cert. SSS Pension",
            "Cert. for PRC",
            "Certification for Good Moral Character"
        };

        public PrintingDocument()
        {
            InitializeComponent();
        }

        private void PrintingDocument_Load(object sender, EventArgs e)
        {
            setDataList();
        }
        void setDataList()
        {
            DocumentList.Rows.Clear();

            foreach (var x in docNames)
            {
                DocumentList.Rows.Add("OPEN", x);
            }
            DocumentList.Sort(DocumentList.Columns[1], ListSortDirection.Ascending);
        }
        public event EventHandler<bool> OpeningForm;

        void CreateForm<T>() where T : Form, new()
        {
            if (form == null)
            {
                OpeningForm?.Invoke(this, true);
                form = new T();
                form.FormClosed += Form_FormClosed;
                form.Show();
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
                    CreateForm<CertificateAppearance>();
                    break;
                case "Certificate of Indigency":
                    CreateForm<CertificateOfIndigency>();
                    break;
                case "Cert. Dependent":
                    CreateForm<BrgyCertDependent>();
                    break;
                case "Brgy Certificate for Burial":
                    CreateForm<BrgyCertificationforBurial>();
                    break;
                case "Cert. Indigent Medical Assistance":
                    CreateForm<CertIndigentMedicalAssistance>();
                    break;
                case "Brgy. Certificate for Death":
                    CreateForm<BrgyCertForDeath>();
                    break;
                case "Brgy. Certification for Business":
                    CreateForm<BrgyCertificationforbusiness>();
                    break;
                case "Brgy. Certification for Financial Support":
                    CreateForm<BrgyCertforFinancialSupport>();
                    break;
                case "Brgy. Clearance Akelco":
                    CreateForm<BrgyClearance_Akelco>();
                    break;
                case "Cert. SSS Requirement":
                    CreateForm<CertSSSReq>();
                    break;
                case "Cert. of 4P's":
                    CreateForm<CertofP4s>();
                    break;
                case "Brgy. Certification for Guardian":
                    CreateForm<BrgyCertforGuardian>();
                    break;
                case "Brgy. Certification for no Income":
                    CreateForm<BrgyCertforNoIncome>();
                    break;
                case "Brgy. Certification for Residency":
                    CreateForm<BrgyCertforResidency>();
                    break;
                case "Cert. Animal Bite":
                    CreateForm<CertAnimalBite>();
                    break;
                case "Cert. SSS Pension":
                    CreateForm<SSSPension>();
                    break;
                case "Cert. for PRC":
                    CreateForm<CertforPRC>();
                    break;
                case "Certification for Good Moral Character":
                    CreateForm<CertificationForGoodMoral>();
                    break;
                default:
                    break;
            }
        }

        private void createCustBtn_Click(object sender, EventArgs e)
        {
            CreateForm<CustomCertification>();
        }
    }
}
