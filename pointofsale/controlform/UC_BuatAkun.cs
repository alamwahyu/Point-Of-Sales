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
    public partial class UC_BuatAkun : UserControl
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        kelas.Koneksi konn = new kelas.Koneksi();

        private void kosongtext()
        {
            //txt_cari.Clear();
            textBox_userid.Clear();
            textBox_username.Clear();
            textBox_pass.Clear();
            textBox_konfirm.Clear();
        }
        public String cek_text()
        {
            String hasil = "";
            if (textBox_userid.Text.Trim() == "")
            {
                hasil = "ID Pegawai masih Kosong";
            }
            else if (textBox_userid.Text.Trim() == "")
            {
                hasil = "Username masih kosong";
            }
            else if (textBox_pass.Text.Trim() == "")
            {
                hasil = "Passowrd masih kosong";
            }
            else if (textBox_konfirm.Text.Trim() == "")
            {
                hasil = "Passowrd (Konfirm) masih kosong";
            }
            else
            {
                hasil = "valid";
            }
            return hasil;
        }
        public UC_BuatAkun()
        {
            InitializeComponent();
            textBox_userid.Enabled = false;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                String text = cek_text();
                if (text.Equals("valid"))
                {
                    if (textBox_pass.Text == textBox_konfirm.Text)
                    {
                        if (textBox_pass.Text.Length > 5)
                        {
                            DialogResult dialogResult = MessageBox.Show("Apakah anda yakin tambah Data User", "Simpan Data User", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                SqlConnection conn = konn.GetConn();
                                try
                                {
                                    cmd = new SqlCommand("insert into tb_user values ('" + textBox_userid.Text + "','" + textBox_username.Text + "','" + textBox_pass.Text + "')", conn);
                                    conn.Open();
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Data Berhasil Disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    //this.Hide();
                                }
                                catch (Exception x)
                                {
                                    MessageBox.Show(x.ToString());
                                }

                                kosongtext();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password Minimal 6 Karakter");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password dengan Password(Konfrim) Tidak Sama");
                    }
                }
                else
                {
                    MessageBox.Show(text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            kosongtext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pegawai peg = new Pegawai();
            peg.ShowDialog();
            textBox_userid.Text = peg.ambil_id_user;
        }
    }
}
