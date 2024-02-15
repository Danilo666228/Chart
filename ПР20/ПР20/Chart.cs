using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПР20
{
    public partial class Chart : Form
    {
        private double XMax;
        private double XMin;
        private double Step;

        private double[] x;
        private double[] y1;
        private double[] y2;

        private void CalcFunction()
        {
            int count = (int)Math.Ceiling((XMax - XMin) / Step) + 1;
            x = new double[count];
            y1 = new double[count];
            y2 = new double[count];
            for(int i = 0; i < count; i++)
            {
                x[i] = XMin + Step * i;
                y1[i] = Math.Sin(x[i]);
                y2[i] = Math.Cos(x[i]);
            }
        }

        public Chart()
        {
            InitializeComponent();
        }

        private void btnGraphics_Click(object sender, EventArgs e)
        {
            chart1.Visible = true;
            XMin = double.Parse(txbXmin.Text);
            XMax = double.Parse(txbXmax.Text);
            Step = double.Parse(txbStep.Text);
            CalcFunction();
            chart1.ChartAreas[0].AxisX.Minimum = XMin;
            chart1.ChartAreas[0].AxisX.Minimum = XMax;

            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = Step;

            chart1.Series[0].Points.DataBindXY(x, y1);
            chart1.Series[1].Points.DataBindXY(x, y2);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            StudentAnalysis student = new StudentAnalysis();
            student.Show();
        }
    }
}
