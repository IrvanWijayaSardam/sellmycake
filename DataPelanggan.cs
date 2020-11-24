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
    public partial class DataPelanggan : Form
    {
        config con = new config();
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        string urut;
        
        public DataPelanggan()
        {
            InitializeComponent();
            tampilAwal();
        }
        private void tampilAwal()
        {
            try
            {
                adapter = new SqlDataAdapter("SELECT * FROM [dbo].[Table_customer]", con.buka());
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Table_customer");
                dgrPelanggan.DataSource = ds.Tables["Table_customer"].DefaultView;
                dgrPelanggan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                bersih();
                autoNumber();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void bersih()
        {
            try
            {
                txtidCustomer.Text = "";
                txtNama.Text = "";
                txtTelp.Text = "";
                txtCari.Text = "";
                txtAlamat.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void autoNumber()
        {
            try
            {
                long hitung;
                cmd = new SqlCommand("SELECT Id_customer FROM [dbo].[Table_customer] WHERE Id_customer IN (SELECT MAX (Id_customer) FROM [dbo].[Table_customer]) ORDER BY Id_customer DESC", con.buka());
                reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    hitung = Convert.ToInt64(reader[0].ToString().Substring(reader["Id_customer"].ToString().Length - 4, 4)) + 1;
                    string joinstr = "0000" + hitung;
                    urut = "CUS-" + joinstr.Substring(joinstr.Length - 5, 5);
                }
                else
                {
                    urut = "CUS-00001";
                }
                txtidCustomer.Text = urut;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgrPelanggan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgrPelanggan.Rows[e.RowIndex];
                txtNama.Text = row.Cells["Nama"].Value.ToString();
                txtidCustomer.Text = row.Cells["Id_customer"].Value.ToString();
                txtAlamat.Text = row.Cells["Alamat"].Value.ToString();
                txtTelp.Text = row.Cells["Telp"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBaru_Click(object sender, EventArgs e)
        {
            tampilAwal();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtidCustomer.TextLength == 0 || txtNama.TextLength == 0 || txtTelp.TextLength == 0)
            {
                MessageBox.Show("Terdapat kolom yang belum diisi");
            }
            else
            {
                try
                {
                    cmd = new SqlCommand("UPDATE [dbo].[Table_customer] SET Nama = '" + txtNama.Text + "', Alamat ='" + txtAlamat.Text + "',Telp = '" + txtTelp.Text + "' WHERE Id_customer = '" + txtidCustomer.Text + "'", con.buka());
                    reader = cmd.ExecuteReader();
                    MessageBox.Show("Berhasil mengubah data !!");
                    tampilAwal();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtidCustomer.TextLength == 0 || txtNama.TextLength == 0 || txtTelp.TextLength == 0)
            {
                MessageBox.Show("Terdapat kolom yang belum diisi");
            }
            else
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO [dbo].[Table_customer] VALUES ('" + txtidCustomer.Text + "','" + txtNama.Text + "','" + txtAlamat.Text + "','" + txtTelp.Text + "')", con.buka());
                    reader = cmd.ExecuteReader();
                    MessageBox.Show("Berhasil menambahkan pelanggan baru !");
                    tampilAwal();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtidCustomer.Text == urut)
            {
                MessageBox.Show("Belum ada user dengan IdTersebut ");
            }
            else
            {
                try
                {
                    cmd = new SqlCommand("DELETE [dbo].[Table_customer] WHERE Id_customer = '" + txtidCustomer.Text + "'", con.buka());
                    reader = cmd.ExecuteReader();
                    MessageBox.Show("Berhasil menghapus pelanggan");
                    tampilAwal();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                adapter = new SqlDataAdapter("SELECT * FROM [dbo].[Table_customer] WHERE nama LIKE '%"+txtCari.Text+"%'", con.buka());
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Table_customer");
                dgrPelanggan.DataSource = ds.Tables["Table_customer"].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
