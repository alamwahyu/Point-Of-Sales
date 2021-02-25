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

namespace pointofsale.controlform
{
    public partial class Pegawai : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        public string iduser, namauser = "";

        kelas.Koneksi konn = new kelas.Koneksi();

        void refresh_pegawai()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from tb_pegawai", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "tb_pegawai");
                    dataGridView_dialogpegawai.DataSource = ds;
                    dataGridView_dialogpegawai.DataMember = "tb_pegawai";
                    dataGridView_dialogpegawai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_dialogpegawai.AllowUserToAddRows = false;
                    dataGridView_dialogpegawai.Refresh();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void cari_pegawai()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from tb_pegawai where IDUser like '%" + textBox_cari.Text + "%' or Nama like '%" + textBox_cari.Text + "%'", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "tb_pegawai");
                    dataGridView_dialogpegawai.DataSource = ds;
                    dataGridView_dialogpegawai.DataMember = "tb_pegawai";
                    dataGridView_dialogpegawai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_dialogpegawai.AllowUserToAddRows = false;
                    dataGridView_dialogpegawai.Refresh();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void textBox_cari_TextChanged(object sender, EventArgs e)
        {
            cari_pegawai();
        }

        private void dataGridView_dialogpegawai_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView_dialogpegawai.Rows[e.RowIndex];
                iduser = row.Cells["IDUser"].Value.ToString();
                namauser = row.Cells["Nama"].Value.ToString();
                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }   
        }
        public string ambil_id_user
        {
            get
            {
                return iduser;
            }
        }
        public string ambil_namauser
        {
            get
            {
                return namauser;
            }
        }

        public Pegawai()
        {
            InitializeComponent();
            refresh_pegawai();
        }
    }
}
