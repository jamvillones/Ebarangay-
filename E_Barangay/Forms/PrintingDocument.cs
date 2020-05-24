using System;
using System.Linq.Expressions;
using System.Linq;
using System.ComponentModel;
using System.Windows.Forms;
using E_Barangay.Documents;

namespace E_Barangay.Forms
{
    public partial class PrintingDocument : UserControl
    {
        Form form;

        string[] docNames = {
            "Brgy. Clearance",
            "Business Clearance",
            "Building Permit",
            "Certificate of Appearance",
            "Cert. Dependent",
            "Brgy. Certification for Electric Connection at Akelco",
            "Brgy. Certification for Death",
            "Brgy. Certification of Employment",
            "Brgy. Certification of Indigency",
            "Brgy. Certification of Indigency for Financial Support",
            "Brgy. Certification of Indigency for Educational Assistance",
            "Brgy. Certification of Indigency for Medical Assistance",
            "Brgy. Certification of Indigency for Burial",
            "Brgy. Certification of Indigency for 4P's",
            "Cert. SSS Requirement",
            "Brgy. Certification for Guardian",
            "Brgy. Certification for No Income",
            "Brgy. Certification for Residency",
            "Cert. Animal Bite",
            "Cert. SSS Pension",
            "Cert. for PRC",
            "Certification for Good Moral Character",
            "Cert. Transfer for Business Name",
            "Brgy. Clearance  - Requirements For",
            "Brgy. Certification for Business",
            "Brgy. Certification for PAO"
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
            var d = docNames.OrderBy(x => x);
            foreach (var x in d)
                DocumentList.Rows.Add("OPEN", x);
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
                MessageBox.Show("A form is already open");

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
                case "Cert. Transfer for Business Name":
                    CreateForm<CertTransferofBusinessName>();
                    break;
                case "Brgy. Clearance":
                    CreateForm<BarangayClearance>();
                    break;
                case "Business Clearance":
                    CreateForm<BussinessClearance>();
                    break;
                case "Building Permit":
                    CreateForm<BuildingPermit>();
                    break;
                case "Certificate of Appearance":
                    CreateForm<CertificateAppearance>();
                    break;
                case "Brgy. Certification of Indigency":
                    CreateForm<CertificateOfIndigency>();
                    break;
                case "Cert. Dependent":
                    CreateForm<BrgyCertDependent>();
                    break;
                case "Brgy. Certification of Indigency for Burial":
                    CreateForm<BrgyCertofIndigencyForBurial>();
                    break;
                case "Brgy. Certification of Indigency for Medical Assistance":
                    CreateForm<CertIndigentMedicalAssistance>();
                    break;
                case "Brgy. Certification for Death":
                    CreateForm<BrgyCertForDeath>();
                    break;
                case "Brgy. Certification of Employment":
                    CreateForm<BrgyCertofEmployment>();
                    break;
                case "Brgy. Certification of Indigency for Financial Support":
                    CreateForm<BrgyCertforFinancialSupport>();
                    break;
                case "Brgy. Certification for Electric Connection at Akelco":
                    CreateForm<BrgyCertforElectricConnectionAkelco>();
                    break;
                case "Cert. SSS Requirement":
                    CreateForm<CertSSSReq>();
                    break;
                case "Brgy. Certification of Indigency for 4P's":
                    CreateForm<CertofP4s>();
                    break;
                case "Brgy. Certification for Guardian":
                    CreateForm<BrgyCertforGuardian>();
                    break;
                case "Brgy. Certification for No Income":
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
                case "Brgy. Certification of Indigency for Educational Assistance":
                    CreateForm<CertForEducationalAssistance>();
                    break;
                case "Brgy. Clearance  - Requirements For":
                    CreateForm<BrgyClearanceRequirementsFor>();
                    break;
                case "Brgy. Certification for Business":
                    CreateForm<BrgyCertforBusiness>();
                    break;
                case "Brgy. Certification for PAO":
                    CreateForm<BarangayCertPao>();
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
