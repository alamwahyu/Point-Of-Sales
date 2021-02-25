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
    public partial class FormProduk : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        kelas.Koneksi konn = new kelas.Koneksi();

        void bersih()
        {
            textBox_idproduk.Text = "";
            textBox_namaproduk.Text = "";
            comboBox_produk.Text = "-pilih jenis produk-";
            textBox_cariproduk.Text = "";
        }
        void atur_tombol(Boolean status)
        {
            button_ubah.Enabled = status;
            button_hapus.Enabled = status;
        }
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
                    dataGridView_produk.DataSource = ds;
                    dataGridView_produk.DataMember = "tb_produk";
                    dataGridView_produk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_produk.AllowUserToAddRows = false;
                    dataGridView_produk.Refresh();
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
                    dataGridView_produk.DataSource = ds;
                    dataGridView_produk.DataMember = "tb_produk";
                    dataGridView_produk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_produk.AllowUserToAddRows = false;
                    dataGridView_produk.Refresh();
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
        void auto_number()
        {
            long hitung;
            string urut;
            SqlDataReader rd;
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("select IDProduk from tb_produk where IDProduk in (select max (IDProduk) from tb_produk) order by IDProduk desc", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["IDProduk"].ToString().Length - 3, 3)) + 1;
                string joinstr = "000" + hitung;
                urut = "PR" + joinstr.Substring(joinstr.Length - 3, 3);
            }
            else
            {
                urut = "PR001";
            }
            rd.Close();
            textBox_idproduk.Enabled = false;
            textBox_idproduk.Text = urut;
            conn.Close();
        }
        public FormProduk()
        {
            InitializeComponent();
            bersih();
            atur_tombol(false);
            refresh_produk();
            auto_number();
        }

        private void textBox_cariproduk_TextChanged(object sender, EventArgs e)
        {
            cari_produk();
        }

        private void button_simpan_Click(object sender, EventArgs e)
        {
            if (textBox_idproduk.Text.Trim() == "" || textBox_namaproduk.Text.Trim() == "" || comboBox_produk.Text.Trim() == "")
            {
                MessageBox.Show("Data Belum Lengkap, Lengkapi Data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection conn = konn.GetConn();
                try
                {
                    cmd = new SqlCommand("insert into tb_produk values ('" + textBox_idproduk.Text + "','" + textBox_namaproduk.Text + "','" + comboBox_produk.Text + "')", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh_produk();
                    bersih();
                    atur_tombol(false);
                    auto_number();
                    this.Hide();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void button_baru_Click(object sender, EventArgs e)
        {
            bersih();
            atur_tombol(false);
            button_simpan.Enabled = true;
            auto_number();
        }

        private void button_ubah_Click(object sender, EventArgs e)
        {
            if (textBox_idproduk.Text.Trim() == "" || textBox_namaproduk.Text.Trim() == "" || comboBox_produk.Text.Trim() == "")
            {
                MessageBox.Show("Data Belum Lengkap, Lengkapi Data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection conn = konn.GetConn();
                try
                {
                    cmd = new SqlCommand("update tb_produk set NamaProduk = '" + textBox_namaproduk.Text + "',JenisProduk ='" + comboBox_produk.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh_produk();
                    bersih();
                    atur_tombol(false);
                    button_simpan.Enabled = true;
                    auto_number();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void button_hapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin Ingin Menghapus Data Produk : " + textBox_namaproduk.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (textBox_idproduk.Text.Trim() == "" || textBox_namaproduk.Text.Trim() == "" || comboBox_produk.Text.Trim() == "")
                {
                    MessageBox.Show("Data Belum Lengkap, Lengkapi Data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    SqlConnection conn = konn.GetConn();
                    {
                        cmd = new SqlCommand("delete from tb_produk where IDProduk ='" + textBox_idproduk.Text + "'", conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil Dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refresh_produk();
                        bersih();
                        atur_tombol(false);
                        button_simpan.Enabled = true;
                        auto_number();
                    }
                }
            }
        }

        private void dataGridView_produk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                button_simpan.Enabled = false;
                atur_tombol(true);
                DataGridViewRow row = this.dataGridView_produk.Rows[e.RowIndex];
                textBox_idproduk.Text = row.Cells["IDProduk"].Value.ToString();
                textBox_namaproduk.Text = row.Cells["NamaProduk"].Value.ToString();
                comboBox_produk.Text = row.Cells["JenisProduk"].Value.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }
    }
}
