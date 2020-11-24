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
    public partial class transaksi : Form
    {
        config con = new config();
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        string idTransaksi,namaBarang,idBarang,hargaBarang,subtotal;
        int hasil,kembalian, kembalianPlus;
        public transaksi()
        {
            InitializeComponent();
            autoFaktur();
        }

        private void showCart()
        {
            try
            {
                adapter = new SqlDataAdapter("SELECT Id_jual,Id_barang,NamaBarang,Satuan,Harga_jual,Qty FROM [dbo].[vw_detail] WHERE Id_jual = '"+txtidTransaksi.Text+"'", con.buka());
                DataSet ds = new DataSet();
                adapter.Fill(ds, "vw_penjualan");
                dgrCart.DataSource = ds.Tables["vw_penjualan"].DefaultView;
                dgrCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtTanggal.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void autoFaktur()
        {
            long hitung;
            cmd = new SqlCommand("SELECT Id_jual FROM [dbo].[Detail_jual] WHERE Id_jual IN (SELECT MAX (Id_jual) FROM [dbo].[Detail_jual]) ORDER BY Id_jual DESC",con.buka());
            reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                hitung = Convert.ToInt64(reader[0].ToString().Substring(reader["Id_jual"].ToString().Length - 12, 4)) + 1;
                string joinstr = "0000" + hitung;
                idTransaksi = "TRX-" + joinstr.Substring(joinstr.Length - 4, 4) + "/" + DateTime.Now.ToString("MM/yyyy");
            }
            else
            {
                idTransaksi = "TRX-0001/" + DateTime.Now.ToString("MM/yyyy");
            }
            txtidTransaksi.Text = idTransaksi;
        }

        private void btnCarikonsumen_Click(object sender, EventArgs e)
        {
            cariPembeli pem = new cariPembeli();
            pem.ShowDialog();
            txtidCustomer.Text = pem.getId();
            txtnamaCustomer.Text = pem.getNama();
            richAlamat.Text = pem.getAlamat();
        }

        private void btnCaribarang_Click(object sender, EventArgs e)
        {
            cariBarang bar = new cariBarang();
            bar.ShowDialog();
            txtHargabarang.Text = bar.getHarga();
            txtidBarang.Text = bar.getidBarang();
            txtjumlahBarang.Text = bar.getJumlah();
            txtnamaBarang.Text = bar.getnamaBarang();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                subTotal();
                cmd = new SqlCommand("SELECT * FROM [dbo].[Detail_jual] WHERE Id_jual = '" + txtidTransaksi.Text + "'", con.buka());
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    simpanDetailPenjualan();
                }
                else
                {
                    simpanDetailPenjualan();
                    simpanHeaderjual();
                }
                showCart();
                totalBayar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void simpanDetailPenjualan()
        {
            if (txtidBarang.TextLength == 0 || txtidCustomer.TextLength == 0 || txtjumlahBarang.TextLength == 0 || txtnamaBarang.TextLength == 0 || txtnamaCustomer.TextLength == 0) 
                {
                    MessageBox.Show("Terdapat data yang belum diisi");
                }
            else
            {
                    try
                    {
                        cmd = new SqlCommand("INSERT INTO [dbo].[Detail_jual] (Id_jual,Id_barang,Qty,Disc,Subtotal,Id_customer,Angsuran,Alamat,Status) VALUES ('" + txtidTransaksi.Text + "','" + txtidBarang.Text + "','" + txtjumlahBarang.Text + "','0','" + subtotal + "','" + txtidCustomer.Text + "','0','"+richAlamat.Text+"','Unpaid')", con.buka());
                        reader = cmd.ExecuteReader();
                        showCart();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
            }
        }

        private void simpanHeaderjual()
        {
            if (txtidBarang.TextLength == 0 || txtidCustomer.TextLength == 0 || txtjumlahBarang.TextLength == 0 || txtnamaBarang.TextLength == 0 || txtnamaCustomer.TextLength == 0)
            {
                MessageBox.Show("Terdapat data yang belum diisi");
            }
            else
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO [dbo].[Header_jual] VALUES ('" + txtidTransaksi.Text + "','" + dtTanggal.Text + "','" + txtidCustomer.Text + "','" + txtjumlahBarang.Text + "','0')", con.buka());
                    reader = cmd.ExecuteReader();
                    showCart();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnCash_Click_1(object sender, EventArgs e)
        {
            if (btnCash.Text == "Cash")
            {
                btnCash.Text = "Cancel";
                txtNominal.Visible = true;
                Label_nominal.Visible = true;
                btnBayar.Visible = true;
            }
            else
            {
                btnCash.Text = "Cash";
                txtNominal.Visible = false;
                Label_nominal.Visible = false;
                btnBayar.Visible = false;
            }
        }

        private void btnDP_Click_1(object sender, EventArgs e)
        {
            if (btnDP.Text == "DP")
            {
                btnDP.Text = "Cancel";
                Label_kembali.Text = "Angsuran";
                txtNominal.Visible = true;
                Label_nominal.Visible = true;
                btnBayar.Visible = true;
                Label_kembali.Visible = true;
                label_kembaliStrip.Visible = true;
            }
            else
            {
                btnDP.Text = "DP";
                Label_kembali.Text = "Kembali";
                txtNominal.Visible = false;
                Label_nominal.Visible = false;
                btnBayar.Visible = false;
            }
        }

        private void txtNominal_TextChanged(object sender, EventArgs e)
        {
            if (btnCash.Text == "Cancel")
            {
                btnBayar.Enabled = true;
                if (txtNominal.TextLength == 0)
                {
                    label_kembaliStrip.Text = "0";
                }
                else
                {
                    int bayar;
                    if (Int32.TryParse(txtNominal.Text, out bayar))
                    {
                        kembalian = bayar - hasil;
                        label_kembaliStrip.Text = kembalian.ToString();
                        if (kembalian >= 0)
                        {
                            txtNominal.Focus();
                            btnBayar.Enabled = true;
                        }
                        else if (kembalian < 0)
                        {
                            btnBayar.Enabled = false;
                        }
                    }
                }
            }
            else if (btnDP.Text == "Cancel")
            {
                btnBayar.Enabled = true;
                if (txtNominal.TextLength == 0)
                {
                    label_kembaliStrip.Text = "0";
                }
                else
                {
                    int bayar;
                    if (Int32.TryParse(txtNominal.Text, out bayar))
                    {
                        kembalian = bayar - hasil;
                        kembalianPlus = Math.Abs(kembalian);
                        label_kembaliStrip.Text = kembalianPlus.ToString();
                        if (kembalian >= 0)
                        {
                            txtNominal.Focus();
                            btnBayar.Enabled = true;
                        }
                        else if (kembalian < 0)
                        {
                            btnBayar.Enabled = true;
                        }
                    }
                }
            }
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            if (btnCash.Text == "Cancel")
            {
                bayarCash();
            }
            else
            {
                bayarAngsuran();
            }
        }

        private void bayarCash()
        {
            try
            {
                cmd = new SqlCommand("UPDATE [dbo].[Detail_jual] SET subtotal='" + label_total.Text + "' ,Angsuran = '0', Status = 'Paid'  WHERE Id_jual = '"+txtidTransaksi.Text+"'", con.buka());
                reader = cmd.ExecuteReader();
                MessageBox.Show("Berhasil melakukan pembayaran langsung !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bayarAngsuran()
        {
            try
            {
                //string labelkembalistripPlus = label_kembaliStrip.Text;
                //int labelkembaliintplus = Convert.ToInt32(labelkembalistripPlus);
                //int labelKembali = Math.Abs(labelkembaliintplus);
                cmd = new SqlCommand("UPDATE [dbo].[Detail_jual] SET Angsuran ='" + label_kembaliStrip.Text + "', Status = 'Paid' WHERE Id_jual = '"+txtidTransaksi.Text+"'", con.buka());
                reader = cmd.ExecuteReader();
                updateheaderAngsuran();
                MessageBox.Show("Berhasil melakukan pembayaran secara Angsuran !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateheaderAngsuran()
        {
            try
            {
                cmd = new SqlCommand("UPDATE [dbo].[Header_jual] SET Angsuran ='" + label_kembaliStrip.Text + "' WHERE Id_jual = '" + txtidTransaksi.Text + "'", con.buka());
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnnewTransaksi_Click(object sender, EventArgs e)
        {
            tampilAwal();
            showCart();
        }

        private void tampilAwal()
        {
            autoFaktur();
            bersih();
            dtTanggal.Value = DateTime.Now;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Jika anda membatalkan pesanan maka semua barang yang ada pada keranjang akan terhapus ","Batalkan Pesanan",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                deleteTransaksi();
                tampilAwal();
                showCart();
                MessageBox.Show("Berhasil membatalkan transaksi !");
            }
        }

        private void bersih()
        {
            txtidCustomer.Text = "";
            txtnamaCustomer.Text = "";
            txtidBarang.Text = "";
            txtnamaBarang.Text = "";
            txtHargabarang.Text = "";
            txtjumlahBarang.Text = "";
            richAlamat.Text = "";
            txtNominal.Text = "0";
            txtNominal.Visible = false;
            Label_nominal.Visible = false;
            btnBayar.Visible = false;
            btnCash.Text = "Cash";
            Label_kembali.Visible = false;
            label_kembaliStrip.Visible = false;
            label_kembaliStrip.Text = "0";
            label_total.Text = "0";
            btnDP.Text = "DP";
            btnCash.Text = "Cash";
        }

        private void deleteTransaksi()
        {
            deletetransaksiDetail();
            deletetransaksiHeader();
        }

        private void deletetransaksiDetail()
        {
            try
            {
                cmd = new SqlCommand("DELETE FROM [dbo].[Detail_jual] WHERE Id_jual = '" + txtidTransaksi.Text + "'", con.buka());
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deletetransaksiHeader()
        {
            try
            {
                cmd = new SqlCommand("DELETE FROM [dbo].[Header_jual] WHERE Id_jual = '" + txtidTransaksi.Text + "'", con.buka());
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void subTotal()
        {
            try
            {
                int hargaAwal = Convert.ToInt32(txtHargabarang.Text);
                int jumlahBarang = Convert.ToInt32(txtjumlahBarang.Text);
                int subtotalInt = hargaAwal * jumlahBarang;
                subtotal = subtotalInt.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtNominal_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void totalBayar()
        {
            try
            {
                cmd = new SqlCommand("SELECT SUM(Subtotal) FROM [dbo].[vw_detail] WHERE Id_jual='" + txtidTransaksi.Text + "'", con.buka());
                object a = cmd.ExecuteScalar();
                if (a == null || a is DBNull)
                {
                    hasil = 0;
                }
                else
                {
                    hasil = Convert.ToInt32(cmd.ExecuteScalar());
                }
                string totalBayar = hasil.ToString();
                label_total.Text = totalBayar;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (txtidBarang.TextLength == 0 )
            {
                MessageBox.Show("Belum memilih barang yang akan dihapus !");
            }

            else
            {
                try
                {
                    cmd = new SqlCommand("DELETE FROM [dbo].[Detail_jual] WHERE Id_jual = '" + txtidTransaksi.Text + "' AND Id_barang = '" + txtidBarang.Text + "'", con.buka());
                    reader = cmd.ExecuteReader();
                    showCart();
                    totalBayar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgrCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgrCart.Rows[e.RowIndex];
                idBarang = row.Cells["Id_barang"].Value.ToString();
                namaBarang = row.Cells["NamaBarang"].Value.ToString();
                hargaBarang = row.Cells["Harga_jual"].Value.ToString();
                txtidBarang.Text = idBarang;
                txtnamaBarang.Text = namaBarang;
                txtHargabarang.Text = hargaBarang;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
