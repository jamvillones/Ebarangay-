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
    public partial class EditPage : Form
    {
        List<Complaint> tobeAdded = new List<Complaint>();
        List<Complaint> toBeRemoved = new List<Complaint>();
        List<Complaint> recordList = new List<Complaint>();

        List<Control> address = new List<Control>();

        Control[] addressArray = new Control[5];

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

        }
        string noneString = "-NONE-";
        /// <summary>
        /// will assign values to controls with respect to current citizen
        /// </summary>
        void SetFieldValues()
        {
            if (citizen == null) return;
            using (var con = new EBarangayEntities())
            {
                var t = con.Citizens.FirstOrDefault(r => r.ID == citizen.ID);
                // ImageBox.Image = t.Picture == null ? Properties.Resources.image_50px : Class.ImageConverter.byteArrayToImage(t.Picture);
                ImageBox.Image = Class.ImageConverter.byteArrayToImage(t.Picture);
            }
            //var h = citizen.getNameSeparated();

            firstField.Text = citizen.FirstName;
            middleField.Text = citizen.MiddleName;
            lastField.Text = citizen.LastName;
            extensionField.Text = citizen.Extension;

            idField.Text = citizen.ID;

            //CurrentAdd.Text = citizen.Address;
            var address = separateString(citizen.Address);
            //Console.WriteLine(addressArray.Length + "..." + address.Count);
            for (int i = 1; i <= address.Count; i++)
            {
                addressArray[addressArray.Length - i].Text = address[address.Count - i];
            }

            BdayPicker.Value = citizen.Birthday;

            ContactField.Text = citizen.ContactInfo;
            SexOption.Text = citizen.Gender;
            CivilStatusOption.Text = citizen.CivilStatus;
            FatherField.Text = citizen.FathersName;
            MotherField.Text = citizen.MothersName;
            
            SpouseField.Text = citizen.SpouseName ?? noneString;
            VoterIDField.Text = citizen.VoterID ?? noneString;
            PrecinctNumField.Text = citizen.PrecinctNumber ?? noneString;

            PIField.Text = citizen.PagIbig ?? noneString;
            PHField.Text = citizen.Philhealth ?? noneString;
            SSSField.Text = citizen.SSS ?? noneString;

            IsStudent.Checked = citizen.Student;
            IsPwd.Checked = citizen.PWD;
            IsSenior.Checked = citizen.SeniorCitizen;
            isIndigent.Checked = citizen.Indigent;

        }

        List<string> separateString(string s)
        {
            List<string> ss = new List<string>();
            string tmp = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ',')
                {
                    ss.Add(tmp.Trim(' '));
                    tmp = string.Empty;
                }
                else
                {
                    tmp += s[i];
                    if (i == s.Length - 1)
                    {
                        ss.Add(tmp.Trim(' '));
                        tmp = string.Empty;
                    }
                }
            }
            return ss;
        }
        #endregion

        //PasswordForm password;
        public EditPage()
        {
            InitializeComponent();
            SetRequiredControls();
            address.Add(NumberField);
            addressArray[0] = NumberField;
            addressArray[1] = AreaOption;
            addressArray[2] = BarangayField;
            addressArray[3] = MunicipalityField;
            addressArray[4] = ProvinceField;
        }

        private void Password_OnCorrectPassword(object sender, bool e)
        {
            if (e)
            {
                this.Show();
            }
            else
            {

                Console.WriteLine("wrong");
                this.Close();
                this.Dispose();
            }
            //throw new NotImplementedException();
        }
        /// <summary>
        /// adds all the required control to a single list for automation
        /// </summary>
        void SetRequiredControls()
        {
            requiredControls.Add(firstField);
            requiredControls.Add(BarangayField);
            requiredControls.Add(AreaOption);
            requiredControls.Add(ProvinceField);
            requiredControls.Add(MunicipalityField);
            requiredControls.Add(ContactField);
            requiredControls.Add(FatherField);
            requiredControls.Add(MotherField);
            requiredControls.Add(idField);
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
            InitializeDropdowns();

            SetFieldValues();


        }
        bool validAddress
        {
            get
            {
                return AreaOption.Text != string.Empty && BarangayField.Text != string.Empty && MunicipalityField.Text != string.Empty && ProvinceField.Text != string.Empty;
            }
        }
        bool fieldisempty(Control control)
        {
            return control.Text == noneString || control.Text == string.Empty;
        }
        private void SaveCallback(object sender, EventArgs e)
        {
            using (var entity = new EBarangayEntities())
            {
                var _citizen_ = entity.Citizens.FirstOrDefault(c => c.ID == citizen.ID);
                _citizen_.Picture = Class.ImageConverter.imageToByteArray(ImageBox.Image);
                _citizen_.FirstName = firstField.Text == string.Empty ? _citizen_.FirstName : firstField.Text;
                _citizen_.MiddleName = middleField.Text == string.Empty ? _citizen_.MiddleName : middleField.Text;
                _citizen_.LastName = lastField.Text == string.Empty ? _citizen_.LastName : lastField.Text;
                _citizen_.Extension = extensionField.Text == string.Empty ? _citizen_.Extension : extensionField.Text;

                _citizen_.Birthday = BdayPicker.Value;
                _citizen_.ContactInfo = fieldisempty(ContactField) ? _citizen_.ContactInfo : ContactField.Text;
                _citizen_.Gender = SexOption.Text == string.Empty ? _citizen_.Gender : SexOption.Text;
                _citizen_.CivilStatus = CivilStatusOption.Text == string.Empty ? _citizen_.CivilStatus : CivilStatusOption.Text;

                _citizen_.SpouseName = fieldisempty(SpouseField) ? null : SpouseField.Text;
                _citizen_.VoterID = fieldisempty(VoterIDField) ? null : VoterIDField.Text;
                _citizen_.PrecinctNumber = fieldisempty(PrecinctNumField) ? null : PrecinctNumField.Text;
                _citizen_.SSS = fieldisempty(SSSField) ? null : SSSField.Text;
                _citizen_.PagIbig = fieldisempty(PIField) ? null : PIField.Text;
                _citizen_.Philhealth = fieldisempty(PHField) ? null : PHField.Text;



                string address = AreaOption.Text + ", " + BarangayField.Text + ", " + MunicipalityField.Text + ", " + ProvinceField.Text;

                ///check if the addreass is valid to be changed if not dont save address
                if (validAddress)
                {
                    if (NumberField.Text == string.Empty)
                    {
                        _citizen_.Address = address;
                    }
                    else
                    {
                        _citizen_.Address = NumberField.Text + ", " + address;
                    }
                    _citizen_.Area = AreaOption.Items.Contains(AreaOption.Text) ? entity.Areas.FirstOrDefault(r => r.Name == AreaOption.Text) : entity.Areas.First();
                }
                ///endif

                _citizen_.FathersName = FatherField.Text;
                _citizen_.MothersName = MotherField.Text;

                ///checkboxes
                _citizen_.Student = IsStudent.Checked;
                _citizen_.PWD = IsPwd.Checked;
                _citizen_.SeniorCitizen = IsSenior.Checked;
                _citizen_.Indigent = isIndigent.Checked;
                ///endif



                entity.SaveChanges();
                MessageBox.Show("Saved Successfully");
                this.Close();
            }
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

            idField.Clear();
            firstField.Clear();
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

            BirthdayLabel.ResetText();


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
                SpouseField.Text = noneString;
                return;
            }
            SpouseField.Enabled = true;
            SpouseField.Text = citizen.SpouseName ?? string.Empty;
        }

        private void BdayPicker_ValueChanged(object sender, EventArgs e)
        {
            AgeField.Text = Class.DateTimeExtension.ToAge(BdayPicker.Value).years.ToString();
        }

        #region recordprompt

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Record_OnSave(object sender, Complaint e)
        {
            //var r = e;

            ////r.CitizenID = citizen.ID;

            //recordList.Add(r);
            ////RecordsTable.Rows.Add(r.DateIssued, r.Name, r.Details);
            //using (var eb = new EBarangayEntities())
            //{
            //    eb.Records.Add(r);
            //    eb.SaveChanges();
            //}
            /////throw new NotImplementedException();
        }

        private void Record_FormClosed(object sender, FormClosedEventArgs e)
        {
            // recForm = null;
            this.Enabled = true;
            // ShowRecords();
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


        //private void VoterCheckbox_CheckedChanged(object sender, EventArgs e)
        //{

        //    VoterIDField.Enabled = PrecinctNumField.Enabled = VoterCheckbox.Checked ? true : false;

        //}


        private void RegisterControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                foreach (var c in requiredControls)
                    c.Text = "test_dummy";
                idField.Text = Guid.NewGuid().ToString();
            }
        }
    }
}
