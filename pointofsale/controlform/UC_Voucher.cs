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
    public partial class UC_Voucher : UserControl
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        kelas.Koneksi konn = new kelas.Koneksi();
        public UC_Voucher()
        {
            InitializeComponent();
            refresh_produk();
        }

        private void textBox_kode_Enter(object sender, EventArgs e)
        {
            if (textBox_kode.Text == "  Kode Voucher Baru")
            {
                textBox_kode.Text = "";
                textBox_kode.ForeColor = Color.Black;
            }
        }

        private void textBox_kode_Leave(object sender, EventArgs e)
        {
            if (textBox_kode.Text == "")
            {
                textBox_kode.Text = "  Kode Voucher Baru";
                textBox_kode.ForeColor = Color.Silver;
            }
        }

        private void textBox_nominal_Enter(object sender, EventArgs e)
        {
            if (textBox_nominal.Text == "  Nominal Potongan")
            {
                textBox_nominal.Text = "";
                textBox_nominal.ForeColor = Color.Black;
            }
        }

        private void textBox_nominal_Leave(object sender, EventArgs e)
        {
            if (textBox_nominal.Text == "")
            {
                textBox_nominal.Text = "  Nominal Potongan";
                textBox_nominal.ForeColor = Color.Silver;
            }
        }

        private void button_qr_MouseEnter(object sender, EventArgs e)
        {
            button_qr.BackColor = Color.LightBlue;
            button_qr.ForeColor = Color.Black;
        }

        private void button_qr_MouseLeave(object sender, EventArgs e)
        {
            button_qr.BackColor = Color.LightGray;
            button_qr.ForeColor = Color.Black;
        }

        private void button_simpan_MouseEnter(object sender, EventArgs e)
        {
            button_simpan.BackColor = Color.LightGreen;
            button_simpan.ForeColor = Color.Black;
        }

        private void button_simpan_MouseLeave(object sender, EventArgs e)
        {
            button_simpan.BackColor = Color.LightGray;
            button_simpan.ForeColor = Color.Black;
        }

        private void button_hapus_MouseEnter(object sender, EventArgs e)
        {
            button_hapus.BackColor = Color.LightCoral;
            button_hapus.ForeColor = Color.Black;
        }

        private void button_hapus_MouseLeave(object sender, EventArgs e)
        {
            button_hapus.BackColor = Color.LightGray;
            button_hapus.ForeColor = Color.Black;
        }

        private void button_segar_MouseEnter(object sender, EventArgs e)
        {
            button_segar.BackColor = Color.Yellow;
            button_segar.ForeColor = Color.Black;
        }

        private void button_segar_MouseLeave(object sender, EventArgs e)
        {
            button_segar.BackColor = Color.LightGray;
            button_segar.ForeColor = Color.Black;
        }
        void refresh_produk()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from tb_diskon", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "tb_diskon");
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "tb_diskon";
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.Refresh();
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

        private void button_simpan_Click(object sender, EventArgs e)
        {
            if (textBox_kode.Text == "  Kode Voucher Baru" || textBox_nominal.Text == "  Nominal Potongan")
            {
                MessageBox.Show("Data Belum Lengkap, Lengkapi Data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection conn = konn.GetConn();
                try
                {
                    cmd = new SqlCommand("insert into tb_diskon values ('" + textBox_kode.Text + "','" + textBox_nominal.Text + "')", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh_produk();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void button_hapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin Ingin Menghapus Voucher: ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (textBox_kode.Text == "  Kode Voucher Baru" || textBox_nominal.Text == "  Nominal Potongan")
                {
                    MessageBox.Show("Data Belum Lengkap, Lengkapi Data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    SqlConnection conn = konn.GetConn();
                    {
                        cmd = new SqlCommand("delete from tb_diskon where KodeDiskon ='" + textBox_kode.Text + "'", conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil Dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refresh_produk();
                    }
                }
            }
        }

        private void button_segar_Click(object sender, EventArgs e)
        {
            textBox_kode.Clear();
            textBox_nominal.Clear();
        }

        private void button_qr_Click(object sender, EventArgs e)
        {
            FormCetakBarcode c = new FormCetakBarcode();
            c.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox_kode.Text = row.Cells["KodeDiskon"].Value.ToString();
                textBox_nominal.Text = row.Cells["Potongan"].Value.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }
    }
}
