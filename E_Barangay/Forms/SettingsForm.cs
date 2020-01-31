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
                captainTxt.Text = eb.Officials.Find("Punong_Barangay").Name;

                LoadSB(eb.Officials.ToList(), sbTxt0, sbTxt1, sbTxt2, sbTxt3, sbTxt4, sbTxt5, sbTxt6);

                secTxt.Text = eb.Officials.FirstOrDefault(o => o.Position == "Barangay Secretary").Name;
                treasTxt.Text = eb.Officials.FirstOrDefault(o => o.Position == "Barangay Treasurer").Name;

            }
        }
        void LoadSB(List<Official> o, params Control[] txt)
        {
            for(int i = 0; i < txt.Length; i++)
            {
                txt[i].Text = o[i].Name;
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
