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
    public partial class AdvancedSearchForm : Form
    {
        public AdvancedSearchForm()
        {
            InitializeComponent();
        }

        private void AdvancedSearchForm_Load(object sender, EventArgs e)
        {
            using (var eb = new EBarangayEntities())
            {
                var areas = eb.Areas.ToArray();
                foreach (var a in areas)                
                    areaOptions.Items.Add(a.Name);
                
            }
            var gender = new string[] { "Male", "Female" };
            foreach (var a in gender)
                sexOption.Items.Add(a);

            var cStatus = new string[] { "Single", "Married", "Widow" };
            foreach (var a in cStatus)
                civilStatusOption.Items.Add(a);
        }
    }
}
