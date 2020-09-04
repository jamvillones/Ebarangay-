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
        Complaint[] recs;

        public void InitButtons()
        {
            User user = UserManager.instance.currentUser;
            if (user != null)
            {
                addComplaintBtn.Enabled = user.Comp_Create ? true : false;
            }
        }
        public void LoadValues()
        {
            using (var ent = new EBarangayEntities())
                recs = ent.Complaints.ToArray();

            fillDgv(recs);
            //forToday();
        }
        void settled()
        {
            dgvRecords.Rows.Clear();
            var today = recs.Where(x => x.Status == ComplaintStatus.Settled.ToString());
            fillDgv(today.ToArray());
        }
        void pending()
        {
            dgvRecords.Rows.Clear();
            var today = recs.Where(x => x.Status == ComplaintStatus.Pending.ToString());
            fillDgv(today.ToArray());
        }
        void overDue()
        {
            dgvRecords.Rows.Clear();
            var today = recs.Where(x => x.SettlementDate.Value.Date < DateTime.Today && x.Status == ComplaintStatus.Pending.ToString());
            fillDgv(today.ToArray());
        }
        void forToday()
        {
            dgvRecords.Rows.Clear();
            var today = recs.Where(x => x.SettlementDate.Value.Date == DateTime.Today);
            fillDgv(today.ToArray());
        }
        void fillDgv(Complaint[] recs)
        {
            dgvRecords.Rows.Clear();
            foreach (var x in recs)
                dgvRecords.Rows.Add(x.ID, x.Status, x.SettlementDate.Value.ToString("MMMM dd, yyyy hh:mm tt"), x.DateHappened.Value.ToString("MMMM dd, yyyy hh:mm tt"));
        }

        private void addComplaintBtn_Click(object sender, EventArgs e)
        {

            using (var comp = new FileComplaintForm())
            {
                comp.ComplaintAdded += Comp_ComplaintAdded;
                comp.ShowDialog();
            }
        }

        private void Comp_ComplaintAdded(object sender, EventArgs e)
        {
            LoadValues();
            forTodayBtn.PerformClick();
        }

        private void dgvRecords_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            DataGridView v = (DataGridView)sender;
            var x = (int)(v.Rows[e.RowIndex].Cells[0].Value);

            using (var view = new ComplaintViewForm(x))
            {
                view.OnComplaintChanges += View_OnMarkedSettled;
                view.ShowDialog();
            }
        }

        private void View_OnMarkedSettled(object sender, EventArgs e)
        {
            LoadValues();
        }

        void setMarker(Button b)
        {
            Marker.Visible = true;
            Marker.Left = b.Left;
            Marker.Width = b.Width;
        }
        private void forTodayBtn_Click(object sender, EventArgs e)
        {
            setMarker((Button)sender);
            forToday();
        }

        private void overdueBtn_Click(object sender, EventArgs e)
        {
            setMarker((Button)sender);
            overDue();
        }

        private void pendingBtn_Click(object sender, EventArgs e)
        {
            setMarker((Button)sender);
            pending();
        }

        private void settledBtn_Click(object sender, EventArgs e)
        {
            setMarker((Button)sender);
            settled();
        }

        private void allBtn_Click(object sender, EventArgs e)
        {
            setMarker((Button)sender);
            LoadValues();
        }
    }
}
