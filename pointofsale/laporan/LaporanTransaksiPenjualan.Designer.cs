namespace pointofsale.laporan
{
    partial class LaporanTransaksiPenjualan
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
            this.crystalReportViewer_transaksipenjualan = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewer_transaksipenjualan
            // 
            this.crystalReportViewer_transaksipenjualan.ActiveViewIndex = -1;
            this.crystalReportViewer_transaksipenjualan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer_transaksipenjualan.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer_transaksipenjualan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer_transaksipenjualan.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer_transaksipenjualan.Name = "crystalReportViewer_transaksipenjualan";
            this.crystalReportViewer_transaksipenjualan.Size = new System.Drawing.Size(863, 479);
            this.crystalReportViewer_transaksipenjualan.TabIndex = 0;
            // 
            // LaporanTransaksiPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 479);
            this.Controls.Add(this.crystalReportViewer_transaksipenjualan);
            this.Name = "LaporanTransaksiPenjualan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LaporanTransaksiPenjualan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LaporanTransaksiPenjualan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer_transaksipenjualan;
    }
}