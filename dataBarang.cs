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
    public partial class dataBarang : Form
    {
        config con = new config();
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        string urut;
        int Laba,Harga, biayaProduksi;

        public dataBarang()
        {
            InitializeComponent();
            autoNumber();
            tampilAwal();
        }

        private void tampilAwal()
        {
            try
            {
                adapter = new SqlDataAdapter("SELECT * FROM [dbo].[Table_barang]", con.buka());
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Table_barang");
                dgrDatabarang.DataSource = ds.Tables["Table_barang"].DefaultView;
                dgrDatabarang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                bersih();
                autoNumber();
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
                cmd = new SqlCommand("SELECT Id_barang FROM [dbo].[Table_barang] WHERE Id_barang IN (SELECT MAX (Id_barang) FROM [dbo].[Table_barang]) ORDER BY Id_barang DESC", con.buka());
                reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    hitung = Convert.ToInt64(reader[0].ToString().Substring(reader["Id_barang"].ToString().Length - 4, 4 )) + 1;
                   // MessageBox.Show("Hitung = " + hitung.ToString());
                    string joinstr = "0000" + hitung;
                    urut = "KUE-" + joinstr.Substring(joinstr.Length - 5, 5);
                }
                else
                {
                    urut = "KUE-00001";
                }
                txtIdbarang.Text = urut;
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBaru_Click(object sender, EventArgs e)
        {
            bersih();
            autoNumber();
            
        }
        private void bersih()
        {
            try
            {
                txtCari.Text = "";
                txtHarga.Text = "";
                txtJumlahbarang.Text = "";
                txtNamabarang.Text = "";
                txtSatuan.Text = "";
                txtBiayaproduksi.Text = "";
                txtLaba.Text = "";
                btnSave.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNamabarang.TextLength == 0 || txtJumlahbarang.TextLength == 0 || txtSatuan.TextLength == 0 || txtHarga.TextLength == 0)
            {
                MessageBox.Show("Terdapat kolom yang belum diisi !");
            }
            else
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO [dbo].[Table_barang] VALUES ('" + txtIdbarang.Text + "','" + txtNamabarang.Text + "','" + txtSatuan.Text + "','" + txtJumlahbarang.Text + "','" + txtHarga.Text + "','"+txtBiayaproduksi.Text+ "','" + txtLaba.Text + "')", con.buka());
                    reader = cmd.ExecuteReader();
                    MessageBox.Show("Berhasil Menambahkan Kue !");
                    tampilAwal();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtNamabarang.TextLength == 0 || txtJumlahbarang.TextLength == 0 || txtSatuan.TextLength == 0 || txtHarga.TextLength == 0)
            {
                MessageBox.Show("Terdapat kolom yang belum diisi");
            }
            else
            {
                try
                {
                    cmd = new SqlCommand("UPDATE [dbo].[Table_barang] SET Id_barang = '" + txtIdbarang.Text + "', NamaBarang = '" + txtNamabarang.Text + "', Satuan = '" + txtSatuan.Text + "',Jumlah = '" + txtJumlahbarang.Text + "',Harga_jual = '" + txtHarga.Text + "', Biaya_produksi = '"+txtBiayaproduksi.Text+"', Laba = '"+txtLaba.Text+"' WHERE Id_barang = '"+txtIdbarang.Text+"'", con.buka());
                    reader = cmd.ExecuteReader();
                    MessageBox.Show("Berhasil Mengubah Data !!");
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
            if (txtNamabarang.TextLength == 0 || txtJumlahbarang.TextLength == 0 || txtSatuan.TextLength == 0 || txtHarga.TextLength == 0)
            {
                MessageBox.Show("Belum memilih barang yang akan di hapus !!");
            }
            else
            {
                try
                {
                    cmd = new SqlCommand("DELETE [dbo].[Table_barang] WHERE Id_barang = '" + txtIdbarang.Text + "'", con.buka());
                    reader = cmd.ExecuteReader();
                    MessageBox.Show("Berhasil Menhapus barang");
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
                adapter = new SqlDataAdapter("SELECT * FROM [dbo].[Table_barang] WHERE NamaBarang LIKE '%"+txtCari.Text+"%'", con.buka());
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Table_barang");
                dgrDatabarang.DataSource = ds.Tables["Table_barang"].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBiayaproduksi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtHarga.TextLength == 0 || txtBiayaproduksi.TextLength == 0)
                {

                }
                else
                {
                    Harga = Convert.ToInt32(txtHarga.Text);
                    biayaProduksi = Convert.ToInt32(txtBiayaproduksi.Text);
                    Laba = Harga - biayaProduksi;
                    txtLaba.Text = Convert.ToString(Laba);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgrDatabarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgrDatabarang.Rows[e.RowIndex];
                txtIdbarang.Text = row.Cells["Id_barang"].Value.ToString();
                txtNamabarang.Text = row.Cells["NamaBarang"].Value.ToString();
                txtSatuan.Text = row.Cells["Satuan"].Value.ToString();
                txtJumlahbarang.Text = row.Cells["Jumlah"].Value.ToString();
                txtHarga.Text = row.Cells["Harga_jual"].Value.ToString();
                txtBiayaproduksi.Text = row.Cells["Biaya_produksi"].Value.ToString();
                txtLaba.Text = row.Cells["Laba"].Value.ToString();
                btnSave.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtHarga_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtHarga.TextLength == 0 || txtBiayaproduksi.TextLength == 0)
                {

                }
                else
                {
                    Harga = Convert.ToInt32(txtHarga.Text);
                    biayaProduksi = Convert.ToInt32(txtBiayaproduksi.Text);
                    Laba = Harga - biayaProduksi;
                    txtLaba.Text = Convert.ToString(Laba);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
