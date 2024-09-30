namespace YKS
{
    partial class FrmGeliristatistik
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblpara = new System.Windows.Forms.Label();
            this.CmbAy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAyKazanc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kasadaki Para:";
            // 
            // lblpara
            // 
            this.lblpara.AutoSize = true;
            this.lblpara.Location = new System.Drawing.Point(512, 52);
            this.lblpara.Name = "lblpara";
            this.lblpara.Size = new System.Drawing.Size(20, 24);
            this.lblpara.TabIndex = 1;
            this.lblpara.Text = "0";
            // 
            // CmbAy
            // 
            this.CmbAy.FormattingEnabled = true;
            this.CmbAy.Location = new System.Drawing.Point(130, 52);
            this.CmbAy.Name = "CmbAy";
            this.CmbAy.Size = new System.Drawing.Size(168, 32);
            this.CmbAy.TabIndex = 2;
            this.CmbAy.SelectedIndexChanged += new System.EventHandler(this.CmbAy_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ay Seçin:";
            // 
            // lblAyKazanc
            // 
            this.lblAyKazanc.AutoSize = true;
            this.lblAyKazanc.Location = new System.Drawing.Point(512, 110);
            this.lblAyKazanc.Name = "lblAyKazanc";
            this.lblAyKazanc.Size = new System.Drawing.Size(20, 24);
            this.lblAyKazanc.TabIndex = 5;
            this.lblAyKazanc.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Seçilen Ay:";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 169);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Aylık";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(637, 329);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // FrmGeliristatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(661, 510);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lblAyKazanc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbAy);
            this.Controls.Add(this.lblpara);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGeliristatistik";
            this.Text = "Gelir İstatistik";
            this.Load += new System.EventHandler(this.FrmGeliristatistik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblpara;
        private System.Windows.Forms.ComboBox CmbAy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAyKazanc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}