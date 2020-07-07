using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using E_Barangay.Class;

namespace E_Barangay.Forms
{
    public partial class AdvancedSearchForm : Form
    {
        public AdvancedSearchForm()
        {
            InitializeComponent();
        }

        private void AdvancedSearchForm_Load(object sender, EventArgs e)
        {
            using (var eb = new EBarangayEntities())
            {
                var areas = eb.Areas.ToArray();
                foreach (var a in areas)
                    areaOptions.Items.Add(a.Name);

            }
            var gender = new string[] { "Male", "Female" };
            foreach (var a in gender)
                sexOption.Items.Add(a);

            var cStatus = new string[] { "Single", "Married", "Separated", "Widow" };
            foreach (var a in cStatus)
                civilStatusOption.Items.Add(a);

            using (var eb = new EBarangayEntities())
                PopulateTable(eb.Citizens.ToArray());
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

            using (var eb = new EBarangayEntities())
            {
                //citizen = eb.Citizens.ToArray();
                var filtered = eb.Citizens.ToArray().AsQueryable();

                if (areaOptions.Text != string.Empty)
                {
                    var area = eb.Areas.FirstOrDefault(x => x.Name == areaOptions.Text);
                    filtered = area.Citizens.AsQueryable();
                }

                if (sexOption.Text != string.Empty)
                    filtered = filtered.Where(x => x.Gender == sexOption.Text);

                if (civilStatusOption.Text != string.Empty)
                    filtered = filtered.Where(x => x.CivilStatus == civilStatusOption.Text);

                if (isPwd.Checked)
                    filtered = filtered.Where(x => x.PWD);
                if (isStudent.Checked)
                    filtered = filtered.Where(x => x.Student);
                if (isIndigent.Checked)
                    filtered = filtered.Where(x => x.Indigent);
                if (isSeniorCitizen.Checked)
                    filtered = filtered.Where(x => x.SeniorCitizen);

                if (isVoter.Checked)
                    filtered = filtered.Where(x => !string.IsNullOrEmpty(x.VoterID));

                PopulateTable(filtered.ToArray());
            }
        }

        void PopulateTable(Citizen[] c)
        {
            DataTable.Rows.Clear();
            foreach (var x in c)
            {
                DataTable.Rows.Add(x.ID, x.getNameWithSpace());
            }
        }

        private void DataTable_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            OpenPreview(getCitizenByIndex);
        }
        Preview preview;
        void OpenPreview(Citizen citizen)
        {
            if (citizen == null)
            {
                MessageBox.Show("User not found.");
                return;
            }
            if (preview == null)
            {
                preview = new Preview();
                preview.AcceptDetails(citizen);
                preview.FormClosing += (a, b) => { preview = null; };
                preview.OnRecordDeleted += (a, b) => { searchBtn.PerformClick(); };
                preview.Show();
            }
            else
            {
                preview.AcceptDetails(citizen);
                preview.BringToFront();
            }
        }
        Citizen getCitizenByIndex
        {
            get
            {
                var c = new Citizen();
                int selectedrowindex = DataTable.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = DataTable.Rows[selectedrowindex];
                string Value = Convert.ToString(selectedRow.Cells[0].Value);
                using (var m = new EBarangayEntities())
                {
                    c = m.Citizens.FirstOrDefault(r => r.ID == Value);
                    return c;
                }


            }
        }
    }
}
