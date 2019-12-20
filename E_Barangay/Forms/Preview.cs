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
        public Preview()
        {
            InitializeComponent();
        }
        private void Preview_Load(object sender, EventArgs e)
        {
           
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

        private void EditBtn_Click(object sender, EventArgs e)
        {
            NameTxt.ReadOnly = false;
            NameTxt.BackColor = Color.SkyBlue;
            ContactTxt.ReadOnly = false;
            ContactTxt.BackColor = Color.SkyBlue;
            AddressTxt.ReadOnly = false;
            AddressTxt.BackColor = Color.SkyBlue;
            CivilStatusOption.Enabled = true;
            CivilStatusOption.BackColor = Color.SkyBlue;
            SpouseTxt.ReadOnly = false;
            SpouseTxt.BackColor = Color.SkyBlue;
            IsIndigent.AutoCheck = true;
            IsIndigent.BackColor = Color.SkyBlue;
            IsSenior.AutoCheck = true;
            IsSenior.BackColor = Color.SkyBlue;
            IsStudent.AutoCheck = true;
            IsStudent.BackColor = Color.SkyBlue;
            IsPwd.AutoCheck = true;
            IsPwd.BackColor = Color.SkyBlue;

            SaveBtn.Enabled = true;
            OkayBtn.Enabled = false;

        }

        void AssignValuesToText()
        {
            if (target == null)
            {
                MessageBox.Show("Citizen Instance not assigned");
                return;
            }
            Group.Text = "Citizen ID: "+ target.ID;
            NameTxt.Text = target.Name;
            AddressTxt.Text = target.Address;
            BdayTxt.Text = target.Birthday.ToShortDateString();
            SexTxt.Text = target.Gender;
            ContactTxt.Text = target.ContactInfo;   
            
            CivilStatusOption.Text = target.CivilStatus;

            MotherTxt.Text = target.MothersName;
            FatherTxt.Text = target.FathersName;
            if (target.SpouseName == null || target.SpouseName == "")          
                SpouseTxt.Text = "NONE";
            else      
                SpouseTxt.Text = target.SpouseName;
            
            AgeTxt.Text = (DateTime.Today.Year - target.Birthday.Year).ToString();

            IsIndigent.Checked = target.Indigent ? true : false;
            IsStudent.Checked = target.Student ? true : false;
            IsSenior.Checked = target.SeniorCitizen ? true : false;
            IsPwd.Checked = target.PWD ? true : false;

            RecordsTable.Rows.Clear();
            using (var con = new EBarangayEntities())
            {
                var t = con.Citizens.FirstOrDefault(r => r.ID == target.ID);
                if (t.Picture != null)
                    ImageBox.Image = byteArrayToImage(t.Picture);

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
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public void AcceptRecord(Record r)
        {
            
        }

        private void ImageBox_Click(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            using(var c = new EBarangayEntities())
            {
                Citizen citizen = c.Citizens.Find(target.ID);
                citizen.Name = NameTxt.Text;
                citizen.ContactInfo = ContactTxt.Text;
                citizen.CivilStatus = CivilStatusOption.Text;
                citizen.SpouseName = SpouseTxt.Text;

                citizen.PWD = IsPwd.Checked;
                citizen.Student = IsStudent.Checked;
                citizen.SeniorCitizen = IsSenior.Checked;
                citizen.Indigent = IsIndigent.Checked;

                c.SaveChanges();
            }

            OkayBtn.Enabled = true;
        }
    }
}
