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
            User user = Class.UserManager.instance.currentUser;
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
            //if (epage == null)
            //{
            //    epage = new EditPage();
            //    epage.AssignCitizen(target);
            //    epage.Show();
            //}
            passwordToFormHandler = new Class.PasswordToFormHandler<EditPage>();
            EditPage ep = passwordToFormHandler.form;
            ep.AssignCitizen(target);
            this.Close();
            //if (passwordForm == null)
            //{
            //    passwordForm = new PasswordForm(Class.UserManager.instance.currentUser.Username);
            //    passwordForm.OnCorrectPassword += PasswordForm_OnCorrectPassword;
            //    passwordForm.FormClosed += PasswordForm_FormClosed;
            //    this.FormClosing += passwordForm.CallerCloseCallback;
            //    passwordForm.Show();
            //}
            //else
            //{
            //    passwordForm.BringToFront();
            //}
        }

        //private void PasswordForm_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    // throw new NotImplementedException();
        //    this.FormClosing -= passwordForm.CallerCloseCallback;
        //    passwordForm = null;
        //}

        //private void PasswordForm_OnCorrectPassword(object sender, bool e)
        //{
        //    if (!e)
        //        return;
        //    if (epage == null)
        //    {
        //        epage = new EditPage();
        //        epage.AssignCitizen(target);
        //        epage.Show();
        //    }
        //    this.Close();
        //}
        string emptyField = string.Empty;
        void AssignValuesToText()
        {
            if (target == null)
            {
                MessageBox.Show("Citizen Instance not assigned");
                return;
            }
            IDTxt.Text = target.ID;
            NameTxt.Text = target.Name;
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
            //if (string.IsNullOrEmpty(target.SpouseName))
            //    SpouseTxt.Text = "NONE";
            //else
            //    SpouseTxt.Text = target.SpouseName;

            Class.Date date = new Class.Date();
            Class.DateTimeExtension.ToAgeString(target.Birthday, ref date);
            // AgeTxt.Text = (DateTime.Today.Year - target.Birthday.Year).ToString();
            AgeTxt.Text = date.years.ToString();
            IsIndigent.Checked = target.Indigent ? true : false;
            IsStudent.Checked = target.Student ? true : false;
            IsSenior.Checked = target.SeniorCitizen ? true : false;
            IsPwd.Checked = target.PWD ? true : false;

            RecordsTable.Rows.Clear();
            using (var con = new EBarangayEntities())
            {
                var t = con.Citizens.FirstOrDefault(r => r.ID == target.ID);
                ImageBox.Image = t.Picture == null ? Properties.Resources.image_50px : Class.ImageConverter.byteArrayToImage(t.Picture);
                //if (t.Picture != null)
                //    ImageBox.Image = Class.ImageConverter.byteArrayToImage(t.Picture);
                //else
                //    image

                List<Record> rec = t.Records.ToList<Record>();
                for (int i = 0; i < rec.Count; i++)
                {
                    RecordsTable.Rows.Add(rec[i].DateHappened,rec[i].Name,rec[i].Status);
                    //RecordsTable.Rows[i].Cells[0].Value = rec[i].DateIssued;
                    //RecordsTable.Rows[i].Cells[1].Value = rec[i].Name;
                    //RecordsTable.Rows[i].Cells[2].Value = rec[i].Details;
                }
            }

        }

        //RecordForm recform;
        //private void AddRecordBtn_Click(object sender, EventArgs e)
        //{
        //    if (recform == null)
        //    {
        //        recform = new RecordForm();
        //        recform.FormClosed += Recform_FormClosed;
        //        //recform.GetRef(this);
        //        recform.Show();
        //        return;
        //    }
        //    recform.BringToFront();
        //}

        //private void Recform_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    recform.FormClosed -= Recform_FormClosed;
        //    recform = null;
        //}


        //public void AcceptRecord(Record r)
        //{

        //}

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

                    foreach (var rec in c.Records.ToArray())
                        eb.Records.Remove(rec);

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
    }
}
