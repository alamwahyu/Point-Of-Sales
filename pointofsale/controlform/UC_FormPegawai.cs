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
    public partial class UC_FormPegawai : UserControl
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        kelas.Koneksi konn = new kelas.Koneksi();

        void bersih()
        {
            textBox_iduser.Text = "";
            textBox_tempat.Text = "";
            textBox_nama.Text = "";
            comboBox_jk.Text = "-pilih jenis kelamin-";
            comboBox_jabatan.Text = "-pilih jabatan-";
            comboBox_status.Text = "-pilih status-";
            textBox_cari.Text = "";
        }
        void atur_tombol(Boolean status)
        {
            button_ubah.Enabled = status;
            button_hapus.Enabled = status;
        }
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
                    dataGridView_user.DataSource = ds;
                    dataGridView_user.DataMember = "tb_pegawai";
                    dataGridView_user.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_user.AllowUserToAddRows = false;
                    dataGridView_user.Refresh();
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
                    dataGridView_user.DataSource = ds;
                    dataGridView_user.DataMember = "tb_pegawai";
                    dataGridView_user.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_user.AllowUserToAddRows = false;
                    dataGridView_user.Refresh();
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
            cmd = new SqlCommand("select IDUser from tb_pegawai where IDUser in (select max (IDUser) from tb_pegawai) order by IDUser desc", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["IDUser"].ToString().Length - 3, 3)) + 1;
                string joinstr = "000" + hitung;
                urut = "US" + joinstr.Substring(joinstr.Length - 3, 3);
            }
            else
            {
                urut = "US001";
            }
            rd.Close();
            textBox_iduser.Enabled = false;
            textBox_iduser.Text = urut;
            conn.Close();
        }
        public UC_FormPegawai()
        {
            InitializeComponent();
            bersih();
            atur_tombol(false);
            refresh_pegawai();
            auto_number();
        }

        private void textBox_cari_TextChanged(object sender, EventArgs e)
        {
            cari_pegawai();
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
            if (textBox_iduser.Text.Trim() == "" || textBox_tempat.Text.Trim() == "" || textBox_nama.Text.Trim() == "" || comboBox_jk.Text.Trim() == "" || comboBox_jabatan.Text.Trim() == "" || comboBox_status.Text.Trim() == "" || dateTimePicker_lahir.Text.Trim() == "" || textBox_alamat.Text.Trim() == ""
                || textBox_telp.Text.Trim() == "")
            {
                MessageBox.Show("Data Belum Lengkap, Lengkapi Data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection conn = konn.GetConn();
                try
                {
                    cmd = new SqlCommand("update tb_pegawai set Nama = '" + textBox_nama.Text + "',JenisKelamin = '" + comboBox_jk.Text + "',TempatLahir ='" + textBox_tempat.Text + "',TanggalLahir ='" + dateTimePicker_lahir.Text + "',Alamat ='" + textBox_alamat.Text + "',Telp ='" + textBox_telp.Text + "',Jabatan = '" + comboBox_jabatan.Text + "',Status = '" + comboBox_status.Text + "' where IDUser = '" + textBox_iduser.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh_pegawai();
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

        private void button_simpan_Click(object sender, EventArgs e)
        {
            if (textBox_iduser.Text.Trim() == "" || textBox_tempat.Text.Trim() == "" || textBox_nama.Text.Trim() == "" || comboBox_jk.Text.Trim() == "" || comboBox_jabatan.Text.Trim() == "" || comboBox_status.Text.Trim() == "" || dateTimePicker_lahir.Text.Trim() == "" || textBox_alamat.Text.Trim() == ""
                || textBox_telp.Text.Trim() == "")
            {
                MessageBox.Show("Data Belum Lengkap, Lengkapi Data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection conn = konn.GetConn();
                try
                {
                    cmd = new SqlCommand("insert into tb_pegawai values ('" + textBox_iduser.Text + "','" + textBox_nama.Text + "','" + comboBox_jk.Text + "','" + textBox_tempat.Text + "','" + dateTimePicker_lahir.Text + "','" + textBox_alamat.Text + "','" + textBox_telp.Text + "','" + comboBox_jabatan.Text + "','" + comboBox_status.Text + "')", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh_pegawai();
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

        private void button_hapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin Ingin Menghapus Data Pegawai : " + textBox_nama.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (textBox_iduser.Text.Trim() == "" || textBox_tempat.Text.Trim() == "" || textBox_nama.Text.Trim() == "" || comboBox_jk.Text.Trim() == "" || comboBox_jabatan.Text.Trim() == "" || comboBox_status.Text.Trim() == "" || dateTimePicker_lahir.Text.Trim() == "" || textBox_alamat.Text.Trim() == ""
                || textBox_telp.Text.Trim() == "")
                {
                    MessageBox.Show("Data Belum Lengkap, Lengkapi Data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    SqlConnection conn = konn.GetConn();
                    {
                        cmd = new SqlCommand("delete from tb_pegawai where IDUser ='" + textBox_iduser.Text + "'", conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil Dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refresh_pegawai();
                        bersih();
                        atur_tombol(false);
                        button_simpan.Enabled = true;
                        auto_number();
                    }
                }
            }
        }

        private void dataGridView_user_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                button_simpan.Enabled = false;
                atur_tombol(true);
                DataGridViewRow row = this.dataGridView_user.Rows[e.RowIndex];
                textBox_iduser.Text = row.Cells["IDUser"].Value.ToString();
                textBox_nama.Text = row.Cells["Nama"].Value.ToString();
                comboBox_jk.Text = row.Cells["JenisKelamin"].Value.ToString();
                textBox_tempat.Text = row.Cells["TempatLahir"].Value.ToString();
                dateTimePicker_lahir.Text = row.Cells["TanggalLahir"].Value.ToString();
                textBox_alamat.Text = row.Cells["Alamat"].Value.ToString();
                textBox_telp.Text = row.Cells["Telp"].Value.ToString();
                comboBox_jabatan.Text = row.Cells["Jabatan"].Value.ToString();
                comboBox_status.Text = row.Cells["Status"].Value.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }
    }
}
