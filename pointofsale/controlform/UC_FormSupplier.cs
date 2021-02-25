using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace pointofsale.controlform
{
    public partial class UC_FormSupplier : UserControl
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        kelas.Koneksi konn = new kelas.Koneksi();

        void bersih()
        {
            textBox_idsupplier.Text = "";
            textBox_namasupplier.Text = "";
            richTextBox_alamat.Text = "";
            textBox_telp.Text = "";
            textBox_cari2.Text = "";
        }
        void atur_tombol(Boolean status)
        {
            button_ubah2.Enabled = status;
            button_hapus2.Enabled = status;
        }
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
                    dataGridView_supplier.DataSource = ds;
                    dataGridView_supplier.DataMember = "tb_supplier";
                    dataGridView_supplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_supplier.AllowUserToAddRows = false;
                    dataGridView_supplier.Refresh();
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
                    cmd = new SqlCommand("select * from tb_supplier where id_supplier like '%" + textBox_cari2.Text + "%' or nama_supplier like '%" + textBox_cari2.Text + "%'", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "tb_supplier");
                    dataGridView_supplier.DataSource = ds;
                    dataGridView_supplier.DataMember = "tb_supplier";
                    dataGridView_supplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_supplier.AllowUserToAddRows = false;
                    dataGridView_supplier.Refresh();
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
            cmd = new SqlCommand("select IDSupplier from tb_supplier where IDSupplier in (select max (IDSupplier) from tb_supplier) order by IDSupplier desc", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["IDSupplier"].ToString().Length - 2, 2)) + 1;
                string joinstr = "00" + hitung;
                urut = "SUP" + joinstr.Substring(joinstr.Length - 2, 2);
            }
            else
            {
                urut = "SUP01";
            }
            rd.Close();
            textBox_idsupplier.Enabled = false;
            textBox_idsupplier.Text = urut;
            conn.Close();
        }
        public UC_FormSupplier()
        {
            InitializeComponent();
            bersih();
            atur_tombol(false);
            refresh_supplier();
            auto_number();
        }

        private void textBox_cari2_TextChanged(object sender, EventArgs e)
        {
            cari_supplier();
        }

        private void dataGridView_supplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                button_simpan2.Enabled = false;
                atur_tombol(true);
                DataGridViewRow row = this.dataGridView_supplier.Rows[e.RowIndex];
                textBox_idsupplier.Text = row.Cells["IDSupplier"].Value.ToString();
                textBox_namasupplier.Text = row.Cells["NamaSupplier"].Value.ToString();
                richTextBox_alamat.Text = row.Cells["Alamat"].Value.ToString();
                textBox_telp.Text = row.Cells["NoTelp"].Value.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void button_baru2_Click(object sender, EventArgs e)
        {
            bersih();
            atur_tombol(false);
            button_simpan2.Enabled = true;
            auto_number();
        }

        private void button_simpan2_Click(object sender, EventArgs e)
        {
            if (textBox_idsupplier.Text.Trim() == "" || textBox_namasupplier.Text.Trim() == "" || richTextBox_alamat.Text.Trim() == "" || textBox_telp.Text.Trim() == "")
            {
                MessageBox.Show("Data Belum Lengkap, Lengkapi Data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection conn = konn.GetConn();
                try
                {
                    cmd = new SqlCommand("insert into tb_supplier values ('" + textBox_idsupplier.Text + "','" + textBox_namasupplier.Text + "','" + richTextBox_alamat.Text + "','" + textBox_telp.Text + "')", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh_supplier();
                    bersih();
                    atur_tombol(false);
                    auto_number();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void button_ubah2_Click(object sender, EventArgs e)
        {
            if (textBox_idsupplier.Text.Trim() == "" || textBox_namasupplier.Text.Trim() == "" || richTextBox_alamat.Text.Trim() == "" || textBox_telp.Text.Trim() == "")
            {
                MessageBox.Show("Data Belum Lengkap, Lengkapi Data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection conn = konn.GetConn();
                try
                {
                    cmd = new SqlCommand("update tb_supplier set nama_supplier = '" + textBox_namasupplier.Text + "',alamat ='" + richTextBox_alamat.Text + "',no_telp = '" + textBox_telp.Text + "' where id_supplier = '" + textBox_idsupplier.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh_supplier();
                    bersih();
                    atur_tombol(false);
                    button_simpan2.Enabled = true;
                    auto_number();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void button_hapus2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin Ingin Menghapus Data Supplier : " + textBox_namasupplier.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (textBox_idsupplier.Text.Trim() == "" || textBox_namasupplier.Text.Trim() == "" || richTextBox_alamat.Text.Trim() == "" || textBox_telp.Text.Trim() == "")
                {
                    MessageBox.Show("Data Belum Lengkap, Lengkapi Data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    SqlConnection conn = konn.GetConn();
                    {
                        cmd = new SqlCommand("delete from tb_supplier where id_supplier ='" + textBox_idsupplier.Text + "'", conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil Dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refresh_supplier();
                        bersih();
                        atur_tombol(false);
                        button_simpan2.Enabled = true;
                        auto_number();
                    }
                }
            }
        }
    }
}
