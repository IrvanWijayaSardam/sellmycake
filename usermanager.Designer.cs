namespace DuaPutri
{
    partial class usermanager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usermanager));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.txtIduser = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnGantipw = new System.Windows.Forms.Button();
            this.label_konfirmasi = new System.Windows.Forms.Label();
            this.txtKonpw = new System.Windows.Forms.TextBox();
            this.txtPwlama = new System.Windows.Forms.TextBox();
            this.label_pwLama = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPassword = new System.Windows.Forms.Button();
            this.btnGantipwbawah = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID_User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(14, 98);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(53, 13);
            this.label_password.TabIndex = 3;
            this.label_password.Text = "Password";
            // 
            // txtIduser
            // 
            this.txtIduser.Enabled = false;
            this.txtIduser.Location = new System.Drawing.Point(125, 12);
            this.txtIduser.Name = "txtIduser";
            this.txtIduser.Size = new System.Drawing.Size(100, 20);
            this.txtIduser.TabIndex = 4;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(125, 42);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(179, 20);
            this.txtNama.TabIndex = 5;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(125, 69);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(179, 20);
            this.txtUsername.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(125, 96);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(179, 20);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnGantipw
            // 
            this.btnGantipw.Location = new System.Drawing.Point(310, 96);
            this.btnGantipw.Name = "btnGantipw";
            this.btnGantipw.Size = new System.Drawing.Size(92, 23);
            this.btnGantipw.TabIndex = 8;
            this.btnGantipw.Text = "Ganti Password";
            this.btnGantipw.UseVisualStyleBackColor = true;
            this.btnGantipw.Click += new System.EventHandler(this.btnGantipw_Click);
            // 
            // label_konfirmasi
            // 
            this.label_konfirmasi.AutoSize = true;
            this.label_konfirmasi.Location = new System.Drawing.Point(14, 125);
            this.label_konfirmasi.Name = "label_konfirmasi";
            this.label_konfirmasi.Size = new System.Drawing.Size(104, 13);
            this.label_konfirmasi.TabIndex = 9;
            this.label_konfirmasi.Text = "Konfirmasi Password";
            this.label_konfirmasi.Visible = false;
            // 
            // txtKonpw
            // 
            this.txtKonpw.Location = new System.Drawing.Point(125, 123);
            this.txtKonpw.Name = "txtKonpw";
            this.txtKonpw.Size = new System.Drawing.Size(177, 20);
            this.txtKonpw.TabIndex = 10;
            this.txtKonpw.UseSystemPasswordChar = true;
            this.txtKonpw.Visible = false;
            // 
            // txtPwlama
            // 
            this.txtPwlama.Location = new System.Drawing.Point(125, 150);
            this.txtPwlama.Name = "txtPwlama";
            this.txtPwlama.Size = new System.Drawing.Size(100, 20);
            this.txtPwlama.TabIndex = 11;
            this.txtPwlama.UseSystemPasswordChar = true;
            this.txtPwlama.Visible = false;
            // 
            // label_pwLama
            // 
            this.label_pwLama.AutoSize = true;
            this.label_pwLama.Location = new System.Drawing.Point(14, 151);
            this.label_pwLama.Name = "label_pwLama";
            this.label_pwLama.Size = new System.Drawing.Size(82, 13);
            this.label_pwLama.TabIndex = 12;
            this.label_pwLama.Text = "Password Lama";
            this.label_pwLama.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(125, 177);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPassword
            // 
            this.btnPassword.Location = new System.Drawing.Point(223, 177);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(75, 23);
            this.btnPassword.TabIndex = 14;
            this.btnPassword.Text = "Cancel";
            this.btnPassword.UseVisualStyleBackColor = true;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // btnGantipwbawah
            // 
            this.btnGantipwbawah.Location = new System.Drawing.Point(310, 122);
            this.btnGantipwbawah.Name = "btnGantipwbawah";
            this.btnGantipwbawah.Size = new System.Drawing.Size(92, 23);
            this.btnGantipwbawah.TabIndex = 15;
            this.btnGantipwbawah.Text = "Ganti Password";
            this.btnGantipwbawah.UseVisualStyleBackColor = true;
            this.btnGantipwbawah.Visible = false;
            this.btnGantipwbawah.Click += new System.EventHandler(this.btnGantipwbawah_Click);
            // 
            // usermanager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 209);
            this.Controls.Add(this.btnGantipwbawah);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label_pwLama);
            this.Controls.Add(this.txtPwlama);
            this.Controls.Add(this.txtKonpw);
            this.Controls.Add(this.label_konfirmasi);
            this.Controls.Add(this.btnGantipw);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtIduser);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "usermanager";
            this.Text = "DuaPutri :: Kelola User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox txtIduser;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnGantipw;
        private System.Windows.Forms.Label label_konfirmasi;
        private System.Windows.Forms.TextBox txtKonpw;
        private System.Windows.Forms.TextBox txtPwlama;
        private System.Windows.Forms.Label label_pwLama;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPassword;
        private System.Windows.Forms.Button btnGantipwbawah;
    }
}