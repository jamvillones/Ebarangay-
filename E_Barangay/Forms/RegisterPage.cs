using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace E_Barangay.Forms
{
    public partial class RegisterPage : Form
    {
        List<Record> records = new List<Record>();
        List<Control> requiredControls = new List<Control>();
        public void SetId(string id)
        {
            IDField.Text = id;
            IDField.ReadOnly = id == string.Empty ? false : true;
        }
        public RegisterPage()
        {
            InitializeComponent();
            InitRequiredFields();
        }
        public void AcceptNewUser(object sender, string id)
        {
            IDField.Text = id;
        }
        void InitRequiredFields()
        {
            requiredControls.Add(FirstNameField);
            requiredControls.Add(MiddleNameField);
            requiredControls.Add(LastNameField);
            requiredControls.Add(BarangayField);
            requiredControls.Add(AreaOption);
            requiredControls.Add(ProvinceField);
            requiredControls.Add(MunicipalityField);
            requiredControls.Add(ContactField);
            requiredControls.Add(FatherField);
            requiredControls.Add(MotherField);
            requiredControls.Add(IDField);
        }
        //public void AcceptRecord(Record c)
        //{
        //    records.Add(c);
        //}
        void InitializeDropdown(string[] values, int startIndex, ref ComboBox comboBox)
        {
            for (int i = startIndex; i < values.Length; i++)
            {
                comboBox.Items.Add(values[i]);
            }
        }
        public void LoadValues()
        {
            using (var eBarangay = new EBarangayEntities())
            {
                IQueryable<string> names = from areas in eBarangay.Areas
                                           select areas.Name;
                InitializeDropdown(names.ToArray(), 1, ref AreaOption);
            }
            SexOption.SelectedIndex = CivilStatusOption.SelectedIndex = 0;
        }
        private void RegisterControl_Load(object sender, EventArgs e)
        {


        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            ///checking if valid for registration
            if (!CanSave())
            {
                ReddenRequiredFields();
                //MessageBox.Show("Cannot Save. Fill out required fields or the id is already taken!");
                return;
            }

            Citizen temp = new Citizen();
            temp.ID = IDField.Text == string.Empty ? Guid.NewGuid().ToString() : IDField.Text;

            temp.Name = FirstNameField.Text + " " + MiddleNameField.Text + " " + LastNameField.Text;
            temp.Gender = SexOption.Text;

            if (NumberField.Text == "")
            {
                temp.Address = AreaOption.Text + ", " +
                               BarangayField.Text + ", " +
                               MunicipalityField.Text + ", " +
                               ProvinceField.Text;
            }
            else
            {
                temp.Address = NumberField.Text + ", " + AreaOption.Text + ", " + BarangayField.Text + ", " + MunicipalityField.Text + ", " + ProvinceField.Text;
            }


            temp.Birthday = BdayPicker.Value;
            temp.ContactInfo = ContactField.Text;

            temp.FathersName = FatherField.Text;
            temp.MothersName = MotherField.Text;
            temp.CivilStatus = CivilStatusOption.Text;

            temp.SpouseName = SpouseField.Text == string.Empty ? null : SpouseField.Text;

            temp.Indigent = isIndigent.Checked;
            temp.PWD = IsPwd.Checked;
            temp.SeniorCitizen = IsSenior.Checked;
            temp.Student = IsStudent.Checked;
            temp.Picture = Class.ImageConverter.imageToByteArray(ImageBox.Image);

            temp.VoterID = VoterIDField.Text == string.Empty ? null : VoterIDField.Text;
            temp.PrecinctNumber = PrecinctNumField.Text == string.Empty ? null : PrecinctNumField.Text;

            temp.SSS = SSSField.Text == string.Empty ? null : SSSField.Text;
            temp.PagIbig = PIField.Text == string.Empty ? null : PIField.Text;
            temp.Philhealth = PHField.Text == string.Empty ? null : PHField.Text;

            using (var ent = new EBarangayEntities())
            {

                temp.Area = AreaOption.Items.Contains(AreaOption.Text) ? ent.Areas.FirstOrDefault(r => r.Name == AreaOption.Text) : ent.Areas.First();
                ent.Citizens.Add(temp);

                for (int i = 0; i < records.Count; i++)
                {
                    records[i].CitizenID = temp.ID;
                    ent.Records.Add(records[i]);
                }
                ent.SaveChanges();
                records.Clear();
            }
            MessageBox.Show("successfully saved!");
            ChangeNormalColors();
            this.ActiveControl = FirstNameField;
            CleanFields();

        }
        public bool FieldEmpty(TextBox t)
        {
            return t.Text == string.Empty || t.Text == "required";
        }
        bool CanSave()
        {
            using (var c = new EBarangayEntities())
            {
                if (c.Citizens.Find(IDField.Text) != null)
                {
                    MessageBox.Show("ID is already taken");
                    return false;
                }
            }
            foreach (var c in requiredControls)
            {

                if (c.Text == "")
                {
                    MessageBox.Show("Please fill out required fields");
                    return false;
                }

            }
            return true;
        }
        void ReddenRequiredFields()
        {
            foreach (var c in requiredControls)
            {
                c.BackColor = c.Text == "" ? Color.Pink : c.BackColor;
            }

        }
        void ChangeNormalColors()
        {
            foreach (var c in requiredControls)
                c.BackColor = Color.White;
        }
        void CleanFields()
        {

            IDField.Clear();
            FirstNameField.Clear();
            MiddleNameField.Clear();
            LastNameField.Clear();

            FatherField.Clear();
            MotherField.Clear();
            SpouseField.Clear();

            MunicipalityField.ResetText();
            SexOption.ResetText();
            CivilStatusOption.ResetText();
            MunicipalityField.ResetText();

            SexOption.ResetText();

            NumberField.Clear();
            AreaOption.ResetText();
            BarangayField.Clear();
            ProvinceField.Clear();
            ContactField.Clear();

            //Birthday.ResetText();

            RecordsTable.Rows.Clear();
            ImageBox.Image = null;
            VoterIDField.Clear();
            PrecinctNumField.Clear();
            SSSField.Clear();
            PIField.Clear();
            PHField.Clear();
            SSSField.Clear();
            IsPwd.Checked = isIndigent.Checked = IsSenior.Checked = false;

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            ChangeNormalColors();
            CleanFields();
        }

        private void CivilStatusOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CivilStatusOption.SelectedIndex == 0)
            {
                SpouseField.Enabled = false;
                return;
            }
            SpouseField.Enabled = true;
        }

        private void BdayPicker_ValueChanged(object sender, EventArgs e)
        {
            //var today = DateTime.Today;
            //var age = today.Year - BdayPicker.Value.Year;
            AgeField.Text = Class.DateTimeExtension.ToAge(BdayPicker.Value.Date).years.ToString(); ;
        }
        RecordForm record;
        private void button3_Click(object sender, EventArgs e)
        {
            if (record == null)
            {
                record = new RecordForm();
                record.FormClosed += Record_FormClosed;
                record.OnSave += Record_OnSave;
                //record.GetRef(this);
                record.Show();
                return;
            }
            record.BringToFront();
        }

        private void Record_OnSave(object sender, Record e)
        {
            records.Add(e);
            RecordsTable.Rows.Add(e.DateIssued, e.Name, e.Details);
            // throw new NotImplementedException();
        }

        private void Record_FormClosed(object sender, FormClosedEventArgs e)
        {
            record = null;
            // ShowRecords();
        }
        void ShowRecords()
        {
            RecordsTable.Rows.Clear();
            for (int i = 0; i < records.Count; i++)
            {
                RecordsTable.Rows.Add();
                RecordsTable.Rows[i].Cells[0].Value = records[i].DateIssued;
                RecordsTable.Rows[i].Cells[1].Value = records[i].Name;
                RecordsTable.Rows[i].Cells[2].Value = records[i].Details;
            }
        }
        CaptureImageForm captureForm;
        private void AddImage_Click(object sender, EventArgs e)
        {
            captureForm = new CaptureImageForm();
            this.Enabled = false;
            captureForm.OnSave += CaptureForm_OnSave;
            captureForm.FormClosed += CaptureForm_FormClosed;

            captureForm.Show();
        }

        private void CaptureForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
        }

        private void CaptureForm_OnSave(object sender, Image e)
        {
            this.Enabled = true;
            ImageBox.Image = e;

        }


        private void VoterCheckbox_CheckedChanged(object sender, EventArgs e)
        {

            VoterIDField.Enabled = PrecinctNumField.Enabled = VoterCheckbox.Checked ? true : false;

        }

        private void RegisterControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                foreach (var c in requiredControls)
                    c.Text = "test_dummy";
                IDField.Text = Guid.NewGuid().ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void AgeField_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
