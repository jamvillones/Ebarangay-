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
        E_Barangay.Class.Statistics s;
        public Dashboard()
        {
            InitializeComponent();
           
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //ShowStats();
        }

        public void ShowStats()
        {
            s = new Class.Statistics();
            using (var eb = new EBarangayEntities())
            {
                s.Initialize(eb.Citizens.ToArray());
                TotalPopTxt.Text = s.totalPopulation.ToString();
                MaleTxt.Text = s.male.ToString()+"("+s.getPercentage(s.male).ToString()+"%)";
                FemaleTxt.Text = s.female.ToString() + "(" + s.getPercentage(s.female).ToString() + "%)";
                SingleTxt.Text = s.single.ToString() + "(" + s.getPercentage(s.single).ToString() + "%)";
                MarriedTxt.Text = s.married.ToString() + "(" + s.getPercentage(s.married).ToString() + "%)";
                StudentTxt.Text = s.student.ToString() + "(" + s.getPercentage(s.student).ToString() + "%)";
                PwdTxt.Text = s.pwd.ToString() + "(" + s.getPercentage(s.pwd).ToString() + "%)";
                IndigentTxt.Text = s.indigent.ToString() + "(" + s.getPercentage(s.indigent).ToString() + "%)";
                SeniorTxt.Text = s.senior.ToString() + "(" + s.getPercentage(s.senior).ToString() + "%)";
            }
        }
    }
}
