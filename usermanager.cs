using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DuaPutri
{
    public partial class usermanager : Form
    {
        config con = new config();
        Form1 form1 = new Form1();
        SqlCommand cmd;
        SqlDataReader reader;
        public usermanager()
        {
            InitializeComponent();
            tampilAwal();
        }
        private void tampilAwal()
        {
            try
            {
                txtIduser.Text = form1.getId();
                txtNama.Text = form1.getNama();
                txtUsername.Text = form1.getUsername();
                txtPassword.Text = form1.getPassword();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGantipw_Click(object sender, EventArgs e)
        {
            if (btnGantipw.Text == "Ganti Password")
            {
                label_password.Text = "Password Baru";
                label_konfirmasi.Visible = true;
                label_pwLama.Visible = true;
                txtPwlama.Visible = true;
                txtKonpw.Visible = true;
                btnGantipwbawah.Visible = true;
                btnGantipw.Text = "Cancel";
            }
            else
            {
                label_password.Text = "Password";
                label_konfirmasi.Visible = false;
                label_pwLama.Visible = false;
                txtPwlama.Visible = false;
                txtKonpw.Visible = false;
                btnGantipwbawah.Visible = false;
                btnGantipw.Text = "Ganti Password";
            }
        }

        private void btnGantipwbawah_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtKonpw.Text)
            {
                MessageBox.Show("Password konfirmasi yang anda masukkan tidak sama");
            }
            else if (txtPwlama.Text != form1.getPassword())
            {
                MessageBox.Show("Password lama tidak sesuai !");
            }
            else
            {
                try
                {
                    cmd = new SqlCommand("UPDATE [dbo].[Table_user] SET Password = '" + txtKonpw.Text + "' WHERE Id_user = '"+txtIduser.Text+"'", con.buka());
                    reader = cmd.ExecuteReader();
                    MessageBox.Show("Berhasil Mengganti Password");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void bersih()
        {
            txtKonpw.Text = "";
            txtPwlama.Text = "";
            tampilAwal();
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            tampilAwal();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtNama.TextLength == 0 || txtUsername.TextLength == 0)
            {
                MessageBox.Show("Silahkan isi semua kolom dengan benar !");
            }
            else
            {
                try
                {
                    cmd = new SqlCommand("UPDATE [dbo].[Table_user] SET Nama='" + txtNama.Text + "', Username='" + txtUsername.Text + "'", con.buka());
                    reader = cmd.ExecuteReader();
                    MessageBox.Show("Berhasil Mengganti Data !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
