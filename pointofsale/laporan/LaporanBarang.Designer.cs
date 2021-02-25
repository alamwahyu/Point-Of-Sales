namespace pointofsale.laporan
{
    partial class LaporanBarang
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
            this.crystalReportViewer_barang = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewer_barang
            // 
            this.crystalReportViewer_barang.ActiveViewIndex = -1;
            this.crystalReportViewer_barang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer_barang.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer_barang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer_barang.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer_barang.Name = "crystalReportViewer_barang";
            this.crystalReportViewer_barang.Size = new System.Drawing.Size(404, 313);
            this.crystalReportViewer_barang.TabIndex = 0;
            // 
            // LaporanBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 313);
            this.Controls.Add(this.crystalReportViewer_barang);
            this.Name = "LaporanBarang";
            this.Text = "LaporanBarang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer_barang;
    }
}