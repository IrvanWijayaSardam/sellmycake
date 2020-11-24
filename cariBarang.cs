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
    public partial class cariBarang : Form
    {
        config con = new config();
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        public static string idBarang, namaBarang, satuan, jumlah, hargaJual;

        private void dgrBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgrBarang.Rows[e.RowIndex];
                idBarang = row.Cells["Id_barang"].Value.ToString();
                namaBarang = row.Cells["NamaBarang"].Value.ToString();
                satuan = row.Cells["Satuan"].Value.ToString();
                hargaJual = row.Cells["Harga_jual"].Value.ToString();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public cariBarang()
        {
            InitializeComponent();
            tampilAwal();
        }

        private void tampilAwal()
        {
            try
            {
                adapter = new SqlDataAdapter("SELECT * FROM [dbo].[Table_barang]", con.buka());
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Table_barang");
                dgrBarang.DataSource = ds.Tables["Table_barang"].DefaultView;
                dgrBarang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                adapter = new SqlDataAdapter("SELECT * FROM [dbo].[Table_barang] WHERE NamaBarang LIKE '%" + txtCari.Text + "%'", con.buka());
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Table_barang");
                dgrBarang.DataSource = ds.Tables["Table_barang"];
                dgrBarang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string getidBarang()
        {
            return idBarang;
        }
        public string getnamaBarang()
        {
            return namaBarang;
        }
        public string getJumlah()
        {
            return jumlah;
        }

        public string getHarga()
        {
            return hargaJual;
        }
    }
}
