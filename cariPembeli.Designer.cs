namespace DuaPutri
{
    partial class cariPembeli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cariPembeli));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.dgrCustomer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgrCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari Pembeli";
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(85, 9);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(240, 20);
            this.txtCari.TabIndex = 1;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // dgrCustomer
            // 
            this.dgrCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrCustomer.Location = new System.Drawing.Point(12, 35);
            this.dgrCustomer.Name = "dgrCustomer";
            this.dgrCustomer.ReadOnly = true;
            this.dgrCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrCustomer.Size = new System.Drawing.Size(640, 254);
            this.dgrCustomer.TabIndex = 2;
            this.dgrCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrCustomer_CellClick);
            // 
            // cariPembeli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 307);
            this.Controls.Add(this.dgrCustomer);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cariPembeli";
            this.Text = "DuaPutri :: Data Pembeli";
            ((System.ComponentModel.ISupportInitialize)(this.dgrCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.DataGridView dgrCustomer;
    }
}