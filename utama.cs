using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuaPutri
{
    public partial class utama : Form
    {
        private int childFormNumber = 0;
        usermanager usermanager;
        dataBarang databarang;
        DataPelanggan dataPelanggan;
        transaksi transaksi;
        laporan laporan;

        public utama()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void kelolaUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usermanager == null)
            {
                usermanager = new usermanager();
                usermanager.MdiParent = this.MdiParent;
                usermanager.FormClosed += new FormClosedEventHandler (Usermanager_FormClosed);
                usermanager.Show();
            }
            else
            {
                usermanager.Activate();
            }
        }

        private void Usermanager_FormClosed(object sender, FormClosedEventArgs e)
        {
            usermanager = null;
        }

        private void dataBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (databarang == null)
            {
                databarang = new dataBarang();
                databarang.MdiParent = this.MdiParent;
                databarang.FormClosed += new FormClosedEventHandler (Databarang_FormClosed);
                databarang.Show();
            }
            else
            {
                databarang.Activate();
            }
        }

        private void Databarang_FormClosed(object sender, FormClosedEventArgs e)
        {
            databarang = null;
        }

        private void kelolaPelangganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataPelanggan == null)
            {
                DataPelanggan dataPelanggan = new DataPelanggan();
                dataPelanggan.MdiParent = this.MdiParent;
                dataPelanggan.FormClosed += new FormClosedEventHandler (DataPelanggan_FormClosed);
                dataPelanggan.Show();
            }
            else
            {
                dataPelanggan.Activate();
            }
        }

        private void DataPelanggan_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataPelanggan = null;
        }

        private void transaksiLangsungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (transaksi == null)
            {
                transaksi transaksi = new transaksi();
                transaksi.MdiParent = this.MdiParent;
                transaksi.FormClosed += new FormClosedEventHandler (Transaksi_FormClosed);
                transaksi.Show();
            }
            else
            {
                transaksi.Activate();
            }
        }

        private void Transaksi_FormClosed(object sender, FormClosedEventArgs e)
        {
            transaksi = null;
        }

        private void laporanPenjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (laporan == null)
            {
                laporan laporan = new laporan();
                laporan.MdiParent = this;
                laporan.FormClosed += new FormClosedEventHandler (Laporan_FormClosed);
                laporan.Show();
            }
            else
            {
                laporan.Activate();
            }
        }

        private void Laporan_FormClosed(object sender, FormClosedEventArgs e)
        {
            laporan = null;
        }
    }
}
