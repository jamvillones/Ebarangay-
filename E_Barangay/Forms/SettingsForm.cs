using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Barangay.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            LoadOfficials();
        }
        void LoadOfficials()
        {
            using(var eb = new EBarangayEntities())
            {
                var punongBarangay = eb.Officials.Find("Punong_Barangay");
                OfficialTable.Rows.Add(punongBarangay.Position, punongBarangay.Name);

                var sb = from sbMem in eb.Officials
                         where sbMem.Position == "Sangguniang Barangay Member"
                         select sbMem;

                foreach(var member in sb)
                {
                    OfficialTable.Rows.Add(member.Position, member.Name);
                }

                var secretary = eb.Officials.Find("Barangay_Secretary");
                OfficialTable.Rows.Add(secretary.Position, secretary.Name);
                var treasurer = eb.Officials.Find("Barangay_Treasurer");
                OfficialTable.Rows.Add(treasurer.Position, treasurer.Name);            
            }
        }

        private void OfficialsBtn_Click(object sender, EventArgs e)
        {
            OfficialPanel.BringToFront();
        }

        private void AreBtn_Click(object sender, EventArgs e)
        {
           // AreaPanel.BringToFront();
        }

        CreateLogin cl;
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(cl == null)
            {
                cl = new CreateLogin();
                cl.FormClosed += (s, arg) => { this.Enabled = true; cl = null; };
                cl.Show();
                this.Enabled = false;
            }
        }

       
    }
}
