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
                point.Label = statistics.areas[i].GetPercentage(statistics.totalPopulation).ToString() + "%";
                point.LegendText = statistics.areas[i].Name + "(" + area.PopulationCount + ")";
            }

            TypeChart.ChartAreas[0].AxisY.Minimum = 0;
            TypeChart.ChartAreas[0].AxisY.Maximum = statistics.totalPopulation;

            TypeChart.Series[0].Points[0].YValues[0] = statistics.student;
            TypeChart.Series[0].Points[1].YValues[0] = statistics.pwd;
            TypeChart.Series[0].Points[2].YValues[0] = statistics.senior;
            TypeChart.Series[0].Points[3].YValues[0] = statistics.indigent;

            TypeChart.Series[0].Points[0].Label = statistics.student + "(" + Statistics.getPercentage(statistics.student, statistics.totalPopulation).ToString() + "%)";
            TypeChart.Series[0].Points[1].Label = statistics.pwd + "(" + Statistics.getPercentage(statistics.pwd, statistics.totalPopulation).ToString() + "%)";
            TypeChart.Series[0].Points[2].Label = statistics.senior + "(" + Statistics.getPercentage(statistics.senior, statistics.totalPopulation).ToString() + "%)";
            TypeChart.Series[0].Points[3].Label = statistics.indigent + "(" + Statistics.getPercentage(statistics.indigent, statistics.totalPopulation).ToString() + "%)";

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
            voterChart.Series[0].Points[0].YValues[0] = statistics.votersCount;
            voterChart.Series[0].Points[0].LegendText = "Voters" + "(" + statistics.votersCount + ")";
            voterChart.Series[0].Points[0].Label = Statistics.getPercentage(statistics.votersCount, statistics.totalPopulation).ToString() + "%";

            voterChart.Series[0].Points[1].YValues[0] = statistics.notVotersCount;
            voterChart.Series[0].Points[1].LegendText = "Not Voters" + "(" + statistics.notVotersCount + ")";
            voterChart.Series[0].Points[1].Label = Statistics.getPercentage(statistics.notVotersCount, statistics.totalPopulation).ToString() + "%";

        }
    }
}
