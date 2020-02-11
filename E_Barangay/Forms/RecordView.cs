using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Barangay.Forms
{
    public partial class RecordView : Form
    {
        Record currRec;
        public RecordView()
        {
            InitializeComponent();
        }
        public RecordView(Record rec)
        {
            InitializeComponent();
            using (var eb = new EBarangayEntities())
            {
                currRec = eb.Records.Find(rec.ID);
                initializeFields();
            }

        }
        void initializeFields()
        {
            Person.Text = currRec.Citizen.Name;
            Status.Text = currRec.Status;
            Status.ForeColor = currRec.Status == "Pending" ? Color.Red : Color.Green;
            TitleField.Text = currRec.Name;
            locationTxt.Text = currRec.Location;

            DetailsField.Text = currRec.Details;

            During.Text = currRec.DateHappened.Value.ToString("MMMM dd, yyyy hh:mm tt");
            RecordedOn.Text = currRec.DateIssued.Value.ToString("MMMM dd, yyyy hh:mm tt");
            settleSched.Text = currRec.SettlementDate.Value.ToString("MMMM dd, yyyy hh:mm tt");

        }

        private void RecordView_Load(object sender, EventArgs e)
        {

        }

        private void DoneBtn_Click(object sender, EventArgs e)
        {
            var yesorno = new YesOrNoPrompt("Are you sure you want to mark this record as settled?");
            yesorno.onBtnClick += (se, ee) =>
             {
                 this.Enabled = true;
                 if (ee)
                 {
                     markAsDone();
                     Status.Text = "Settled";
                     Status.ForeColor = Color.Green;
                     DoneBtn.Enabled = false;
                 }
             };
            this.Enabled = false;
            yesorno.Show();

        }
        void markAsDone()
        {
            using (var eb = new EBarangayEntities())
            {
                var rec = eb.Records.FirstOrDefault(r => r.ID == currRec.ID);
                if (rec == null)
                {
                    MessageBox.Show("error in changing");
                    return;
                }
                rec.Status = "Settled";
                eb.SaveChanges();

            }
        }
    }
}
