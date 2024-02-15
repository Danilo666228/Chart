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
    public partial class GraphicsLine : Form
    {
        public GraphicsLine()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pn = new Pen(colorDialog1.Color, 4);
            Brush br = new SolidBrush(colorDialog1.Color);
            g.Clear(SystemColors.Control);

            switch (listBox1.SelectedIndex)
            {
                case 0:
                    if (colorDialog1.ShowDialog() == DialogResult.OK)
                    {
                        pn.Color = colorDialog1.Color;
                        g.DrawLine(pn, 450, 50, 350, 180);
                    }
                    break;
                case 1:
                    if (colorDialog1.ShowDialog() == DialogResult.OK)
                    {
                        pn.Color = colorDialog1.Color;
                        g.DrawRectangle(pn, 350, 50, 200, 150);
                    }
                    break;
                case 2:
                    if (colorDialog1.ShowDialog() == DialogResult.OK)
                    {
                        pn.Color = colorDialog1.Color;
                        g.FillRectangle(br, 350, 50, 250, 150);
                    }
                    break;
                case 3:
                    if (colorDialog1.ShowDialog() == DialogResult.OK)
                    {
                        pn.Color = colorDialog1.Color;
                        g.DrawEllipse(pn, 350, 50, 250, 150);
                    }
                    break;
                case 4:
                    if (colorDialog1.ShowDialog() == DialogResult.OK)
                    {
                        pn.Color = colorDialog1.Color;
                        g.FillEllipse(br, 350, 50, 250, 150);
                    }
                    break;
                case 5:
                    if (colorDialog1.ShowDialog() == DialogResult.OK)
                    {
                        pn.Color = colorDialog1.Color;
                        g.DrawPie(pn, 300, 50, 300, 200, 180, 255);
                    }
                    break;
                case 6:
                    if (colorDialog1.ShowDialog() == DialogResult.OK)
                    {
                        pn.Color = colorDialog1.Color;
                        g.FillPie(br, 350, 50, 150, 150, 0, 45);
                    }
                    break;
            }
        }

        private void btnNextExample_Click(object sender, EventArgs e)
        {
            Chart ChartForm = new Chart();
            ChartForm.Show();
            
        }
    }
}
