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
    public partial class FormBarang : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        kelas.Koneksi konn = new kelas.Koneksi();

        void bersih()
        {
            textBox_idbarang.Text = "";
            textBox_idproduk.Text = "";
            textBox_namabarang.Text = "";
            comboBox_satuan.Text = "-Pilih Satuan-";
            textBox_hargabeli.Text = "0";
            textBox_stok.Text = "0";
            //comboBox_keterangan.Text = "";
            textBox_cari.Text = "";
            //comboBox_keterangan.Text = "-Pilih Keterangan-";
            textBox_hargabeli.Enabled = false;
            textBox_stok.Enabled = false;
            textBox_idproduk.Enabled = false;
        }
        void atur_tombol(Boolean status)
        {
            button_ubah.Enabled = status;
            button_hapus.Enabled = status;
        }

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
                    dataGridView_barang.DataSource = ds;
                    dataGridView_barang.DataMember = "tb_barang";
                    dataGridView_barang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_barang.AllowUserToAddRows = false;
                    dataGridView_barang.Refresh();
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
                    cmd = new SqlCommand("select * from tb_barang where KodeBarang like '%" + textBox_cari.Text + "%' or NamaBarang like '%" + textBox_cari.Text + "%'", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "tb_barang");
                    dataGridView_barang.DataSource = ds;
                    dataGridView_barang.DataMember = "tb_barang";
                    dataGridView_barang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_barang.AllowUserToAddRows = false;
                    dataGridView_barang.Refresh();
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
            cmd = new SqlCommand("select KodeBarang from tb_barang where KodeBarang in (select max (KodeBarang) from tb_barang) order by KodeBarang desc", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["KodeBarang"].ToString().Length - 3, 3)) + 1;
                string joinstr = "000" + hitung;
                urut = "BR" + joinstr.Substring(joinstr.Length - 3, 3);
            }
            else
            {
                urut = "BR001";
            }
            rd.Close();
            textBox_idbarang.Enabled = false;
            textBox_idbarang.Text = urut;
            conn.Close();
        }
        public FormBarang()
        {
            InitializeComponent();
            bersih();
            atur_tombol(false);
            refresh_barang();
            auto_number();
        }

        private void button_cariproduk_Click(object sender, EventArgs e)
        {
            Produk produk = new Produk();
            produk.ShowDialog();
            textBox_idproduk.Text = produk.ambil_id_produk;
        }

        private void textBox_cari_TextChanged(object sender, EventArgs e)
        {
            cari_barang();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormProduk prd = new FormProduk();
            prd.Show();
        }

        private void button_baru_Click(object sender, EventArgs e)
        {
            bersih();
            atur_tombol(false);
            button_simpan.Enabled = true;
            auto_number();
        }

        private void button_simpan_Click(object sender, EventArgs e)
        {
            if (textBox_idbarang.Text.Trim() == "" || textBox_idproduk.Text.Trim() == "" || textBox_namabarang.Text.Trim() == "" || comboBox_satuan.Text.Trim() == "" || textBox_hargabeli.Text.Trim() == "" || textBox_stok.Text.Trim() == "")
            {
                MessageBox.Show("Data Belum Lengkap, Lengkapi Data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection conn = konn.GetConn();
                try
                {
                    cmd = new SqlCommand("insert into tb_barang values ('" + textBox_idbarang.Text + "','" + textBox_idproduk.Text + "','" + textBox_namabarang.Text + "','" + textBox_hargabeli.Text + "','" + textBox_stok.Text + "','" + comboBox_satuan.Text + "')", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh_barang();
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

        private void button_ubah_Click(object sender, EventArgs e)
        {
            if (textBox_idbarang.Text.Trim() == "" || textBox_idproduk.Text.Trim() == "" || textBox_namabarang.Text.Trim() == "" || comboBox_satuan.Text.Trim() == "" || textBox_hargabeli.Text.Trim() == "" || textBox_stok.Text.Trim() == "")
            {
                MessageBox.Show("Data Belum Lengkap, Lengkapi Data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection conn = konn.GetConn();
                try
                {
                    cmd = new SqlCommand("update tb_barang set IDProduk = '" + textBox_idproduk + "',NamaBarang = '" + textBox_namabarang.Text + "',Harga ='" + textBox_hargabeli + "',Stok = '" + textBox_stok.Text + "',Satuan = '" + comboBox_satuan + "' where KodeBarang = '" + textBox_idbarang.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh_barang();
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
            if (MessageBox.Show("Yakin Ingin Menghapus Data Barang : " + textBox_namabarang.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (textBox_idbarang.Text.Trim() == "" || textBox_idproduk.Text.Trim() == "" || textBox_namabarang.Text.Trim() == "" || comboBox_satuan.Text.Trim() == "" || textBox_hargabeli.Text.Trim() == "" || textBox_stok.Text.Trim() == "")
                {
                    MessageBox.Show("Data Belum Lengkap, Lengkapi Data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    SqlConnection conn = konn.GetConn();
                    {
                        cmd = new SqlCommand("delete from tb_barang where KodeBarang ='" + textBox_idbarang.Text + "'", conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil Dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refresh_barang();
                        bersih();
                        atur_tombol(false);
                        button_simpan.Enabled = true;
                        auto_number();
                    }
                }
            }
        }

        private void dataGridView_barang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                button_simpan.Enabled = false;
                atur_tombol(true);
                DataGridViewRow row = this.dataGridView_barang.Rows[e.RowIndex];
                textBox_idbarang.Text = row.Cells["KodeBarang"].Value.ToString();
                textBox_idproduk.Text = row.Cells["IDProduk"].Value.ToString();
                textBox_namabarang.Text = row.Cells["NamaBarang"].Value.ToString();
                textBox_hargabeli.Text = row.Cells["Harga"].Value.ToString();
                textBox_stok.Text = row.Cells["Stok"].Value.ToString();
                comboBox_satuan.Text = row.Cells["Satuan"].Value.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }
    }
}
