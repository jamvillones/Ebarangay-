using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Barangay.Forms
{
    public partial class BarangayClearanceForm : Form
    {
        bool EditMade = false;
        public BarangayClearanceForm()
        {
            InitializeComponent();

        }

        string Indention = "        ";
        string LineSpace = "\n\n\n";
        string MrOrMrs(string sex)
        {
            if (sex == "")
            {
                return "(BLANK)";
            }
            return sex == "Male" ? "Mr." : "Ms.";
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.BARANGAY_CLEARANCE, new PointF(0, 0));

            Pen pen = new Pen(Color.Black);
            Font font = new Font("Arial Narrow", 12, FontStyle.Regular);

            RectangleF rect = new RectangleF(e.PageBounds.Width / 3 - 30, e.PageBounds.Height / 3, 548, 300);
            string text = Indention + "This is to certify that as per record of this Barangay " + TextBoxFormat(firstName) + " " + TextBoxFormat(middleName) + ". " + TextBoxFormat(lastName) + ", " + TextBoxFormat(Age) + " years old, " + TextBoxFormat(CStatusOption) + ", Filipino and a resident of " + TextBoxFormat(Address) + ", whose signature appears below has no criminal, civil or administrative charges before this office and has good moral standing in the community." + LineSpace
                          + Indention + "This certification is issued upon the request of " + MrOrMrs(SexOption.Text) + " " + TextBoxFormat(lastName) + " for the purpose of " + (SexOption.Text == "" ? "(BLANK)" : (SexOption.Text == "Male" ? "his" : "her")) + " " + TextBoxFormat(Purpose) + "." + LineSpace
                          + "WITNESS MY HAND SEAL, this " + IssuedOn.Value.Day + "th  day of " + IssuedOn.Value.ToString("MMMM") + ", " + IssuedOn.Value.Year + " at Barangay Poblacion, Kalibo, Aklan, Philippines.";

            e.Graphics.DrawString(text, font, Brushes.Black, rect);

            var rectangleTest = new RectangleF(e.PageBounds.Width / 3 - 30, e.PageBounds.Height - 300, 240, 100);

            string orTxt = "Paid Under OR No: " + TextBoxFormat(OrNo) + "\n" +
                           "Issued On: " + ORIssueDate.Value.ToString("MMMM") + " " + ORIssueDate.Value.Day.ToString() + ", " + ORIssueDate.Value.Year.ToString() + "\n" +
                           "Note: Valid Until: " + OrValidityDate.Value.ToString("MMMM") + " " + OrValidityDate.Value.Day.ToString() + ", " + OrValidityDate.Value.Year.ToString();

            e.Graphics.DrawString(orTxt, font, Brushes.Black, rectangleTest);
        }

        string TextBoxFormat(Control c)
        {
            if (c.Text == "")
                return "(BLANK)";
            return c.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ToggleEdit();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void IssuePage_Load(object sender, EventArgs e)
        {
            UpdateBtn.Enabled = false;
            EditMade = false;
            printPreviewControl1.Document = printDocument1;
            this.BringToFront();
        }

        private void ToggleEdit()
        {
            if (EditMade)
            {
                printPreviewControl1.Document = printDocument1;
                EditMade = false;
                UpdateBtn.Enabled = false;
            }
        }

        private void MadeChangesCallback(object sender, EventArgs e)
        {
            Control c = (Control)sender;
            Console.WriteLine(c.Name.ToString());

            EditMade = true;
            UpdateBtn.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void UpdateBtn_Click_1(object sender, EventArgs e)
        {
            ToggleEdit();
        }
        public void AcceptCitizen(Citizen c)
        {
            if (c == null)
            {
                MessageBox.Show("Not found");
                IDField.SelectAll();
                this.ActiveControl = IDField;
                return;
            }
            List<string> nameList = new List<string>();
            string word = "";
            string name = c.Name;
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == ' ' || i == name.Length - 1)
                {
                    if (i == name.Length - 1)
                        word += name[i];
                    nameList.Add(word);
                    word = "";
                }
                else
                {
                    word += name[i];
                }
            }
            firstName.Text = nameList[0];
            middleName.Text = nameList[1][0].ToString();
            lastName.Text = nameList[2];
            int age = DateTime.Today.Year - c.Birthday.Year;
            Age.Text = age > 0 ? age.ToString() : 1.ToString();
            Address.Text = c.Address;
            CStatusOption.Text = c.CivilStatus;
            SexOption.Text = c.Gender;
        }

        private void AssignBtn_Click(object sender, EventArgs e)
        {
            using (var entity = new EBarangayEntities())
            {
                var citizen = entity.Citizens.Find(IDField.Text);
                AcceptCitizen(citizen);
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            clearFields(firstName, middleName, lastName, Age, Address, CStatusOption, SexOption);
        }
        void clearFields(params Control[] controls)
        {
            foreach (Control c in controls)
            {
                c.ResetText();
            }
        }
    }
}
