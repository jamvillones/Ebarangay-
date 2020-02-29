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
    public partial class ComplaintViewForm : Form
    {
        Complaint currRec;
        public ComplaintViewForm()
        {
            InitializeComponent();
        }
        public ComplaintViewForm(string id)
        {
            InitializeComponent();
            using (var ent = new EBarangayEntities())
            {
                currRec = ent.Complaints.FirstOrDefault(x=>x.ID == id);
                initializeFields();
            }

        }
        void initializeFields()
        {
            // Person.Text = currRec.Citizen.Name;
            controlNumberField.Text = currRec.ID;
            Status.Text = currRec.Status;
            Status.ForeColor = currRec.Status == "Pending" ? Color.Red : Color.Green;
            locationTxt.Text = currRec.Location;
            narrativeField.Text = currRec.Narrative;
            //TitleField.Text = currRec.Name;
            //DetailsField.Text = currRec.Details;

            During.Text = currRec.DateHappened.Value.ToString("MMMM dd, yyyy hh:mm tt");
            RecordedOn.Text = currRec.DateIssued.Value.ToString("MMMM dd, yyyy hh:mm tt");
            settleSched.Text = currRec.SettlementDate.Value.ToString("MMMM dd, yyyy hh:mm tt");

            var compNames = currRec.CompNames.Split(',');
            using (var ent = new EBarangayEntities())
            {
                foreach (var c in compNames)
                {
                   var citizen = ent.Citizens.FirstOrDefault(x => x.ID == c).getNameWithSpace();
                    lvComplainants.Items.Add((citizen?? c));
                }
                    
            }

            var respNames = currRec.RespNames.Split(',');
            using (var ent = new EBarangayEntities())
            {
                foreach (var c in respNames)
                {
                    var citizen = ent.Citizens.FirstOrDefault(x => x.ID == c).getNameWithSpace();
                    lvRespondents.Items.Add((citizen ?? c));
                }

            }
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
                var rec = eb.Complaints.FirstOrDefault(r => r.ID == currRec.ID);
                if (rec == null)
                {
                    MessageBox.Show("error in changing");
                    return;
                }
                rec.Status = "Settled";
                eb.SaveChanges();

            }
        }

        private void controlNumberField_TextChanged(object sender, EventArgs e)
        {

        }

        private void locationTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void RecordedOn_TextChanged(object sender, EventArgs e)
        {

        }

        private void During_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
