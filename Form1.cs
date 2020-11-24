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
    public partial class Form1 : Form
    {
        config con = new config();
        utama utama = new utama();
        dataBarang databarang = new dataBarang();
        SqlDataAdapter adapter;
        SqlCommand cmd;
        SqlDataReader reader;
        public static string username, password,nama,Iduser,alamat;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.TextLength == 0 || txtPassword.TextLength == 0)
            {
                MessageBox.Show("Silahkan isi dengan tepat");
            }
            else
            {
                try
                {
                    cmd = new SqlCommand("SELECT * FROM [dbo].[Table_user] WHERE username = '"+txtUsername.Text+"'",con.buka());
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows == true)
                    {
                        while(reader.Read())
                        {
                            username = reader["Username"].ToString();
                            nama = reader["Nama"].ToString();
                            password = reader["Password"].ToString();
                            Iduser = reader["Id_user"].ToString();

                            if (txtPassword.Text == password)
                            {
                                MessageBox.Show("Berhasil Login");
                                this.Hide();
                                utama.Show();
                            }
                            else
                            {
                                MessageBox.Show("Password anda salah");
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("User tidak terdaftar");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public string getId()
        {
            return Iduser;
        }
        public string getUsername()
        {
            return username;
        }
        public string getNama()
        {
            return nama;
        }
        public string getPassword()
        {
            return password;
        }
    }
}
