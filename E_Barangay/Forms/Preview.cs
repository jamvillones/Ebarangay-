using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using E_Barangay.Interface;
using System.IO;
using E_Barangay.Class;

namespace E_Barangay.Forms
{
    public partial class Preview : Form
    {

        Citizen target;
        public event EventHandler OnRecordDeleted;
        public Preview()
        {
            InitializeComponent();
        }
        private void Preview_Load(object sender, EventArgs e)
        {
            if (Class.UserManager.instance == null)
                return;
            User user = Class.UserManager.instance.currentUser;
            if (user == null)
                return;
            EditBtn.Enabled = user.canEdit ? true : false;
            DeleteBtn.Enabled = user.canDelete ? true : false;
        }
        public void AcceptDetails(Citizen c)
        {
            target = c;
            AssignValuesToText();
        }

        private void OkayBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// EditPage epage;
        // PasswordForm passwordForm;
        Class.PasswordToFormHandler<EditPage> passwordToFormHandler;
        private void EditBtn_Click(object sender, EventArgs e)
        {
            passwordToFormHandler = new Class.PasswordToFormHandler<EditPage>();
            EditPage ep = passwordToFormHandler.form;
            ep.AssignCitizen(target);
            this.Close();

        }

        string emptyField = string.Empty;
        void AssignValuesToText()
        {
            if (target == null)
            {
                MessageBox.Show("Citizen Instance not assigned");
                return;
            }
            IDTxt.Text = target.ID;
            NameTxt.Text = target.getNameWithSpace();
            AddressTxt.Text = target.Address;
            BdayTxt.Text = target.Birthday.ToShortDateString();
            SexTxt.Text = target.Gender;
            ContactTxt.Text = target.ContactInfo;

            CivilStatusTxt.Text = target.CivilStatus;

            MotherTxt.Text = target.MothersName;
            FatherTxt.Text = target.FathersName;

            SpouseTxt.Text = target.SpouseName ?? emptyField;
            VotersID.Text = target.VoterID ?? emptyField;
            PrecinctNumber.Text = target.PrecinctNumber ?? emptyField;

            SSS.Text = target.SSS ?? emptyField;
            PagIbig.Text = target.PagIbig ?? emptyField;
            Philhealth.Text = target.Philhealth ?? emptyField;

            Class.Date date = new Class.Date();
            Class.DateTimeExtension.ToAgeString(target.Birthday, ref date);

            AgeTxt.Text = target.getAGe().ToString();
            //AgeTxt.Text = Class.DateTimeExtension.ToAge(target.Birthday).years.ToString();
            IsIndigent.Checked = target.Indigent ? true : false;
            IsStudent.Checked = target.Student ? true : false;
            IsSenior.Checked = target.SeniorCitizen ? true : false;
            IsPwd.Checked = target.PWD ? true : false;

            RecordsTable.Rows.Clear();
            using (var ent = new EBarangayEntities())
            {
                var t = ent.Citizens.FirstOrDefault(r => r.ID == target.ID);
                ImageBox.Image = t.Picture == null ? Properties.Resources.image_50px : Class.ImageConverter.byteArrayToImage(t.Picture);

                if (string.IsNullOrEmpty(t.RefRecords))
                {
                    return;
                }
                var recs = t.RefRecords.Split(',');
                foreach (var ids in recs)
                {
                    var complaint = ent.Complaints.FirstOrDefault(x => x.ID == ids);
                    if (complaint != null)
                        RecordsTable.Rows.Add(complaint.ID, complaint.SettlementDate.Value.ToString("MMMM dd, yyyy"), complaint.Status);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            YesOrNoPrompt yesOrNo = new YesOrNoPrompt("Are you sure you want to delete this item?");
            yesOrNo.onBtnClick += YesOrNo_onBtnClick;
            yesOrNo.Show();
            this.Enabled = false;

        }

        private void YesOrNo_onBtnClick(object sender, bool e)
        {
            this.Enabled = true;
            Form f = (Form)sender;

            //this.Close();
            if (e)
            {
                using (var eb = new EBarangayEntities())
                {
                    var c = eb.Citizens.Find(IDTxt.Text);

                    //foreach (var rec in c.Records.ToArray())
                    //    eb.Records.Remove(rec);

                    eb.Citizens.Remove(c);

                    eb.SaveChanges();

                    f.Close();

                    MessageBox.Show("successfully deleted Entry with id(" + IDTxt.Text + ")");
                    OnRecordDeleted?.Invoke(this, new EventArgs());
                    this.Close();
                }
            }
            ///throw new NotImplementedException();
        }

        private void RecordsTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridView v = (DataGridView)sender;
            var x = v.Rows[e.RowIndex].Cells[0].Value.ToString();

            var view = new ComplaintViewForm(x);
            view.FormClosed += (ee, ss) => { this.Enabled = true; };
            this.Enabled = false;
            view.Show();
        }
    }
}
