using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace pointofsale.laporan
{
    public partial class LaporanTransaksiPenjualan : Form
    {
        private DataSet ds;
        private SqlDataAdapter da;

        private string text_kwitansi;

        kelas.Koneksi konn = new kelas.Koneksi();
        public LaporanTransaksiPenjualan(string nokwitansi)
        {
            InitializeComponent();
            text_kwitansi = nokwitansi;
        }
        void cetak()
        {
            SqlConnection conn = konn.GetConn();
            {
                conn.Open();
                da = new SqlDataAdapter("select * from vw_cetaktransaksi where NoKwitansi = '" + text_kwitansi + "'", conn);
                ds = new DataSet();
                da.Fill(ds, "vw_cetaktransaksi");
                report_transaksipenjualan myreport = new report_transaksipenjualan();
                myreport.SetDataSource(ds);
                crystalReportViewer_transaksipenjualan.ReportSource = myreport;
                crystalReportViewer_transaksipenjualan.Refresh();
            }
        }

        private void LaporanTransaksiPenjualan_Load(object sender, EventArgs e)
        {
            cetak();
        }
    }
}
