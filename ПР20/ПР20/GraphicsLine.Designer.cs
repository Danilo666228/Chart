namespace ПР20
{
    partial class GraphicsLine
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblGrapchics = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnNextExample = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGrapchics
            // 
            this.lblGrapchics.AutoSize = true;
            this.lblGrapchics.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGrapchics.Location = new System.Drawing.Point(13, 19);
            this.lblGrapchics.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrapchics.Name = "lblGrapchics";
            this.lblGrapchics.Size = new System.Drawing.Size(320, 21);
            this.lblGrapchics.TabIndex = 0;
            this.lblGrapchics.Text = "Выберите графичесакий приметив:";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Items.AddRange(new object[] {
            "Линия",
            "Прямоугольник",
            "Закрашенный прямоугольник",
            "Эллипс",
            "Закрашенный эллипс",
            "Сектор круга",
            "Закрашенный сектор круга"});
            this.listBox1.Location = new System.Drawing.Point(41, 113);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(241, 137);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnNextExample
            // 
            this.btnNextExample.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNextExample.Location = new System.Drawing.Point(522, 318);
            this.btnNextExample.Name = "btnNextExample";
            this.btnNextExample.Size = new System.Drawing.Size(206, 53);
            this.btnNextExample.TabIndex = 2;
            this.btnNextExample.Text = "Далее";
            this.btnNextExample.UseVisualStyleBackColor = true;
            this.btnNextExample.Click += new System.EventHandler(this.btnNextExample_Click);
            // 
            // GraphicsLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 383);
            this.Controls.Add(this.btnNextExample);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblGrapchics);
            this.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GraphicsLine";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGrapchics;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnNextExample;
    }
}

