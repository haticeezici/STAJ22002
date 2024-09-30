namespace YKS
{
    partial class FrmOdemeler
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ogrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrKalanBorcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borclarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.yurtKayitDataSet4 = new YKS.YurtKayitDataSet4();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtOgrId = new System.Windows.Forms.TextBox();
            this.TxtOdenen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtKalan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.yurtKayitDataSet3 = new YKS.YurtKayitDataSet3();
            this.borclarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.borclarTableAdapter = new YKS.YurtKayitDataSet3TableAdapters.BorclarTableAdapter();
            this.borclarTableAdapter1 = new YKS.YurtKayitDataSet4TableAdapters.BorclarTableAdapter();
            this.TxtOgrAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtOgrSoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtOdenenAy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borclarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayitDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayitDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borclarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ogrid,
            this.ogrAdDataGridViewTextBoxColumn,
            this.ogrSoyadDataGridViewTextBoxColumn,
            this.ogrKalanBorcDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.borclarBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(436, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(554, 256);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Ogrid
            // 
            this.Ogrid.DataPropertyName = "Ogrid";
            this.Ogrid.HeaderText = "Ogrid";
            this.Ogrid.MinimumWidth = 6;
            this.Ogrid.Name = "Ogrid";
            this.Ogrid.Width = 125;
            // 
            // ogrAdDataGridViewTextBoxColumn
            // 
            this.ogrAdDataGridViewTextBoxColumn.DataPropertyName = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.HeaderText = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrAdDataGridViewTextBoxColumn.Name = "ogrAdDataGridViewTextBoxColumn";
            this.ogrAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrSoyadDataGridViewTextBoxColumn
            // 
            this.ogrSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.HeaderText = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrSoyadDataGridViewTextBoxColumn.Name = "ogrSoyadDataGridViewTextBoxColumn";
            this.ogrSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrKalanBorcDataGridViewTextBoxColumn
            // 
            this.ogrKalanBorcDataGridViewTextBoxColumn.DataPropertyName = "OgrKalanBorc";
            this.ogrKalanBorcDataGridViewTextBoxColumn.HeaderText = "OgrKalanBorc";
            this.ogrKalanBorcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrKalanBorcDataGridViewTextBoxColumn.Name = "ogrKalanBorcDataGridViewTextBoxColumn";
            this.ogrKalanBorcDataGridViewTextBoxColumn.Width = 125;
            // 
            // borclarBindingSource1
            // 
            this.borclarBindingSource1.DataMember = "Borclar";
            this.borclarBindingSource1.DataSource = this.yurtKayitDataSet4;
            // 
            // yurtKayitDataSet4
            // 
            this.yurtKayitDataSet4.DataSetName = "YurtKayitDataSet4";
            this.yurtKayitDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Öğrenci id:";
            // 
            // TxtOgrId
            // 
            this.TxtOgrId.Location = new System.Drawing.Point(187, 6);
            this.TxtOgrId.Name = "TxtOgrId";
            this.TxtOgrId.Size = new System.Drawing.Size(195, 32);
            this.TxtOgrId.TabIndex = 2;
            // 
            // TxtOdenen
            // 
            this.TxtOdenen.Location = new System.Drawing.Point(187, 141);
            this.TxtOdenen.Name = "TxtOdenen";
            this.TxtOdenen.Size = new System.Drawing.Size(195, 32);
            this.TxtOdenen.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ödenen:";
            // 
            // TxtKalan
            // 
            this.TxtKalan.Location = new System.Drawing.Point(187, 182);
            this.TxtKalan.Name = "TxtKalan";
            this.TxtKalan.Size = new System.Drawing.Size(195, 32);
            this.TxtKalan.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kalan Borç:";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(214, 258);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(136, 42);
            this.BtnKaydet.TabIndex = 7;
            this.BtnKaydet.Text = "Ödeme Al";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // yurtKayitDataSet3
            // 
            this.yurtKayitDataSet3.DataSetName = "YurtKayitDataSet3";
            this.yurtKayitDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // borclarBindingSource
            // 
            this.borclarBindingSource.DataMember = "Borclar";
            this.borclarBindingSource.DataSource = this.yurtKayitDataSet3;
            // 
            // borclarTableAdapter
            // 
            this.borclarTableAdapter.ClearBeforeFill = true;
            // 
            // borclarTableAdapter1
            // 
            this.borclarTableAdapter1.ClearBeforeFill = true;
            // 
            // TxtOgrAd
            // 
            this.TxtOgrAd.Location = new System.Drawing.Point(187, 51);
            this.TxtOgrAd.Name = "TxtOgrAd";
            this.TxtOgrAd.Size = new System.Drawing.Size(195, 32);
            this.TxtOgrAd.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Öğrenci Ad:";
            // 
            // TxtOgrSoyad
            // 
            this.TxtOgrSoyad.Location = new System.Drawing.Point(187, 97);
            this.TxtOgrSoyad.Name = "TxtOgrSoyad";
            this.TxtOgrSoyad.Size = new System.Drawing.Size(195, 32);
            this.TxtOgrSoyad.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Öğrenci Soyad:";
            // 
            // TxtOdenenAy
            // 
            this.TxtOdenenAy.Location = new System.Drawing.Point(187, 220);
            this.TxtOdenenAy.Name = "TxtOdenenAy";
            this.TxtOdenenAy.Size = new System.Drawing.Size(195, 32);
            this.TxtOdenenAy.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ödenen Ay:";
            // 
            // FrmOdemeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1002, 304);
            this.Controls.Add(this.TxtOdenenAy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtOgrSoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtOgrAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.TxtKalan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtOdenen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtOgrId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOdemeler";
            this.Text = "Ödemeler";
            this.Load += new System.EventHandler(this.FrmOdemeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borclarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayitDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayitDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borclarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtOgrId;
        private System.Windows.Forms.TextBox TxtOdenen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtKalan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnKaydet;
        private YurtKayitDataSet3 yurtKayitDataSet3;
        private System.Windows.Forms.BindingSource borclarBindingSource;
        private YurtKayitDataSet3TableAdapters.BorclarTableAdapter borclarTableAdapter;
        private YurtKayitDataSet4 yurtKayitDataSet4;
        private System.Windows.Forms.BindingSource borclarBindingSource1;
        private YurtKayitDataSet4TableAdapters.BorclarTableAdapter borclarTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ogrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrKalanBorcDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox TxtOgrAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtOgrSoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtOdenenAy;
        private System.Windows.Forms.Label label6;
    }
}