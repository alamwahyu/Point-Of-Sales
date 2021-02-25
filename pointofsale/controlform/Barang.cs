using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace pointofsale.controlform
{
    public partial class Barang : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        public string idbarang, namabarang, harga = "";

        kelas.Koneksi konn = new kelas.Koneksi();

        void refresh_barang()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from tb_barang", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "tb_barang");
                    dataGridView_caribrg.DataSource = ds;
                    dataGridView_caribrg.DataMember = "tb_barang";
                    dataGridView_caribrg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_caribrg.AllowUserToAddRows = false;
                    dataGridView_caribrg.Refresh();
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
        void cari_barang()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from tb_barang where KodeBarang like '%" + textBox_caribrg.Text + "%' or NamaBarang like '%" + textBox_caribrg.Text + "%'", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "tb_barang");
                    dataGridView_caribrg.DataSource = ds;
                    dataGridView_caribrg.DataMember = "tb_barang";
                    dataGridView_caribrg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_caribrg.AllowUserToAddRows = false;
                    dataGridView_caribrg.Refresh();
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

        public string ambil_id_barang
        {
            get
            {
                return idbarang;
            }
        }
        public string ambil_namabarang
        {
            get
            {
                return namabarang;
            }
        }

        private void textBox_caribrg_TextChanged_1(object sender, EventArgs e)
        {
            cari_barang();
        }

        private void dataGridView_caribrg_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView_caribrg.Rows[e.RowIndex];
                idbarang = row.Cells["KodeBarang"].Value.ToString();
                namabarang = row.Cells["NamaBarang"].Value.ToString();
                harga = row.Cells["Harga"].Value.ToString();
                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        public string ambil_harga
        {
            get
            {
                return harga;
            }
        }
        public Barang()
        {
            InitializeComponent();
            refresh_barang();
        }
    }
}
