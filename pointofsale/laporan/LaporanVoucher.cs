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
    public partial class LaporanVoucher : Form
    {
        private DataSet ds;
        private SqlDataAdapter da;

        kelas.Koneksi konn = new kelas.Koneksi();

        void cetak()
        {
            SqlConnection conn = konn.GetConn();
            {
                conn.Open();
                da = new SqlDataAdapter("select * from tb_diskon", conn);
                ds = new DataSet();
                da.Fill(ds, "tb_diskon");
                laporan.report_voucher dis = new laporan.report_voucher();
                dis.SetDataSource(ds);
                crystalReportViewer1.ReportSource = dis;
                crystalReportViewer1.Refresh();
            }
        }
        public LaporanVoucher()
        {
            InitializeComponent();
            cetak();
        }
    }
}
