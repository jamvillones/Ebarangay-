using E_Barangay.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace E_Barangay.Forms
{
    public partial class StatForm : Form
    {
        public StatForm()
        {
            InitializeComponent();
        }

        private void StatForm__Load(object sender, EventArgs e)
        {
            InitializeCharts();
        }

        void InitializeCharts()
        {
            Statistics statistics = new Statistics();
            statistics.Initialize();

            for (int i = 0; i < statistics.areas.Count; i++)
            {
                var point = AreaChart.Series[0].Points[i];
                var area = statistics.areas[i];

                point.YValues[0] = statistics.areas[i].PopulationCount;
                point.LegendText = statistics.areas[i].Name + "(" + area.PopulationCount + ")";
            }

            TypeChart.Series[0].Points[0].YValues[0] = statistics.student;
            TypeChart.Series[0].Points[1].YValues[0] = statistics.pwd;
            TypeChart.Series[0].Points[2].YValues[0] = statistics.senior;
            TypeChart.Series[0].Points[3].YValues[0] = statistics.indigent;

        }
    }
}
