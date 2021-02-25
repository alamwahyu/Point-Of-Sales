namespace pointofsale.laporan
{
    partial class LaporanTransaksiPembelian
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
            this.crystalReportViewer_laporanpembelian = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewer_laporanpembelian
            // 
            this.crystalReportViewer_laporanpembelian.ActiveViewIndex = -1;
            this.crystalReportViewer_laporanpembelian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer_laporanpembelian.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer_laporanpembelian.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer_laporanpembelian.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer_laporanpembelian.Name = "crystalReportViewer_laporanpembelian";
            this.crystalReportViewer_laporanpembelian.Size = new System.Drawing.Size(657, 450);
            this.crystalReportViewer_laporanpembelian.TabIndex = 0;
            this.crystalReportViewer_laporanpembelian.Load += new System.EventHandler(this.crystalReportViewer_laporanpembelian_Load);
            // 
            // LaporanTransaksiPembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 450);
            this.Controls.Add(this.crystalReportViewer_laporanpembelian);
            this.Name = "LaporanTransaksiPembelian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LaporanTransaksiPembelian";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer_laporanpembelian;
    }
}