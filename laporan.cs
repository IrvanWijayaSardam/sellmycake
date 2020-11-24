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
using Microsoft.Office.Interop.Excel;

namespace DuaPutri
{
    public partial class laporan : Form
    {
        config con = new config();
        SqlCommand cmd;
        SqlDataReader reader;
        SqlDataAdapter adapter;
        string idTransaksi;
        int untungTotal;
        public laporan()
        {
            InitializeComponent();
            hapusunpaidDetail();
            tampilAwal();
            totalUntung();
        }

        private void tampilAwal()
        {
            try
            {
                adapter = new SqlDataAdapter("SELECT * FROM [dbo].[vw_cetaktransaksi] ORDER BY Id_jual", con.buka());
                DataSet ds = new DataSet();
                adapter.Fill(ds, "vw_cetaktransaksi");
                dgrLaporan.DataSource = ds.Tables["vw_cetaktransaksi"].DefaultView;
                dgrLaporan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                hapusunpaidDetail();
                dtpCari.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void totalUntung()
        {
            try
            {
                cmd = new SqlCommand("SELECT SUM(TotalLaba) FROM vw_cetaktransaksi", con.buka());
                object a = cmd.ExecuteScalar();
                if (a == null || a is DBNull)
                {
                    untungTotal = 0;
                }
                else
                {
                    untungTotal = Convert.ToInt32(cmd.ExecuteScalar());
                }
                txttotalUntung.Text = Convert.ToString(untungTotal);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                Workbook wb = excel.Workbooks.Add(XlSheetType.xlWorksheet);
                Worksheet ws = (Worksheet)excel.ActiveSheet;
                excel.Visible = true;

                ws.Cells[1, 1] = "Id_jual";
                ws.Cells[1, 2] = "Tanggal";
                ws.Cells[1, 3] = "Id_customer";
                ws.Cells[1, 4] = "Nama";
                ws.Cells[1, 5] = "Alamat";
                ws.Cells[1, 6] = "Id_barang";
                ws.Cells[1, 7] = "Nama barang";
                ws.Cells[1, 8] = "Biaya Produksi";
                ws.Cells[1, 9] = "Harga Jual";
                ws.Cells[1, 10] = "Qty";
                ws.Cells[1, 11] = "Total Bayar";
                ws.Cells[1, 12] = "Angsuran";
                ws.Cells[1, 13] = "Laba";
                ws.Cells[1, 14] = "Total Laba";
                ws.Cells[1, 15] = "Deadline";
                ws.Cells[1, 16] = "Keterangan";
                ws.Cells[1, 17] = "Total Untung";
                for (int j = 2; j < dgrLaporan.Rows.Count; j++)
                {
                    for (int i = 1; i <= 14; i++)
                    {
                        ws.Cells[j, i] = dgrLaporan.Rows[j - 2].Cells[i - 1].Value;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {
                adapter = new SqlDataAdapter("SELECT * FROM [dbo].[vw_cetaktransaksi] WHERE Tanggal LIKE '%" + dtpCari.Text + "%'", con.buka());
                DataSet ds = new DataSet();
                adapter.Fill(ds, "vw_cetaktransaksi");
                dgrLaporan.DataSource = ds.Tables["vw_cetaktransaksi"].DefaultView;
                dgrLaporan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtcariNama_TextChanged(object sender, EventArgs e)
        {
            try
            {
                adapter = new SqlDataAdapter("SELECT * FROM [dbo].[vw_cetaktransaksi] WHERE Nama LIKE '%" + txtcariNama.Text + "%'", con.buka());
                DataSet ds = new DataSet();
                adapter.Fill(ds, "vw_cetaktransaksi");
                dgrLaporan.DataSource = ds.Tables["vw_cetaktransaksi"].DefaultView;
                dgrLaporan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void hapusunpaidDetail()
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM [dbo].[Detail_jual] WHERE Status='Unpaid'", con.buka());
                reader = cmd.ExecuteReader();
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        idTransaksi = reader["Id_jual"].ToString();
                        cmd = new SqlCommand("DELETE FROM [dbo].[Detail_jual] WHERE Id_jual = '" + idTransaksi + "'", con.buka());
                        reader = cmd.ExecuteReader();
                        hapusunpaidHeader();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void hapusunpaidHeader()
        {
            try
            {
                cmd = new SqlCommand("DELETE FROM [dbo].[Header_jual] WHERE Id_jual = '" + idTransaksi + "'", con.buka());
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btntampilSemua_Click(object sender, EventArgs e)
        {
            tampilAwal();
        }
    }
}
