namespace ПР20
{
    partial class Chart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblXmin = new System.Windows.Forms.Label();
            this.lblXmax = new System.Windows.Forms.Label();
            this.lblStep = new System.Windows.Forms.Label();
            this.txbXmin = new System.Windows.Forms.TextBox();
            this.txbXmax = new System.Windows.Forms.TextBox();
            this.txbStep = new System.Windows.Forms.TextBox();
            this.btnGraphics = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(31, 13);
            this.chart1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series1.Legend = "Legend1";
            series1.LegendText = "sin(x)";
            series1.Name = "Series1";
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series2.Legend = "Legend1";
            series2.LegendText = "cos(x)";
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1459, 438);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // lblXmin
            // 
            this.lblXmin.AutoSize = true;
            this.lblXmin.Location = new System.Drawing.Point(270, 539);
            this.lblXmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblXmin.Name = "lblXmin";
            this.lblXmin.Size = new System.Drawing.Size(72, 19);
            this.lblXmin.TabIndex = 1;
            this.lblXmin.Text = "X - min";
            // 
            // lblXmax
            // 
            this.lblXmax.AutoSize = true;
            this.lblXmax.Location = new System.Drawing.Point(573, 539);
            this.lblXmax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblXmax.Name = "lblXmax";
            this.lblXmax.Size = new System.Drawing.Size(72, 19);
            this.lblXmax.TabIndex = 2;
            this.lblXmax.Text = "X - max";
            // 
            // lblStep
            // 
            this.lblStep.AutoSize = true;
            this.lblStep.Location = new System.Drawing.Point(896, 539);
            this.lblStep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStep.Name = "lblStep";
            this.lblStep.Size = new System.Drawing.Size(36, 19);
            this.lblStep.TabIndex = 3;
            this.lblStep.Text = "Шаг";
            // 
            // txbXmin
            // 
            this.txbXmin.Location = new System.Drawing.Point(240, 576);
            this.txbXmin.Margin = new System.Windows.Forms.Padding(4);
            this.txbXmin.Name = "txbXmin";
            this.txbXmin.Size = new System.Drawing.Size(127, 27);
            this.txbXmin.TabIndex = 4;
            // 
            // txbXmax
            // 
            this.txbXmax.Location = new System.Drawing.Point(549, 576);
            this.txbXmax.Margin = new System.Windows.Forms.Padding(4);
            this.txbXmax.Name = "txbXmax";
            this.txbXmax.Size = new System.Drawing.Size(127, 27);
            this.txbXmax.TabIndex = 4;
            // 
            // txbStep
            // 
            this.txbStep.Location = new System.Drawing.Point(853, 576);
            this.txbStep.Margin = new System.Windows.Forms.Padding(4);
            this.txbStep.Name = "txbStep";
            this.txbStep.Size = new System.Drawing.Size(127, 27);
            this.txbStep.TabIndex = 4;
            // 
            // btnGraphics
            // 
            this.btnGraphics.Location = new System.Drawing.Point(1223, 537);
            this.btnGraphics.Margin = new System.Windows.Forms.Padding(4);
            this.btnGraphics.Name = "btnGraphics";
            this.btnGraphics.Size = new System.Drawing.Size(203, 66);
            this.btnGraphics.TabIndex = 5;
            this.btnGraphics.Text = "Построить график";
            this.btnGraphics.UseVisualStyleBackColor = true;
            this.btnGraphics.Click += new System.EventHandler(this.btnGraphics_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1223, 636);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(203, 75);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Далее";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1529, 732);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnGraphics);
            this.Controls.Add(this.txbStep);
            this.Controls.Add(this.txbXmax);
            this.Controls.Add(this.txbXmin);
            this.Controls.Add(this.lblStep);
            this.Controls.Add(this.lblXmax);
            this.Controls.Add(this.lblXmin);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Chart";
            this.Text = "Chart";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lblXmin;
        private System.Windows.Forms.Label lblXmax;
        private System.Windows.Forms.Label lblStep;
        private System.Windows.Forms.TextBox txbXmin;
        private System.Windows.Forms.TextBox txbXmax;
        private System.Windows.Forms.TextBox txbStep;
        private System.Windows.Forms.Button btnGraphics;
        private System.Windows.Forms.Button btnNext;
    }
}