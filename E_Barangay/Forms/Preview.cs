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
    public partial class Preview : Form, Interface.IRecordAcceptor
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

        EditPage epage;
        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (epage == null)
            {
                epage = new EditPage();
                epage.AssignCitizen(target);
                epage.Show();
            }
            this.Close();
        }

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

            SpouseTxt.Text = string.IsNullOrEmpty(target.SpouseName) ? "NONE" : target.SpouseName;
            VotersID.Text = target.VoterID;
            PrecinctNumber.Text = target.PrecinctNumber;

            SSS.Text = target.SSS;
            PagIbig.Text = target.PagIbig;
            Philhealth.Text = target.Philhealth;
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
                    RecordsTable.Rows.Add();
                    RecordsTable.Rows[i].Cells[0].Value = rec[i].DateIssued;
                    RecordsTable.Rows[i].Cells[1].Value = rec[i].Name;
                    RecordsTable.Rows[i].Cells[2].Value = rec[i].Details;
                }
            }

        }

        RecordForm recform;
        private void AddRecordBtn_Click(object sender, EventArgs e)
        {
            if (recform == null)
            {
                recform = new RecordForm();
                recform.FormClosed += Recform_FormClosed;
                recform.GetRef(this);
                recform.Show();
                return;
            }
            recform.BringToFront();
        }

        private void Recform_FormClosed(object sender, FormClosedEventArgs e)
        {
            recform.FormClosed -= Recform_FormClosed;
            recform = null;
        }


        public void AcceptRecord(Record r)
        {

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
            if (e)
            {
                using (var eb = new EBarangayEntities())
                {
                    var c = eb.Citizens.Find(IDTxt.Text);
                    eb.Citizens.Remove(c);
                    eb.SaveChanges();
                    MessageBox.Show("successfully deleted record with id(" + IDTxt.Text + ")");
                    OnRecordDeleted?.Invoke(this, new EventArgs());
                    this.Close();
                }
            }
            ///throw new NotImplementedException();
        }

    }
}
