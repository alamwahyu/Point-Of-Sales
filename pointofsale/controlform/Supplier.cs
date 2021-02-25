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
    public partial class Supplier : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        public string idsupplier, namasupplier = "";

        kelas.Koneksi konn = new kelas.Koneksi();
        void refresh_supplier()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from tb_supplier", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "tb_supplier");
                    dataGridView_dialogsupplier.DataSource = ds;
                    dataGridView_dialogsupplier.DataMember = "tb_supplier";
                    dataGridView_dialogsupplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_dialogsupplier.AllowUserToAddRows = false;
                    dataGridView_dialogsupplier.Refresh();
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
        void cari_supplier()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from tb_supplier where IDSuplier like '%" + textBox_carisupplier.Text + "%' or NamaSupplier like '%" + textBox_carisupplier.Text + "%'", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "tb_supplier");
                    dataGridView_dialogsupplier.DataSource = ds;
                    dataGridView_dialogsupplier.DataMember = "tb_supplier";
                    dataGridView_dialogsupplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_dialogsupplier.AllowUserToAddRows = false;
                    dataGridView_dialogsupplier.Refresh();
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

        private void textBox_carisupplier_TextChanged(object sender, EventArgs e)
        {
            cari_supplier();
        }

        private void dataGridView_dialogsupplier_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView_dialogsupplier.Rows[e.RowIndex];
                idsupplier = row.Cells["IDSupplier"].Value.ToString();
                namasupplier = row.Cells["NamaSupplier"].Value.ToString();
                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }
        public string ambil_id_supplier
        {
            get
            {
                return idsupplier;
            }
        }
        public string ambil_namasupplier
        {
            get
            {
                return namasupplier;
            }
        }
        public Supplier()
        {
            InitializeComponent();
            refresh_supplier();
        }
    }
}
