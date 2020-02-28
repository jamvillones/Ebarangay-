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
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            using (var ent = new EBarangayEntities())
            {
               var i= ent.spCitizen_getFullName();

                var c = ent.Citizens.ToArray().FirstOrDefault(x => x.getNameWithSpace() == "Jam Pagayunan Villones");
                Console.WriteLine(c.getNameWithSpace());
            }
        }
    }
}
