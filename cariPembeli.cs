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
    public partial class cariPembeli : Form
    {
        config con = new config();
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        public static string nama, idPelanggan, alamat, noTelp;

        private void dgrCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgrCustomer.Rows[e.RowIndex];
                idPelanggan = row.Cells["Id_customer"].Value.ToString();
                nama = row.Cells["Nama"].Value.ToString();
                alamat = row.Cells["Alamat"].Value.ToString();
                noTelp = row.Cells["Telp"].Value.ToString();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public cariPembeli()
        {
            InitializeComponent();
            tampilAwal();
        }

        public void tampilAwal()
        {
            try
            {
                adapter = new SqlDataAdapter("SELECT * FROM [dbo].[Table_customer]", con.buka());
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Table_customer");
                dgrCustomer.DataSource = ds.Tables["Table_customer"].DefaultView;
                dgrCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string getId()
        {
            return idPelanggan;
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                adapter = new SqlDataAdapter("SELECT * FROM [dbo].[Table_customer] WHERE Nama LIKE '%" + txtCari.Text + "%'", con.buka());
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Table_customer");
                dgrCustomer.DataSource = ds.Tables["Table_customer"].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string getNama()
        {
            return nama;
        }

        public string getAlamat()
        {
            return alamat;
        }

        public string getTelp()
        {
            return noTelp;
        }
        
    }
}
