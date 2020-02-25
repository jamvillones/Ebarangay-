using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using E_Barangay.Class;
using System.Threading;

namespace E_Barangay.Forms
{
    public partial class ComplaintControl : UserControl
    {
        public ComplaintControl()
        {
            InitializeComponent();
        }
        Record[] recs;
        private void ComplaintControl_Load(object sender, EventArgs e)
        {

        }
        public void LoadValues()
        {

            forToday();
        }
        void forToday()
        {
            using (var ent = new EBarangayEntities())
                recs = ent.Records.ToArray();

            dgvRecords.Rows.Clear();

            var today = recs.Where(x => x.SettlementDate.Value.Date == DateTime.Today);
            foreach (var x in today)
                dgvRecords.Rows.Add(x.ID, x.SettlementDate, x.DateHappened);

        }
        FileComplaintForm comp;
        private void addComplaintBtn_Click(object sender, EventArgs e)
        {
            if (comp == null)
            {
                comp = new FileComplaintForm();
                comp.FormClosed += (ss, ee) => { comp = null; };
                comp.ComplaintAdded += Comp_ComplaintAdded;
                comp.Show();
                return;
            }
            comp.BringToFront();
        }

        private void Comp_ComplaintAdded(object sender, EventArgs e)
        {
            forToday();
        }

        private void dgvRecords_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            DataGridView v = (DataGridView)sender;
            var x = v.Rows[e.RowIndex].Cells[0].Value.ToString();

            var view = new RecordView(x);
            view.FormClosed += (ee, ss) => { this.Enabled = true; };
            this.Enabled = false;
            view.Show();
        }
    }
}
