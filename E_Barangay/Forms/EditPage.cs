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
    public partial class EditPage : Form, Interface.IRecordAcceptor
    {
        List<Record> records = new List<Record>();
        List<Control> requiredControls = new List<Control>();

        #region citizen assignment
        Citizen citizen { get; set; }
        /// <summary>
        /// used to get the citizen to be edited
        /// </summary>
        /// <param name="c"></param>
        public void AssignCitizen(Citizen c)
        {
            citizen = c;
            SetFieldValues();
        }
        /// <summary>
        /// will assign values to controls with respect to current citizen
        /// </summary>
        void SetFieldValues()
        {
            if (citizen == null) return;
            using (var con = new EBarangayEntities())
            {
                var t = con.Citizens.FirstOrDefault(r => r.ID == citizen.ID);
                ImageBox.Image = t.Picture == null ? Properties.Resources.image_50px : Class.ImageConverter.byteArrayToImage(t.Picture);

            }
            //ImageBox.Image = Class.ImageConverter.byteArrayToImage(citizen.Picture);
            IDField.Text = citizen.ID;
            FirstNameField.Text = citizen.Name;

        }
        #endregion

        public EditPage()
        {
            InitializeComponent();
            SetRequiredControls();
        }
        //public void AcceptNewUser(object sender, string id)
        //{
        //    IDField.Text = id;
        //}
        /// <summary>
        /// adds all the required control to a single list for automation
        /// </summary>
        void SetRequiredControls()
        {
            requiredControls.Add(FirstNameField);
            // requiredControls.Add(MiddleNameField);
            // requiredControls.Add(LastNameField);
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
        /// <summary>
        /// initilalizes a dropdown with given values
        /// </summary>
        /// <param name="values"></param>
        /// <param name="startIndex"></param>
        /// <param name="comboBox"></param>
        void InitializeDropdown(string[] values, int startIndex, ref ComboBox comboBox)
        {
            for (int i = startIndex; i < values.Length; i++)
            {
                comboBox.Items.Add(values[i]);
            }
        }
        /// <summary>
        /// initializes all dropdowns
        /// </summary>
        public void InitializeDropdowns()
        {
            using (var eBarangay = new EBarangayEntities())
            {
                IQueryable<string> names = from areas in eBarangay.Areas
                                           select areas.Name;
                InitializeDropdown(names.ToArray(), 1, ref AreaOption);
            }
            SexOption.SelectedIndex = CivilStatusOption.SelectedIndex = 0;
        }

        private void Edit_Load(object sender, EventArgs e)
        {


        }

        private void SaveCallback(object sender, EventArgs e)
        {
            #region not needed
            // ///checking if valid for registration
            // if (!CanSave())
            // {
            //     ReddenRequiredFields();
            //     MessageBox.Show("Cannot Save. Fill out required fields or the id is already taken!");
            //     return;
            // }

            // Citizen temp = new Citizen();
            //// temp.ID = IDField.Text == string.Empty ? Guid.NewGuid().ToString() : IDField.Text;
            // temp.Name = FirstNameField.Text;
            //// temp.Name = FirstNameField.Text + " " + MiddleNameField.Text + " " + LastNameField.Text;
            // temp.Gender = SexOption.Text;

            // if (NumberField.Text == "")
            // {
            //     temp.Address = AreaOption.Text + ", " +
            //                    BarangayField.Text + ", " +
            //                    MunicipalityField.Text + ", " +
            //                    ProvinceField.Text;
            // }
            // else
            // {
            //     temp.Address = NumberField.Text + ", " + AreaOption.Text + ", " + BarangayField.Text + ", " + MunicipalityField.Text + ", " + ProvinceField.Text;
            // }


            // temp.Birthday = BdayPicker.Value;
            // temp.ContactInfo = ContactField.Text;

            // temp.FathersName = FatherField.Text;
            // temp.MothersName = MotherField.Text;
            // temp.CivilStatus = CivilStatusOption.Text;
            // temp.SpouseName = SpouseField.Text;

            // temp.Indigent = isIndigent.Checked;
            // temp.PWD = IsPwd.Checked;
            // temp.SeniorCitizen = IsSenior.Checked;
            // temp.Student = IsStudent.Checked;
            // temp.Picture = imageToByteArray(ImageBox.Image);

            // using (var ent = new EBarangayEntities())
            // {

            //     temp.Area = AreaOption.Items.Contains(AreaOption.Text) ? ent.Areas.FirstOrDefault(r => r.Name == AreaOption.Text) : ent.Areas.First();
            //     ent.Citizens.Add(temp);

            //     for (int i = 0; i < records.Count; i++)
            //     {
            //         records[i].CitizenID = temp.ID;
            //         ent.Records.Add(records[i]);
            //     }
            //     ent.SaveChanges();
            //     records.Clear();
            // }
            // MessageBox.Show("successfully saved!");
            // ChangeNormalColors();
            // this.ActiveControl = FirstNameField;
            // CleanFields();
            #endregion

        }
        /// <summary>
        /// checks if fields are suitable for changes
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool FieldEmpty(TextBox t)
        {
            return t.Text == string.Empty || t.Text == "required";
        }
        /// <summary>
        /// determines if no required fields are empty
        /// </summary>
        /// <returns></returns>
        bool CanSave()
        {
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
        /// <summary>
        /// empties all required fields
        /// </summary>
        void CleanFields()
        {

            IDField.Clear();
            FirstNameField.Clear();
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

        /// <summary>
        /// basically alters spouse field depending on civil status option
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        #region recordprompt
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
        #endregion

        #region captureprompt
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
            //throw new NotImplementedException();
        }

        private void CaptureForm_OnSave(object sender, Image e)
        {
            this.Enabled = true;
            ImageBox.Image = e;

        }
        #endregion

        #region imageConversion
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
        #endregion  

        private void RegisterControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                foreach (var c in requiredControls)
                    c.Text = "test_dummy";
                IDField.Text = Guid.NewGuid().ToString();
            }
        }
    }
}
