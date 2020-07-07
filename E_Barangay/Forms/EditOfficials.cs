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

    public partial class EditOfficials : Form
    {
        struct OfficialsMarker
        {
            public string Id { get; set; }
            public bool save { get; set; }
            //public bool {get; set;}
        }
        OfficialsMarker[] officialsMarker = new OfficialsMarker[10];
        public EditOfficials()
        {
            InitializeComponent();
            using (var eb = new EBarangayEntities())
            {                
                officialsMarker[0].Id = eb.Officials.FirstOrDefault(x => x.ID == "Punong_Barangay").ID;
                pbText.Text = eb.Officials.FirstOrDefault(x => x.ID == "Punong_Barangay").Name;
               
                var sbs = eb.Officials.Where(x => x.Position == "Sangguniang Barangay Member").OrderBy(x => x.ID).ToArray();
                LoadSB(eb.Officials.Where(x => x.Position == "Sangguniang Barangay Member").OrderBy(x => x.ID).ToArray(),
                                          sbText1, sbText2, sbText3, sbText4, sbText5, sbText6, sbText7);

                for (int i = 1; i < officialsMarker.Length - 2; i++)
                {
                    officialsMarker[i].Id = sbs[i - 1].ID;
                    
                }
                var sec = eb.Officials.FirstOrDefault(x => x.ID == "Barangay_Secretary");
                officialsMarker[8].Id = sec.ID;
                secText.Text = sec.Name;

                var tres = eb.Officials.FirstOrDefault(x => x.ID == "Barangay_Treasurer");
                officialsMarker[9].Id = tres.ID;
                tresText.Text = tres.Name;
            }

            for (int i = 0;i<officialsMarker.Length;i++)
            {
                officialsMarker[i].save = false;
            }

        }
        void LoadSB(Official[] o, params Control[] txt)
        {
            for (int i = 0; i < txt.Length; i++)
            {
                txt[i].Text = o[i].Name;
            }
        }

        private void pbText_TextChanged(object sender, EventArgs e)
        {
            officialsMarker[0].save = true;
        }

        private void sbText1_TextChanged(object sender, EventArgs e)
        {
            officialsMarker[1].save = true;
        }

        private void sbText2_TextChanged(object sender, EventArgs e)
        {
            officialsMarker[2].save = true;
        }

        private void sbText3_TextChanged(object sender, EventArgs e)
        {
            officialsMarker[3].save = true;
        }

        private void sbText4_TextChanged(object sender, EventArgs e)
        {
            officialsMarker[4].save = true;
        }

        private void sbText5_TextChanged(object sender, EventArgs e)
        {
            officialsMarker[5].save = true;
        }

        private void sbText6_TextChanged(object sender, EventArgs e)
        {
            officialsMarker[6].save = true;
        }

        private void sbText7_TextChanged(object sender, EventArgs e)
        {
            officialsMarker[7].save = true;
        }

        private void secText_TextChanged(object sender, EventArgs e)
        {
            officialsMarker[8].save = true;
        }

        private void tresText_TextChanged(object sender, EventArgs e)
        {
            officialsMarker[9].save = true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(!canSave(pbText, sbText1, sbText2, sbText3, sbText4, sbText5, sbText6, sbText7, secText, tresText))
            {
                MessageBox.Show("Fields can never be empty!");
                return;
            }
            save(pbText, sbText1, sbText2, sbText3, sbText4, sbText5, sbText6, sbText7, secText, tresText);
        }
        bool canSave(params Control[] c)
        {
            foreach(var a in c)
            {
                if (string.IsNullOrEmpty(a.Text))
                {
                    return false;
                }
            }
            return true;
        }
        void save(params Control[] control)
        {
            using (var eb = new EBarangayEntities())
            {
                for (int i = 0; i < officialsMarker.Length; i++)
                {
                    if (officialsMarker[i].save)
                    {
                        string id = officialsMarker[i].Id;
                        var o = eb.Officials.FirstOrDefault(x => x.ID == id);
                        o.Name = control[i].Text;
                    }
                }
                eb.SaveChanges();
            }
            MessageBox.Show("Edit Successful.");
        }
    }
}
