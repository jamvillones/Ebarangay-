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
        public AddCitizenForm()
        {
            InitializeComponent();
        }

        private void AddCitizenForm_Load(object sender, EventArgs e)
        {
            backColor = this.BackColor;

            capitalizeFirstLetterTextboxes(firstName, middleName, lastName, extensionName);

            ///this is for trimming excess spaces in textboxes
            var textBoxes = this.GetContainedControls<TextBox>();
            foreach (var t in textBoxes)
                t.Leave += Helper.TextBoxTrimSpaces;

            /// gets textboxes in contact group and subscribe it to callback
            var contactTexts = contactgroup.GetContainedControls<TextBox>();
            Console.WriteLine(contactTexts.Count);
            foreach (var c in contactTexts)
                c.TextChanged += contactText_Callback;

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
        void contactText_Callback(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.TextLength == t.MaxLength)
                this.SelectNextControl(t, true, true, true, true);
        }
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

            changeFieldColors(backColor);
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

            if (t.TextLength > t.MaxLength)
            {
                t.Text = t.Text.Remove(t.MaxLength);
                return;
            }

            t.Text = t.Text.Replace(" ", "");
            t.Text = t.Text.PadLeft(t.MaxLength, '0');
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
        Color backColor;
        List<Control> requiredControls = new List<Control>();

        private void birthdate_ValueChanged(object sender, EventArgs e)
        {
            string end = " years old";
            age.Text = birthdate.Value.ToAge().years.ToString() + end;
        }

        private void takePhotoBtn_Click(object sender, EventArgs e)
        {
            var cam = new CaptureImageForm();
            cam.OnSave += Cam_OnSave;
            cam.FormClosing += (a, b) => { this.Enabled = true; };
            this.Enabled = false;
            cam.Show();
        }

        private void Cam_OnSave(object sender, Image e)
        {
            picBox.Image = e;
        }
    }
}
