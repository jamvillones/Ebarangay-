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
    public partial class Dashboard : UserControl
    {
        //E_Barangay.Class.Statistics s;
        public Dashboard()
        {
            InitializeComponent();
        }

        public void InitValues()
        {
            using (var eb = new EBarangayEntities())
            {
                captainTxt.Text = eb.Officials.Find("Punong_Barangay").Name;

                var sb = from sbmemb in eb.Officials
                         where sbmemb.Position == "Sangguniang Barangay Member"
                         select sbmemb;

                LoadSB(sb.ToList(), sbTxt0, sbTxt1, sbTxt2, sbTxt3, sbTxt4, sbTxt5, sbTxt6);

                secTxt.Text = eb.Officials.FirstOrDefault(o => o.Position == "Barangay Secretary").Name;
                treasTxt.Text = eb.Officials.FirstOrDefault(o => o.Position == "Barangay Treasurer").Name;

                PopulationTxt.Text = eb.Citizens.Count().ToString();

                var area = eb.Areas;
                areaList.Items.Clear();

                foreach (var a in area)
                {
                    string s = a.Name;
                    areaList.Items.Add(s);
                }               
            }
        }

        void LoadSB(List<Official> o, params Control[] txt)
        {
            for (int i = 0; i < txt.Length; i++)
            {
                txt[i].Text = o[i].Name;
            }
        }
    }
}
