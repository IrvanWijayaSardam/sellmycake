namespace DuaPutri
{
    partial class laporan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(laporan));
            this.label1 = new System.Windows.Forms.Label();
            this.dtpCari = new System.Windows.Forms.DateTimePicker();
            this.btnCari = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.dgrLaporan = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcariNama = new System.Windows.Forms.TextBox();
            this.btntampilSemua = new System.Windows.Forms.Button();
            this.txttotalUntung = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrLaporan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tanggal";
            // 
            // dtpCari
            // 
            this.dtpCari.CustomFormat = "yyyy-MM-dd";
            this.dtpCari.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCari.Location = new System.Drawing.Point(64, 14);
            this.dtpCari.Name = "dtpCari";
            this.dtpCari.Size = new System.Drawing.Size(150, 20);
            this.dtpCari.TabIndex = 1;
            this.dtpCari.Value = new System.DateTime(2019, 5, 4, 0, 0, 0, 0);
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(221, 13);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(75, 23);
            this.btnCari.TabIndex = 2;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(1265, 13);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(92, 23);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export To Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // dgrLaporan
            // 
            this.dgrLaporan.AllowUserToAddRows = false;
            this.dgrLaporan.AllowUserToDeleteRows = false;
            this.dgrLaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrLaporan.Location = new System.Drawing.Point(16, 50);
            this.dgrLaporan.Name = "dgrLaporan";
            this.dgrLaporan.ReadOnly = true;
            this.dgrLaporan.Size = new System.Drawing.Size(1342, 533);
            this.dgrLaporan.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nama";
            // 
            // txtcariNama
            // 
            this.txtcariNama.Location = new System.Drawing.Point(350, 14);
            this.txtcariNama.Name = "txtcariNama";
            this.txtcariNama.Size = new System.Drawing.Size(100, 20);
            this.txtcariNama.TabIndex = 6;
            this.txtcariNama.TextChanged += new System.EventHandler(this.txtcariNama_TextChanged);
            // 
            // btntampilSemua
            // 
            this.btntampilSemua.Location = new System.Drawing.Point(1157, 14);
            this.btntampilSemua.Name = "btntampilSemua";
            this.btntampilSemua.Size = new System.Drawing.Size(102, 23);
            this.btntampilSemua.TabIndex = 7;
            this.btntampilSemua.Text = "Tampilkan Semua";
            this.btntampilSemua.UseVisualStyleBackColor = true;
            this.btntampilSemua.Click += new System.EventHandler(this.btntampilSemua_Click);
            // 
            // txttotalUntung
            // 
            this.txttotalUntung.Location = new System.Drawing.Point(1227, 589);
            this.txttotalUntung.Name = "txttotalUntung";
            this.txttotalUntung.Size = new System.Drawing.Size(131, 20);
            this.txttotalUntung.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1155, 592);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total Untung";
            // 
            // laporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 614);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttotalUntung);
            this.Controls.Add(this.btntampilSemua);
            this.Controls.Add(this.txtcariNama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgrLaporan);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.dtpCari);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "laporan";
            this.Text = "DuaPutri :: Laporan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgrLaporan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpCari;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridView dgrLaporan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcariNama;
        private System.Windows.Forms.Button btntampilSemua;
        private System.Windows.Forms.TextBox txttotalUntung;
        private System.Windows.Forms.Label label3;
    }
}