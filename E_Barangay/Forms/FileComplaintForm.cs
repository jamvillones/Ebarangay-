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
    public enum ComplaintStatus { Pending, LupongTagapamayapa, Settled }
    public partial class FileComplaintForm : Form
    {
        public event EventHandler ComplaintAdded;
        public FileComplaintForm()
        {
            InitializeComponent();
        }

        private void FileComplaintForm_Load(object sender, EventArgs e)
        {
            //wordCounter.Text = "0/" + narrativeField.MaxLength;
            using (var ent = new EBarangayEntities())
            {
                citizenNames = ent.Citizens.Select(x => x.FirstName + " " + x.MiddleName + " " + x.LastName + (string.IsNullOrEmpty(x.Extension) ? "" : " " + x.Extension)).ToArray();
            }
        }

        private void dataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView view = (DataGridView)sender;
            object value = view.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

            if (value == null || string.IsNullOrEmpty(value.ToString()))
            {
                //view.Rows[e.RowIndex].Cells[1].Value = false;
                return;
            }
            //string name =value.ToString();
            var helper = new NameHelper(value.ToString());
            using (var ent = new EBarangayEntities())
            {
                var citizen = ent.Citizens.FirstOrDefault(x => (x.FirstName + " " + x.MiddleName + " " + x.LastName) == value.ToString());
                //var citizen = ent.Citizens.FirstOrDefault(x => CitizenExtensions.getName(x) == value.ToString());
                //var citizen = ent.Citizens.Where(x => x.getName() == value.ToString()).First();

                if (citizen != null)
                {
                    view.Rows[e.RowIndex].Cells[1].Value = true;
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!canSave())
                return;

            YesOrNoPrompt yesOrNo = new YesOrNoPrompt("Are you sure you want to save a complaint?");
            yesOrNo.onBtnClick += SaveRecord;
            yesOrNo.FormClosed += (ss, eee) => { Enabled = true; };
            yesOrNo.Show();
            this.Enabled = false;

        }
        bool canSave()
        {
            using (var ent = new EBarangayEntities())
            {
                if (ent.Complaints.Find(controlNumberField.Text) != null)
                {
                    MessageBox.Show("Control Number already taken.");
                    return false;
                }
            }
            if (dgvComplainants.RowCount <= 1 || dgvRespondents.RowCount <= 1 || string.IsNullOrEmpty(locationField.Text) || string.IsNullOrEmpty(narrativeField.Text))
            {
                MessageBox.Show("Location, Complainants, Respondents, and Narrative cannot be empty");
                return false;
            }
            return true;
        }
        private void SaveRecord(object sender, bool e)
        {
            if (!e)
                return;


            var rec = new Complaint();

            rec.ID = string.IsNullOrEmpty(controlNumberField.Text) ? Guid.NewGuid().ToString() : controlNumberField.Text;
            rec.Location = locationField.Text.TrimStart(' ').TrimEnd(' ');
            rec.DateHappened = dtIncident.Value;
            rec.DateIssued = DateTime.Now;
            rec.SettlementDate = dtSettlement.Value;
            rec.Narrative = narrativeField.Text;
            rec.Status = ComplaintStatus.Pending.ToString();

            /// saving names in comps and resps
            for (int i = 0; i < dgvComplainants.RowCount; i++)
            {
                if (dgvComplainants.Rows[i].Cells[0].Value != null)
                {
                    string name = dgvComplainants.Rows[i].Cells[0].Value.ToString().Trim(' ');
                    if (!string.IsNullOrEmpty(name))
                        rec.CompNames += dgvComplainants.Rows[i].Cells[0].Value.ToString() + (i == dgvComplainants.RowCount - 2 ? "" : ",");
                }
            }

            for (int i = 0; i < dgvRespondents.RowCount; i++)
            {
                if (dgvRespondents.Rows[i].Cells[0].Value != null)
                {
                    string name = dgvRespondents.Rows[i].Cells[0].Value.ToString().Trim(' ');
                    if (!string.IsNullOrEmpty(name))
                        rec.RespNames += dgvRespondents.Rows[i].Cells[0].Value.ToString() + (i == dgvRespondents.RowCount - 2 ? "" : ",");
                }
            }
            ///end if

            connectComplaintToCitizen(rec.ID, dgvComplainants);
            connectComplaintToCitizen(rec.ID, dgvRespondents);
            using (var ent = new EBarangayEntities())
            {
                ent.Complaints.Add(rec);
                ent.SaveChanges();
            }
            ComplaintAdded?.Invoke(this, new EventArgs());
            Cleanup();
        }

        void connectComplaintToCitizen(string controlNumber, DataGridView dgv)
        {
            using (var ent = new EBarangayEntities())
            {
                for (int i = 0; i < dgv.RowCount; i++)
                {
                    if (dgv.Rows[i].Cells[0].Value != null)
                    {
                        string name = dgv.Rows[i].Cells[0].Value.ToString();
                        Citizen c = ent.Citizens.FirstOrDefault(x => x.FirstName == name);
                        if (c != null)
                            c.RefRecords += (string.IsNullOrEmpty(c.RefRecords)) ? controlNumber : "," + controlNumber;
                    }
                }
                ent.SaveChanges();
            }
        }

        /// <summary>
        /// resets fields to its original state
        /// </summary>
        void Cleanup()
        {
            dgvComplainants.Rows.Clear();
            dgvRespondents.Rows.Clear();
            locationField.Clear();
            narrativeField.Clear();
            controlNumberField.Clear();
        }

        private void narrativeField_TextChanged(object sender, EventArgs e)
        {
            wordCounter.Text = narrativeField.Text.Length + "/" + narrativeField.MaxLength;
        }


        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            object val = dgv.Rows[e.RowIndex].Cells[0].Value;
            if (val == null || string.IsNullOrEmpty(val.ToString()))
                return;
            Citizen citizen = null;
            var helper = new NameHelper(val.ToString());
            using (var ent = new EBarangayEntities())
            {
                citizen = ent.Citizens.FirstOrDefault(x => x.FirstName == helper.First &&
                                                             x.MiddleName == helper.Middle &&
                                                             x.LastName == helper.Last &&
                                                             x.Extension == helper.Extension);
            }
            if (citizen == null)
            {
                MessageBox.Show("Person not registered.");
                return;
            }

            Preview prev = new Preview();
            prev.AcceptDetails(citizen);
            prev.FormClosed += (ss, ee) => { Enabled = true; };
            Enabled = false;
            prev.Show();

        }

        private void controlNumberField_TextChanged(object sender, EventArgs e)
        {

        }
        string[] citizenNames;
        private void dgv_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (dgv.CurrentCell.ColumnIndex == 0)
            {
                TextBox a = e.Control as TextBox;
                if (a != null)
                {

                    a.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    a.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    AutoCompleteStringCollection sc = new AutoCompleteStringCollection();
                    sc.AddRange(citizenNames);
                    //foreach (var i in citizenNames)
                    //    sc.Add(i.Replace(',', ' '));
                    a.AutoCompleteCustomSource = sc;
                }
            }
        }
    }
}
