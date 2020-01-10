﻿using System;
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
    public partial class RegisterPage : Form, Interface.IRecordAcceptor, Interface.IImageAcceptor, Interface.IAccept
    {
        List<Record> records = new List<Record>();
        List<Control> requiredControls = new List<Control>();
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
        public void AcceptRecord(Record c)
        {
            records.Add(c);
        }
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
            ResidenceTypeOption.SelectedIndex = SexOption.SelectedIndex = CivilStatusOption.SelectedIndex = 0;
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
                MessageBox.Show("Cannot Save. Fill out required fields or the id is already taken!");
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
            temp.SpouseName = SpouseField.Text;

            temp.Indigent = isIndigent.Checked;
            temp.PWD = IsPwd.Checked;
            temp.SeniorCitizen = IsSenior.Checked;
            temp.Student = IsStudent.Checked;
            temp.Picture = imageToByteArray(ImageBox.Image);

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
            using(var c = new EBarangayEntities())
            {
                if (c.Citizens.Find(IDField.Text) != null)
                    return false;
            }
            foreach (var c in requiredControls)
            {
                if (c.Text == "") return false;
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

            Birthday.ResetText();

            RecordsTable.Rows.Clear();
            ImageBox.Image = null;

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
            var today = DateTime.Today;
            var age = today.Year - BdayPicker.Value.Year;
            AgeField.Text = age.ToString();
        }
        RecordForm record;
        private void button3_Click(object sender, EventArgs e)
        {
            if (record == null)
            {
                record = new RecordForm();
                record.FormClosed += Record_FormClosed;
                record.GetRef(this);
                record.Show();
                return;
            }
            record.BringToFront();
        }

        private void Record_FormClosed(object sender, FormClosedEventArgs e)
        {
            record = null;
            ShowRecords();
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
            captureForm.GetAcceptor(this);
            captureForm.Show();
        }

        public void AcceptImage(Image image)
        {
            ImageBox.Image = image;
        }
        public void SetImage(Image image)
        {

        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            if (imageIn == null)
                return null;
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        private void VoterCheckbox_CheckedChanged(object sender, EventArgs e)
        {

            VoterIDField.Enabled = PrecinctNumField.Enabled = VoterCheckbox.Checked ? true : false;

        }
        public Button getAcceptButton()
        {
            return RegisterBtn;
        }

        //private void Dummybtn_Click(object sender, EventArgs e)
        //{
        //    foreach (var c in requiredControls)
        //        c.Text = "test_dummy";

        //}

        private void RegisterControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                foreach (var c in requiredControls)
                    c.Text = "test_dummy";
                IDField.Text =  Guid.NewGuid().ToString();
            }
        }
    }
}