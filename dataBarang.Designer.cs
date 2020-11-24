namespace DuaPutri
{
    partial class dataBarang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dataBarang));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdbarang = new System.Windows.Forms.TextBox();
            this.txtNamabarang = new System.Windows.Forms.TextBox();
            this.txtJumlahbarang = new System.Windows.Forms.TextBox();
            this.txtSatuan = new System.Windows.Forms.TextBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgrDatabarang = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBaru = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBiayaproduksi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLaba = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDatabarang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id_barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jumlah Barang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Satuan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Harga_jual";
            // 
            // txtIdbarang
            // 
            this.txtIdbarang.Enabled = false;
            this.txtIdbarang.Location = new System.Drawing.Point(93, 17);
            this.txtIdbarang.Name = "txtIdbarang";
            this.txtIdbarang.Size = new System.Drawing.Size(100, 20);
            this.txtIdbarang.TabIndex = 5;
            // 
            // txtNamabarang
            // 
            this.txtNamabarang.Location = new System.Drawing.Point(93, 44);
            this.txtNamabarang.Name = "txtNamabarang";
            this.txtNamabarang.Size = new System.Drawing.Size(139, 20);
            this.txtNamabarang.TabIndex = 6;
            // 
            // txtJumlahbarang
            // 
            this.txtJumlahbarang.Location = new System.Drawing.Point(93, 68);
            this.txtJumlahbarang.Name = "txtJumlahbarang";
            this.txtJumlahbarang.Size = new System.Drawing.Size(37, 20);
            this.txtJumlahbarang.TabIndex = 7;
            // 
            // txtSatuan
            // 
            this.txtSatuan.Location = new System.Drawing.Point(179, 69);
            this.txtSatuan.Name = "txtSatuan";
            this.txtSatuan.Size = new System.Drawing.Size(53, 20);
            this.txtSatuan.TabIndex = 8;
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(329, 17);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(139, 20);
            this.txtHarga.TabIndex = 9;
            this.txtHarga.TextChanged += new System.EventHandler(this.txtHarga_TextChanged);
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(502, 125);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(225, 20);
            this.txtCari.TabIndex = 11;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(461, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cari";
            // 
            // dgrDatabarang
            // 
            this.dgrDatabarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrDatabarang.Location = new System.Drawing.Point(11, 151);
            this.dgrDatabarang.Name = "dgrDatabarang";
            this.dgrDatabarang.ReadOnly = true;
            this.dgrDatabarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrDatabarang.Size = new System.Drawing.Size(716, 272);
            this.dgrDatabarang.TabIndex = 12;
            this.dgrDatabarang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrDatabarang_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DuaPutri.Properties.Resources.duaputri;
            this.pictureBox1.Location = new System.Drawing.Point(502, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnBaru
            // 
            this.btnBaru.Location = new System.Drawing.Point(18, 118);
            this.btnBaru.Name = "btnBaru";
            this.btnBaru.Size = new System.Drawing.Size(75, 23);
            this.btnBaru.TabIndex = 14;
            this.btnBaru.Text = "Baru";
            this.btnBaru.UseVisualStyleBackColor = true;
            this.btnBaru.Click += new System.EventHandler(this.btnBaru_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(100, 118);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(186, 118);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Hapus";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(268, 118);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(254, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Biaya Produksi";
            // 
            // txtBiayaproduksi
            // 
            this.txtBiayaproduksi.Location = new System.Drawing.Point(329, 42);
            this.txtBiayaproduksi.Name = "txtBiayaproduksi";
            this.txtBiayaproduksi.Size = new System.Drawing.Size(139, 20);
            this.txtBiayaproduksi.TabIndex = 10;
            this.txtBiayaproduksi.TextChanged += new System.EventHandler(this.txtBiayaproduksi_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(254, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Laba";
            // 
            // txtLaba
            // 
            this.txtLaba.Location = new System.Drawing.Point(329, 69);
            this.txtLaba.Name = "txtLaba";
            this.txtLaba.Size = new System.Drawing.Size(139, 20);
            this.txtLaba.TabIndex = 20;
            // 
            // dataBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 434);
            this.Controls.Add(this.txtLaba);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBiayaproduksi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnBaru);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgrDatabarang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.txtSatuan);
            this.Controls.Add(this.txtJumlahbarang);
            this.Controls.Add(this.txtNamabarang);
            this.Controls.Add(this.txtIdbarang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dataBarang";
            this.Text = "DuaPutri :: Data Barang";
            ((System.ComponentModel.ISupportInitialize)(this.dgrDatabarang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdbarang;
        private System.Windows.Forms.TextBox txtNamabarang;
        private System.Windows.Forms.TextBox txtJumlahbarang;
        private System.Windows.Forms.TextBox txtSatuan;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgrDatabarang;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBaru;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBiayaproduksi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLaba;
    }
}