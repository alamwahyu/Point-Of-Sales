using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace pointofsale.controlform
{
    public partial class Produk : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        public string idproduk = "";

        kelas.Koneksi konn = new kelas.Koneksi();

        void refresh_produk()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from tb_produk", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "tb_produk");
                    dataGridView_dialogproduk.DataSource = ds;
                    dataGridView_dialogproduk.DataMember = "tb_produk";
                    dataGridView_dialogproduk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_dialogproduk.AllowUserToAddRows = false;
                    dataGridView_dialogproduk.Refresh();
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
        void cari_produk()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from tb_produk where IDProduk like '%" + textBox_cariproduk.Text + "%' or NamaProduk like '%" + textBox_cariproduk.Text + "%'", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "tb_produk");
                    dataGridView_dialogproduk.DataSource = ds;
                    dataGridView_dialogproduk.DataMember = "tb_produk";
                    dataGridView_dialogproduk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_dialogproduk.AllowUserToAddRows = false;
                    dataGridView_dialogproduk.Refresh();
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
        public Produk()
        {
            InitializeComponent();
            refresh_produk();
        }
        public string ambil_id_produk
        {
            get
            {
                return idproduk;
            }
        }

        private void textBox_cariproduk_TextChanged(object sender, EventArgs e)
        {
            cari_produk();
        }

        private void dataGridView_dialogproduk_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView_dialogproduk.Rows[e.RowIndex];
                idproduk = row.Cells["IDProduk"].Value.ToString();
                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }
    }
}
