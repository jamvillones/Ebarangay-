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
    public partial class AddCitizenForm : Form
    {
        public event EventHandler Onsave;
        bool editMade = false;
        public AddCitizenForm()
        {
            InitializeComponent();
        }
        void setTextBoxTextLimit()
        {
            Id.MaxLength = 13;
            firstName.MaxLength = middleName.MaxLength = lastName.MaxLength = 20;
            extensionName.MaxLength = 10;
            address.MaxLength = 50;

            sex.MaxLength = 50;
            civilStatus.MaxLength = 50;

            spouseName.MaxLength = fathersName.MaxLength = mothersName.MaxLength = 50;
            contact.MaxLength = 50;
            votersId.MaxLength = precinctNumber.MaxLength = sss.MaxLength = philhealth.MaxLength = pagibig.MaxLength = 50;
        }

        private void AddCitizenForm_Load(object sender, EventArgs e)
        {
            setTextBoxTextLimit();

            backColor = this.BackColor;

            capitalizeFirstLetterTextboxes(firstName, middleName, lastName, extensionName);

            ///this is for trimming excess spaces in textboxes
            var textBoxes = this.GetContainedControls<TextBox>();
            foreach (var t in textBoxes)
                t.Leave += Helper.TextBoxTrimSpaces;

            /// gets textboxes in contact group and subscribe it to callback
            var contactTexts = contactgroup.GetContainedControls<TextBox>();
            Console.WriteLine(contactTexts.Count);

            //foreach (var c in contactTexts)
            //    c.TextChanged += contactText_Callback;

            area.Items.Clear();
            using (var eb = new EBarangayEntities())
            {
                foreach (var a in eb.Areas)
                {
                    area.AutoCompleteCustomSource.Add(a.Name);
                    area.Items.Add(a.Name);
                }
            }

            addReqControl(Id, firstName, middleName, lastName, address, area, birthdate, sex, civilStatus);
            Console.WriteLine(requiredControls.Count);
        }

        /// <summary>
        /// this enables and disable spouse field depending in civil status input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void civilStatCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox c = sender as ComboBox;

            spouseGrp.Visible = c.Text == "Married" ? true : false;
        }
        /// <summary>
        /// Callback for setting the focus to next control when text length reached its max
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //void contactText_Callback(object sender, EventArgs e)
        //{
        //    TextBox t = (TextBox)sender;
        //    if (t.TextLength == t.MaxLength)
        //        this.SelectNextControl(t, true, true, true, true);
        //}

        bool canSave()
        {
            foreach (var c in requiredControls)
            {
                if (string.IsNullOrEmpty(c.Text))
                    return false;
            }
            return true;
        }
        void changeFieldColors(Color color)
        {
            foreach (var c in requiredControls)
                c.BackColor = color;
        }
        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (!canSave())
            {
                changeFieldColors(Color.LightPink);
                MessageBox.Show("Fill out required fields.");
                return;
            }
            MessageBox.Show("Registered successfully.");
            registerCitizen();
            clearFields();
            changeFieldColors(backColor);
            editMade = true;
        }
        void addReqControl(params Control[] c)
        {
            foreach (var cont in c)
                requiredControls.Add(cont);
        }
        private void Id_Leave(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            if (string.IsNullOrEmpty(t.Text))
                return;

            //if (t.TextLength > t.MaxLength)
            //{
            //    t.Text = t.Text.Remove(t.MaxLength);
            //    return;
            //}

            //t.Text = t.Text.Replace(" ", "");
            //t.Text = t.Text.PadLeft(t.MaxLength, '0');
            using (var eb = new EBarangayEntities())
            {
                if (eb.Citizens.Any(x => x.IdNumber == t.Text))
                {
                    MessageBox.Show("Id already taken.");
                    //t.Text = citizen.IdNumber;
                    ActiveControl = t;
                    t.SelectAll();
                }
            }
        }
        void NameTextBox_Callback(object sender, EventArgs e)
        {
            var t = (TextBox)sender;
            if (String.IsNullOrEmpty(t.Text) || Char.IsUpper(t.Text[0]))
                return;

            Char[] word;
            word = t.Text.ToCharArray();
            word[0] = Char.ToUpperInvariant(word[0]);
            t.Text = new string(word);
        }
        void capitalizeFirstLetterTextboxes(params TextBox[] target)
        {
            foreach (var t in target)
                t.Leave += NameTextBox_Callback;
        }

        private void birthdate_ValueChanged(object sender, EventArgs e)
        {
            string end = " years old";
            age.Text = birthdate.Value.ToAge().years.ToString() + end;
        }

        private void takePhotoBtn_Click(object sender, EventArgs e)
        {
            using (var cam = new CaptureImageForm())
            {
                cam.OnSave += Cam_OnSave;
                cam.ShowDialog();
            }
        }

        private void Cam_OnSave(object sender, Image e)
        {
            picBox.Image = e;
        }
        void registerCitizen()
        {
            using (var eb = new EBarangayEntities())
            {
                var c = eb.Citizens.FirstOrDefault(x => x.IdNumber == Id.Text);
                if (c != null)
                {
                    MessageBox.Show("Id is already taken.");
                    return;
                }
                Citizen citizen = new Citizen();

                var a = eb.Areas.FirstOrDefault(x => x.Name == area.Text);
                citizen.Area = a;

                citizen.Picture = Class.ImageConverter.imageToByteArray(picBox.Image);

                citizen.IdNumber = Id.Text;
                citizen.FirstName = firstName.Text;
                citizen.MiddleName = middleName.Text;
                citizen.LastName = lastName.Text;
                citizen.Extension = extensionName.Text;

                citizen.Address = address.Text;
                citizen.Birthday = birthdate.Value;
                citizen.Gender = sex.Text;
                citizen.ContactInfo = contact.Text;
                citizen.CivilStatus = civilStatus.Text;

                citizen.SpouseName = !string.IsNullOrEmpty(spouseName.Text) ? spouseName.Text : null;
                citizen.FathersName = !string.IsNullOrEmpty(fathersName.Text) ? fathersName.Text : null;
                citizen.MothersName = !string.IsNullOrEmpty(mothersName.Text) ? mothersName.Text : null;

                citizen.Indigent = indigent.Checked;
                citizen.Student = student.Checked;
                citizen.PWD = pwd.Checked;
                citizen.SeniorCitizen = senior.Checked;

                citizen.SSS = !string.IsNullOrEmpty(sss.Text) ? sss.Text : null;
                citizen.Philhealth = !string.IsNullOrEmpty(philhealth.Text) ? philhealth.Text : null;
                citizen.PagIbig = !string.IsNullOrEmpty(pagibig.Text) ? pagibig.Text : null;
                citizen.VoterID = !string.IsNullOrEmpty(votersId.Text) ? votersId.Text : null;
                citizen.PrecinctNumber = !string.IsNullOrEmpty(precinctNumber.Text) ? precinctNumber.Text : null;

                eb.Citizens.Add(citizen);
                eb.SaveChanges();
            }
        }
        void clearFields()
        {
            var textBoxes = this.GetContainedControls<TextBox>();
            foreach (var t in textBoxes)
                t.Clear();
            var combos = this.GetContainedControls<ComboBox>();
            foreach (var c in combos)
                c.Text = string.Empty;
            var checkBoxes = this.GetContainedControls<CheckBox>();
            foreach (var cb in checkBoxes)
                cb.Checked = false;

            picBox.Image = null;
        }
        private void Id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {

            }
        }
        Color backColor;
        List<Control> requiredControls = new List<Control>();

        private void AddCitizenForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (editMade)
                Onsave?.Invoke(this, null);
        }
    }
}
