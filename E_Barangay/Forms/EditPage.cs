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
        // List<Record> records = new List<Record>();
        //ICollection<Record> records;
        List<Record> tobeAdded = new List<Record>();
        List<Record> toBeRemoved = new List<Record>();
        List<Record> recordList = new List<Record>();

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
                ImageBox.Image = t.Picture == null ? Properties.Resources.image_50px : Class.ImageConverter.byteArrayToImage(t.Picture);

                recordList = t.Records.ToList<Record>();
                for (int i = 0; i < recordList.Count; i++)
                {
                    RecordsTable.Rows.Add();
                    RecordsTable.Rows[i].Cells[0].Value = recordList[i].DateIssued;
                    RecordsTable.Rows[i].Cells[1].Value = recordList[i].Name;
                    RecordsTable.Rows[i].Cells[2].Value = recordList[i].Details;
                }
            }
            //ImageBox.Image = Class.ImageConverter.byteArrayToImage(citizen.Picture);
            IDField.Text = citizen.ID;
            FirstNameField.Text = citizen.Name;
            CurrentAdd.Text = citizen.Address;

            BdayPicker.Value = citizen.Birthday;
            //AreaOption.SelectedText = 

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
        #endregion

        //PasswordForm password;
        public EditPage()
        {
            InitializeComponent();
            SetRequiredControls();
            //password = new PasswordForm(Class.UserManager.instance.currentUser.Username);
            //password.OnCorrectPassword += Password_OnCorrectPassword;
            //password.Show();
        }

        private void Password_OnCorrectPassword(object sender, bool e)
        {
            if (e)
            {
                this.Show();
            }
            else
            {
                //this.Show();
                // MessageBox.Show("Sorry wrong Password");
                //Close();
                Console.WriteLine("wrong");
                this.Close();
                this.Dispose();
            }
            //throw new NotImplementedException();
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
        //public void AcceptRecord(Record c)
        //{
        //    records.Add(c);
        //}
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
            recDeleteBtn.Enabled = UserManager.instance.currentUser.canDelete;
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
            using (var entity = new EBarangayEntities())
            {
                var _citizen_ = entity.Citizens.FirstOrDefault(c => c.ID == citizen.ID);
                _citizen_.Picture = Class.ImageConverter.imageToByteArray(ImageBox.Image);
                _citizen_.Name = FirstNameField.Text == string.Empty ? _citizen_.Name : FirstNameField.Text;
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

                //foreach (var r in tobeAdded)
                //    _citizen_.Records.Add(r);

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

            BirthdayLabel.ResetText();

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
                SpouseField.Text = noneString;
                return;
            }
            SpouseField.Enabled = true;
            SpouseField.Text = citizen.SpouseName ?? string.Empty;
        }

        private void BdayPicker_ValueChanged(object sender, EventArgs e)
        {
            var today = DateTime.Today;
            var age = today.Year - BdayPicker.Value.Year;
            AgeField.Text = age.ToString();
        }

        #region recordprompt
        RecordForm recForm;
        private void button3_Click(object sender, EventArgs e)
        {
            if (recForm == null)
            {
                recForm = new RecordForm();
                recForm.FormClosed += Record_FormClosed;
                recForm.OnSave += Record_OnSave;
                // record.GetRef(this);
                recForm.Show();
                this.Enabled = false;
                return;
            }
            recForm.BringToFront();
        }

        private void Record_OnSave(object sender, Record e)
        {
            var r = e;

            // records.Add(e);
            r.CitizenID = citizen.ID;
            // records.Add(e);
            //tobeAdded.Add(e);
            recordList.Add(r);
            RecordsTable.Rows.Add(r.DateIssued, r.Name, r.Details);
            using (var eb = new EBarangayEntities())
            {
                eb.Records.Add(r);
                eb.SaveChanges();
            }
            ///throw new NotImplementedException();
        }

        private void Record_FormClosed(object sender, FormClosedEventArgs e)
        {
            recForm = null;
            this.Enabled = true;
            // ShowRecords();
        }

        //void ShowRecords()
        //{
        //    RecordsTable.Rows.Clear();
        //    Record[] rec = records.ToArray();
        //    for (int i = 0; i < records.Count; i++)
        //    {
        //        RecordsTable.Rows.Add();
        //        RecordsTable.Rows[i].Cells[0].Value = rec[i].DateIssued;
        //        RecordsTable.Rows[i].Cells[1].Value = rec[i].Name;
        //        RecordsTable.Rows[i].Cells[2].Value = rec[i].Details;
        //    }


        //}
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            var yesOrNo = new YesOrNoPrompt("Are you sure you want to delete this record");
            yesOrNo.onBtnClick += (s, ee) =>
            {
                if (ee) removeByDataIndex();
                this.Enabled = true;

            };
            yesOrNo.Show();

        }

        //private void YesOrNo_onBtnClick(object sender, bool e)
        //{
        //    if (e)
        //        removeByDataIndex();
        //    this.Enabled = true;
        //}

        int index
        {
            get
            {
                return RecordsTable.SelectedCells[0].RowIndex;
            }
        }
        Record recordByIndex
        {
            get
            {
                return recordList[index];
            }
        }
        void removeByDataIndex()
        {
            if (RecordsTable.Rows.Count == 0)
                return;
          
            ///remove it from database first to avoid error
            using (var eb = new EBarangayEntities())
            {
                var tbr = eb.Records.Find(recordByIndex.ID);
                eb.Records.Remove(tbr);
                eb.SaveChanges();
            }

            RecordsTable.Rows.RemoveAt(index);


            //RecordsTable.Rows.RemoveAt(index);

        }

        //private void RecordsTable_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    var view = new RecordView(recordByIndex);
        //    view.Show();

        //}

        private void RecordsTable_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var view = new RecordView(recordByIndex);
            view.FormClosed += (ee, ss) => { this.Enabled = true; };
            this.Enabled = false;
            view.Show();

        }
    }
}
