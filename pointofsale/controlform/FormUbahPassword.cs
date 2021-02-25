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
    public partial class FormUbahPassword : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        kelas.Koneksi konn = new kelas.Koneksi();
        public FormUbahPassword()
        {
            InitializeComponent();
        }

        private void textBox_passini_Enter(object sender, EventArgs e)
        {
            if (textBox_passini.Text == "  Password Saat Ini")
            {
                textBox_passini.Text = "";
                textBox_passini.ForeColor = Color.Black;
                textBox_passini.UseSystemPasswordChar = true;
                textBox_passini.BackColor = Color.White;
                validasi1.Text = "";
            }
            else
            {
                textBox_passini.BackColor = Color.White;
                validasi1.Text = "";
            }
        }

        private void textBox_passini_Leave(object sender, EventArgs e)
        {
            if (textBox_passini.Text == "")
            {
                textBox_passini.Text = "  Password Saat Ini";
                textBox_passini.ForeColor = Color.Silver;
                textBox_passini.UseSystemPasswordChar = false;
            }
        }

        private void textBox_passnew_Enter(object sender, EventArgs e)
        {
            if (textBox_passnew.Text == "  Password Baru")
            {
                textBox_passnew.Text = "";
                textBox_passnew.ForeColor = Color.Black;
                textBox_passnew.UseSystemPasswordChar = true;
                textBox_passnew.BackColor = Color.White;//event ketika textbox masih kosong
                validasi2.Text = "";
            }
            else
            {//event ketika password karakter kurang dari 6
                textBox_passnew.BackColor = Color.White;
                validasi2.Text = "";
            }
        }

        private void textBox_passnew_Leave(object sender, EventArgs e)
        {
            if (textBox_passnew.Text == "")
            {
                textBox_passnew.Text = "  Password Baru";
                textBox_passnew.ForeColor = Color.Silver;
                textBox_passnew.UseSystemPasswordChar = false;
            }
        }

        private void textBox_passverif_Enter(object sender, EventArgs e)
        {
            if (textBox_passverif.Text == "  Konfirmasi Password Baru")
            {
                textBox_passverif.Text = "";
                textBox_passverif.ForeColor = Color.Black;
                textBox_passverif.UseSystemPasswordChar = true;
                textBox_passverif.BackColor = Color.White;
                validasi2.Text = "";
            }
            else
            {//event ketika pass baru tidak sama dengan pass konfirm
                textBox_passverif.BackColor = Color.White;
                validasi2.Text = "";
            }
        }

        private void textBox_passverif_Leave(object sender, EventArgs e)
        {
            if (textBox_passverif.Text == "")
            {
                textBox_passverif.Text = "  Konfirmasi Password Baru";
                textBox_passverif.ForeColor = Color.Silver;
                textBox_passverif.UseSystemPasswordChar = false;
            }
        }

        private void button_simpan_MouseEnter(object sender, EventArgs e)
        {
            button_simpan.BackColor = Color.LightGreen;
            button_simpan.ForeColor = Color.Black;
        }

        private void button_simpan_MouseLeave(object sender, EventArgs e)
        {
            button_simpan.BackColor = Color.LightBlue;
            button_simpan.ForeColor = Color.Black;
        }

        private void button_segar_MouseEnter(object sender, EventArgs e)
        {
            button_segar.BackColor = Color.Yellow;
            button_segar.ForeColor = Color.Black;
        }

        private void button_segar_MouseLeave(object sender, EventArgs e)
        {
            button_segar.BackColor = Color.LightBlue;
            button_segar.ForeColor = Color.Black;
        }

        private void button_simpan_Click(object sender, EventArgs e)
        {
            try
            {
                String text = cek_text();
                if (text.Equals("valid"))
                {
                    if (textBox_passnew.Text == textBox_passverif.Text)
                    {
                        if (textBox_passini.Text.Length > 5 && textBox_passnew.Text.Length > 5)
                        {
                            DialogResult dialogResult = MessageBox.Show("Apakah anda yakin ingin mengubah password User", "Simpan Data User", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                SqlConnection conn = konn.GetConn();
                                try
                                {
                                    cmd = new SqlCommand("update tb_user set Password ='" + textBox_passnew.Text + "' where Password ='" + textBox_passini.Text + "'", conn);
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
                            if (textBox_passini.Text.Length < 6)
                            {
                                MessageBox.Show("Password Lama Minimal 6 Karakter");
                                textBox_passini.BackColor = Color.IndianRed;
                                validasi1.Text = "*Password Minimal 6 Karakter";
                                validasi1.ForeColor = Color.Red;
                            }
                            if (textBox_passnew.Text.Length < 6)
                            {
                                MessageBox.Show("Password Baru Minimal 6 Karakter");
                                textBox_passnew.BackColor = Color.IndianRed;
                                validasi2.Text = "*Password Minimal 6 Karakter";
                                validasi2.ForeColor = Color.Red;
                            }
                            //MessageBox.Show("Password Minimal 6 Karakter");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password dengan Password(Konfrim) Tidak Sama");
                        textBox_passverif.BackColor = Color.IndianRed;
                        validasi2.Text = "*Password Konfirm Tidak Sama";
                        validasi2.ForeColor = Color.Red;

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
        private void kosongtext()
        {
            //txt_cari.Clear();
            textBox_passini.Clear();
            textBox_passnew.Clear();
            textBox_passverif.Clear();
        }
        public String cek_text()
        {
            String hasil = "";
            if (textBox_passini.Text.Trim() == "Password Saat Ini")
            {
                hasil = "Password Lama masih Kosong";
                validasi1.Text = "*Masukan Password Lama";
                validasi1.ForeColor = Color.Red;
                textBox_passini.BackColor = Color.IndianRed;
                textBox_passini.ForeColor = Color.White;
            }
            else if (textBox_passnew.Text.Trim() == "Password Baru")
            {
                hasil = "Passowrd Baru masih kosong";
                validasi2.Text = "*Masukan Password Baru ";
                validasi2.ForeColor = Color.Red;
                textBox_passnew.BackColor = Color.IndianRed;
                textBox_passnew.ForeColor = Color.White;
            }
            else if (textBox_passverif.Text.Trim() == "Konfirmasi Password Baru")
            {
                hasil = "Password (Konfirm) masih kosong";
                validasi2.Text = "*Ulangi Password Baru";
                validasi2.ForeColor = Color.Red;
                textBox_passverif.BackColor = Color.IndianRed;
                textBox_passverif.ForeColor = Color.White;
            }
            else
            {
                hasil = "valid";
            }
            return hasil;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox_passini.UseSystemPasswordChar = false;
                textBox_passnew.UseSystemPasswordChar = false;
                textBox_passverif.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_passini.UseSystemPasswordChar = true;
                textBox_passnew.UseSystemPasswordChar = true;
                textBox_passverif.UseSystemPasswordChar = true;
            }
        }

        private void button_segar_Click(object sender, EventArgs e)
        {
            kosongtext();
        }
    }
}
