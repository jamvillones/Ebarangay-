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
using E_Barangay.Class;

namespace E_Barangay.Forms
{
    public partial class RegisterPage : Form
    {
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

            foreach (var i in this.GetContainedControls<TextBox>())
                i.Validated += Helper.TextBoxTrimSpaces;
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
            requiredControls.Add(AreaOption);
            requiredControls.Add(ContactField);
            requiredControls.Add(FatherField);
            requiredControls.Add(MotherField);
            requiredControls.Add(IDField);
        }

        void InitializeDropdown(string[] values, int startIndex, ref ComboBox comboBox)
        {
            for (int i = startIndex; i < values.Length; i++)
            {
                comboBox.Items.Add(values[i]);
                comboBox.AutoCompleteCustomSource.Add(values[i]);
            }
        }

        public void LoadValues()
        {
            using (var ent = new EBarangayEntities())
            {
                var names = ent.Areas.Select(x => x.Name);
                InitializeDropdown(names.ToArray(), 1, ref AreaOption);
            }
            SexOption.SelectedIndex = CivilStatusOption.SelectedIndex = 0;
        }

        void save()
        {
            ///checking if valid for registration
            if (!CanSave())
            {
                ReddenRequiredFields();
                return;
            }

            Citizen temp = new Citizen();
            temp.ID = IDField.Text == string.Empty ? Guid.NewGuid().ToString() : IDField.Text;

            temp.FirstName = FirstNameField.Text.Trim(' ');
            temp.MiddleName = MiddleNameField.Text.Trim(' ');
            temp.LastName = LastNameField.Text.Trim(' ');

            temp.Gender = SexOption.Text;

            if (NumberField.Text == "")
            {
                temp.Address = AreaOption.Text + ", " +
                               BarangayField.Text + ", " +
                               MunicipalityField.Text + ", " +
                               ProvinceField.Text;
            }
            else
                temp.Address = NumberField.Text + ", " + AreaOption.Text + ", " + BarangayField.Text + ", " + MunicipalityField.Text + ", " + ProvinceField.Text;


            temp.Birthday = dtBday.Value;
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
                ent.SaveChanges();
            }
            MessageBox.Show("successfully saved!");
            ChangeNormalColors();
            this.ActiveControl = FirstNameField;
            CleanFields();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            var yesorno = new YesOrNoPrompt("Are you sure you want to save?");
            yesorno.onBtnClick += Yesorno_onBtnClick;
            yesorno.FormClosed += (ss, ee) => { Enabled = true; };
            yesorno.Show();
            Enabled = false;
        }

        private void Yesorno_onBtnClick(object sender, bool e)
        {
            if (e)
                save();
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
            extField.Clear();
            IDField.Clear();
            FirstNameField.Clear();
            MiddleNameField.Clear();
            LastNameField.Clear();

            FatherField.Clear();
            MotherField.Clear();
            SpouseField.Clear();

            SexOption.ResetText();
            CivilStatusOption.ResetText();
            SexOption.ResetText();

            NumberField.Clear();
            AreaOption.ResetText();
            ContactField.Clear();

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
            AgeField.Text = Class.DateTimeExtension.ToAge(dtBday.Value.Date).years.ToString(); ;
        }
        //RecordForm record;
        //private void button3_Click(object sender, EventArgs e)
        //{
        //    if (record == null)
        //    {
        //        record = new RecordForm();
        //        record.FormClosed += Record_FormClosed;
        //        record.OnSave += Record_OnSave;
        //        //record.GetRef(this);
        //        record.Show();
        //        return;
        //    }
        //    record.BringToFront();
        //}

        //private void Record_OnSave(object sender, Record e)
        //{
        //    //records.Add(e);
        //    //RecordsTable.Rows.Add(e.DateIssued, e.Name, e.Details);
        //    //// throw new NotImplementedException();
        //}

        //private void Record_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    record = null;
        //    // ShowRecords();
        //}
        //void ShowRecords()
        //{
        //    //RecordsTable.Rows.Clear();
        //    //for (int i = 0; i < records.Count; i++)
        //    //{
        //    //    RecordsTable.Rows.Add();
        //    //    RecordsTable.Rows[i].Cells[0].Value = records[i].DateIssued;
        //    //    RecordsTable.Rows[i].Cells[1].Value = records[i].Name;
        //    //    RecordsTable.Rows[i].Cells[2].Value = records[i].Details;
        //    //}
        //}
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
                IDField.Text = IDField.Text.NonBlankValueOf(Guid.NewGuid().ToString());

                FirstNameField.Text = FirstNameField.Text.NonBlankValueOf("Test");
                MiddleNameField.Text = MiddleNameField.Text.NonBlankValueOf("Test");
                LastNameField.Text = LastNameField.Text.NonBlankValueOf("Test");

                Random rnd = new Random();

                NumberField.Text = NumberField.Text.NonBlankValueOf("0000");
                AreaOption.SelectedIndex = rnd.Next(0, AreaOption.Items.Count);

                ContactField.Text = ContactField.Text.NonBlankValueOf("00000000000");
                MotherField.Text = MotherField.Text.NonBlankValueOf("Blank");
                FatherField.Text = FatherField.Text.NonBlankValueOf("Blank");

                SexOption.SelectedIndex = rnd.Next(0, SexOption.Items.Count);
            }
        }
    }
}
