using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace pointofsale.laporan
{
    public partial class LaporanTransaksiPembelian : Form
    {
        private DataSet ds;
        private SqlDataAdapter da;

        private string text_nomasuk;

        kelas.Koneksi konn = new kelas.Koneksi();
        void cetak()
        {
            SqlConnection conn = konn.GetConn();
            {
                conn.Open();
                da = new SqlDataAdapter("select * from vw_cetaktransaksipembelian where NoMasuk = '" + text_nomasuk + "'", conn);
                ds = new DataSet();
                da.Fill(ds, "vw_cetaktransaksipembelian");
                report_transaksipembelian myreport = new report_transaksipembelian();
                myreport.SetDataSource(ds);
                crystalReportViewer_laporanpembelian.ReportSource = myreport;
                crystalReportViewer_laporanpembelian.Refresh();
            }
        }
        public LaporanTransaksiPembelian(string nomasuk)
        {
            InitializeComponent();
            text_nomasuk = nomasuk;
        }

        private void crystalReportViewer_laporanpembelian_Load(object sender, EventArgs e)
        {
            cetak();
        }
    }
}
