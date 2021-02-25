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
    public partial class LaporanBarcode : Form
    {
        private DataSet ds;
        private SqlDataAdapter da;

        kelas.Koneksi konn = new kelas.Koneksi();

        void cetak()
        {
            SqlConnection conn = konn.GetConn();
            {
                conn.Open();
                da = new SqlDataAdapter("select * from tb_barang order by KodeBarang asc", conn);
                ds = new DataSet();
                da.Fill(ds, "tb_barang");
                report_barcode myreport = new report_barcode();
                myreport.SetDataSource(ds);
                crystalReportViewer1.ReportSource = myreport;
                crystalReportViewer1.Refresh();
            }
        }
        public LaporanBarcode()
        {
            InitializeComponent();
            cetak();
        }
    }
}
