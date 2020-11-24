namespace DuaPutri
{
    partial class transaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(transaksi));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtidTransaksi = new System.Windows.Forms.TextBox();
            this.txtidCustomer = new System.Windows.Forms.TextBox();
            this.txtidBarang = new System.Windows.Forms.TextBox();
            this.dtTanggal = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label_kasir = new System.Windows.Forms.Label();
            this.txtnamaCustomer = new System.Windows.Forms.TextBox();
            this.txtnamaBarang = new System.Windows.Forms.TextBox();
            this.dgrCart = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.richAlamat = new System.Windows.Forms.RichTextBox();
            this.btnCarikonsumen = new System.Windows.Forms.Button();
            this.btnCaribarang = new System.Windows.Forms.Button();
            this.btnBayar = new System.Windows.Forms.Button();
            this.btnnewTransaksi = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Label_kembali = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.label_kembaliStrip = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtjumlahBarang = new System.Windows.Forms.TextBox();
            this.txtHargabarang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHapus = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNominal = new System.Windows.Forms.TextBox();
            this.Label_nominal = new System.Windows.Forms.Label();
            this.btnDP = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrCart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID_Transaksi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Konsumen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cari Barang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kasir";
            // 
            // txtidTransaksi
            // 
            this.txtidTransaksi.Enabled = false;
            this.txtidTransaksi.Location = new System.Drawing.Point(111, 20);
            this.txtidTransaksi.MaxLength = 20;
            this.txtidTransaksi.Name = "txtidTransaksi";
            this.txtidTransaksi.Size = new System.Drawing.Size(129, 20);
            this.txtidTransaksi.TabIndex = 5;
            // 
            // txtidCustomer
            // 
            this.txtidCustomer.Enabled = false;
            this.txtidCustomer.Location = new System.Drawing.Point(112, 58);
            this.txtidCustomer.MaxLength = 10;
            this.txtidCustomer.Name = "txtidCustomer";
            this.txtidCustomer.Size = new System.Drawing.Size(73, 20);
            this.txtidCustomer.TabIndex = 6;
            // 
            // txtidBarang
            // 
            this.txtidBarang.Enabled = false;
            this.txtidBarang.Location = new System.Drawing.Point(111, 97);
            this.txtidBarang.MaxLength = 10;
            this.txtidBarang.Name = "txtidBarang";
            this.txtidBarang.Size = new System.Drawing.Size(73, 20);
            this.txtidBarang.TabIndex = 7;
            // 
            // dtTanggal
            // 
            this.dtTanggal.Location = new System.Drawing.Point(455, 21);
            this.dtTanggal.Name = "dtTanggal";
            this.dtTanggal.Size = new System.Drawing.Size(200, 20);
            this.dtTanggal.TabIndex = 10;
            this.dtTanggal.Value = new System.DateTime(2019, 5, 31, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tanggal";
            // 
            // label_kasir
            // 
            this.label_kasir.AutoSize = true;
            this.label_kasir.Location = new System.Drawing.Point(457, 52);
            this.label_kasir.Name = "label_kasir";
            this.label_kasir.Size = new System.Drawing.Size(10, 13);
            this.label_kasir.TabIndex = 12;
            this.label_kasir.Text = "-";
            // 
            // txtnamaCustomer
            // 
            this.txtnamaCustomer.Location = new System.Drawing.Point(191, 58);
            this.txtnamaCustomer.MaxLength = 20;
            this.txtnamaCustomer.Name = "txtnamaCustomer";
            this.txtnamaCustomer.Size = new System.Drawing.Size(127, 20);
            this.txtnamaCustomer.TabIndex = 13;
            // 
            // txtnamaBarang
            // 
            this.txtnamaBarang.Location = new System.Drawing.Point(191, 97);
            this.txtnamaBarang.MaxLength = 50;
            this.txtnamaBarang.Name = "txtnamaBarang";
            this.txtnamaBarang.Size = new System.Drawing.Size(127, 20);
            this.txtnamaBarang.TabIndex = 14;
            // 
            // dgrCart
            // 
            this.dgrCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrCart.Location = new System.Drawing.Point(12, 191);
            this.dgrCart.Name = "dgrCart";
            this.dgrCart.ReadOnly = true;
            this.dgrCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrCart.Size = new System.Drawing.Size(652, 170);
            this.dgrCart.TabIndex = 15;
            this.dgrCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrCart_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(394, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Alamat";
            // 
            // richAlamat
            // 
            this.richAlamat.Location = new System.Drawing.Point(451, 80);
            this.richAlamat.MaxLength = 100;
            this.richAlamat.Name = "richAlamat";
            this.richAlamat.Size = new System.Drawing.Size(204, 40);
            this.richAlamat.TabIndex = 17;
            this.richAlamat.Text = "";
            // 
            // btnCarikonsumen
            // 
            this.btnCarikonsumen.Location = new System.Drawing.Point(324, 57);
            this.btnCarikonsumen.Name = "btnCarikonsumen";
            this.btnCarikonsumen.Size = new System.Drawing.Size(24, 23);
            this.btnCarikonsumen.TabIndex = 18;
            this.btnCarikonsumen.Text = "+";
            this.btnCarikonsumen.UseVisualStyleBackColor = true;
            this.btnCarikonsumen.Click += new System.EventHandler(this.btnCarikonsumen_Click);
            // 
            // btnCaribarang
            // 
            this.btnCaribarang.Location = new System.Drawing.Point(312, 94);
            this.btnCaribarang.Name = "btnCaribarang";
            this.btnCaribarang.Size = new System.Drawing.Size(24, 23);
            this.btnCaribarang.TabIndex = 19;
            this.btnCaribarang.Text = "+";
            this.btnCaribarang.UseVisualStyleBackColor = true;
            this.btnCaribarang.Click += new System.EventHandler(this.btnCaribarang_Click);
            // 
            // btnBayar
            // 
            this.btnBayar.Enabled = false;
            this.btnBayar.Location = new System.Drawing.Point(16, 117);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(227, 23);
            this.btnBayar.TabIndex = 20;
            this.btnBayar.Text = "Bayar";
            this.btnBayar.UseVisualStyleBackColor = true;
            this.btnBayar.Visible = false;
            this.btnBayar.Click += new System.EventHandler(this.btnBayar_Click);
            // 
            // btnnewTransaksi
            // 
            this.btnnewTransaksi.Location = new System.Drawing.Point(222, 460);
            this.btnnewTransaksi.Name = "btnnewTransaksi";
            this.btnnewTransaksi.Size = new System.Drawing.Size(184, 23);
            this.btnnewTransaksi.TabIndex = 21;
            this.btnnewTransaksi.Text = "Transaksi Baru";
            this.btnnewTransaksi.UseVisualStyleBackColor = true;
            this.btnnewTransaksi.Click += new System.EventHandler(this.btnnewTransaksi_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(222, 491);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(184, 23);
            this.btnBatal.TabIndex = 22;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(425, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(425, 408);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Bayar";
            // 
            // Label_kembali
            // 
            this.Label_kembali.AutoSize = true;
            this.Label_kembali.Location = new System.Drawing.Point(425, 432);
            this.Label_kembali.Name = "Label_kembali";
            this.Label_kembali.Size = new System.Drawing.Size(44, 13);
            this.Label_kembali.TabIndex = 25;
            this.Label_kembali.Text = "Kembali";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Location = new System.Drawing.Point(488, 384);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(10, 13);
            this.label_total.TabIndex = 27;
            this.label_total.Text = "-";
            // 
            // label_kembaliStrip
            // 
            this.label_kembaliStrip.AutoSize = true;
            this.label_kembaliStrip.Location = new System.Drawing.Point(488, 432);
            this.label_kembaliStrip.Name = "label_kembaliStrip";
            this.label_kembaliStrip.Size = new System.Drawing.Size(10, 13);
            this.label_kembaliStrip.TabIndex = 28;
            this.label_kembaliStrip.Text = "-";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtjumlahBarang);
            this.groupBox1.Controls.Add(this.txtHargabarang);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnCaribarang);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 153);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Transaksi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(179, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Jumlah Barang";
            // 
            // txtjumlahBarang
            // 
            this.txtjumlahBarang.Location = new System.Drawing.Point(258, 127);
            this.txtjumlahBarang.Name = "txtjumlahBarang";
            this.txtjumlahBarang.Size = new System.Drawing.Size(48, 20);
            this.txtjumlahBarang.TabIndex = 22;
            // 
            // txtHargabarang
            // 
            this.txtHargabarang.Location = new System.Drawing.Point(99, 127);
            this.txtHargabarang.Name = "txtHargabarang";
            this.txtHargabarang.Size = new System.Drawing.Size(73, 20);
            this.txtHargabarang.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Harga Barang";
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(588, 162);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 30;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNominal);
            this.groupBox2.Controls.Add(this.Label_nominal);
            this.groupBox2.Controls.Add(this.btnDP);
            this.groupBox2.Controls.Add(this.btnCash);
            this.groupBox2.Controls.Add(this.btnBayar);
            this.groupBox2.Location = new System.Drawing.Point(412, 368);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 146);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pembayaran";
            // 
            // txtNominal
            // 
            this.txtNominal.Location = new System.Drawing.Point(79, 88);
            this.txtNominal.Name = "txtNominal";
            this.txtNominal.Size = new System.Drawing.Size(164, 20);
            this.txtNominal.TabIndex = 22;
            this.txtNominal.Visible = false;
            this.txtNominal.TextChanged += new System.EventHandler(this.txtNominal_TextChanged);
            this.txtNominal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNominal_KeyPress);
            // 
            // Label_nominal
            // 
            this.Label_nominal.AutoSize = true;
            this.Label_nominal.Location = new System.Drawing.Point(13, 92);
            this.Label_nominal.Name = "Label_nominal";
            this.Label_nominal.Size = new System.Drawing.Size(45, 13);
            this.Label_nominal.TabIndex = 21;
            this.Label_nominal.Text = "Nominal";
            this.Label_nominal.Visible = false;
            // 
            // btnDP
            // 
            this.btnDP.Location = new System.Drawing.Point(176, 40);
            this.btnDP.Name = "btnDP";
            this.btnDP.Size = new System.Drawing.Size(67, 23);
            this.btnDP.TabIndex = 1;
            this.btnDP.Text = "DP";
            this.btnDP.UseVisualStyleBackColor = true;
            this.btnDP.Click += new System.EventHandler(this.btnDP_Click_1);
            // 
            // btnCash
            // 
            this.btnCash.Location = new System.Drawing.Point(79, 40);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(67, 23);
            this.btnCash.TabIndex = 0;
            this.btnCash.Text = "Cash";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DuaPutri.Properties.Resources.duaputri;
            this.pictureBox1.Location = new System.Drawing.Point(13, 367);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 518);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.label_kembaliStrip);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.Label_kembali);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnnewTransaksi);
            this.Controls.Add(this.btnCarikonsumen);
            this.Controls.Add(this.richAlamat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgrCart);
            this.Controls.Add(this.txtnamaBarang);
            this.Controls.Add(this.txtnamaCustomer);
            this.Controls.Add(this.label_kasir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtTanggal);
            this.Controls.Add(this.txtidBarang);
            this.Controls.Add(this.txtidCustomer);
            this.Controls.Add(this.txtidTransaksi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "transaksi";
            this.Text = "DuaPutri :: Transaksi";
            ((System.ComponentModel.ISupportInitialize)(this.dgrCart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtidTransaksi;
        private System.Windows.Forms.TextBox txtidCustomer;
        private System.Windows.Forms.TextBox txtidBarang;
        private System.Windows.Forms.DateTimePicker dtTanggal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_kasir;
        private System.Windows.Forms.TextBox txtnamaCustomer;
        private System.Windows.Forms.TextBox txtnamaBarang;
        private System.Windows.Forms.DataGridView dgrCart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richAlamat;
        private System.Windows.Forms.Button btnCarikonsumen;
        private System.Windows.Forms.Button btnCaribarang;
        private System.Windows.Forms.Button btnBayar;
        private System.Windows.Forms.Button btnnewTransaksi;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Label_kembali;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label label_kembaliStrip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHargabarang;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtjumlahBarang;
        private System.Windows.Forms.TextBox txtNominal;
        private System.Windows.Forms.Label Label_nominal;
        private System.Windows.Forms.Button btnDP;
        private System.Windows.Forms.Button btnCash;
    }
}