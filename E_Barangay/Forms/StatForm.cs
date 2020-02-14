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

            TypeChart.ChartAreas[0].AxisY.Minimum = 0;
            TypeChart.ChartAreas[0].AxisY.Maximum = statistics.totalPopulation;

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

            genderChart.Series[0].Points[0].YValues[0] = statistics.male;
            genderChart.Series[0].Points[0].LegendText = "Male" + "(" + statistics.male + ")";
            genderChart.Series[0].Points[0].Label = Math.Round(((float)statistics.male / (float)statistics.totalPopulation) * 100, 2).ToString() + "%";

            genderChart.Series[0].Points[1].YValues[0] = statistics.female;
            genderChart.Series[0].Points[1].LegendText = "Female" + "(" + statistics.female + ")";
            genderChart.Series[0].Points[1].Label = Math.Round(((float)statistics.female / (float)statistics.totalPopulation) * 100, 2).ToString() + "%";

            cStatusChart.Series[0].Points.Clear();
            foreach (var status in statistics.cstatuses)
            {
                DataPoint point = new DataPoint();
                point.LegendText = status.Name + "(" + status.Count + ")";
                point.YValues[0] = status.Count;
                float labelValue = ((float)status.Count / (float)statistics.totalPopulation) * 100f;

                point.Label = Math.Round((double)labelValue, 2).ToString() + "%";

                cStatusChart.Series[0].Points.Add(point);
            }

        }
    }
}
