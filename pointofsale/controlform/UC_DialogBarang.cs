using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace pointofsale.controlform
{
    public partial class UC_DialogBarang : UserControl
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

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

        private void textBox_caribrg_TextChanged(object sender, EventArgs e)
        {
            cari_barang();
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


        public UC_DialogBarang()
        {
            InitializeComponent();
            refresh_barang();
        }

    }
}
