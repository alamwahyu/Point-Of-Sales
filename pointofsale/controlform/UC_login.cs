using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pointofsale.controlform
{
    public partial class UC_login : UserControl
    {
        public UC_login()
        {
            InitializeComponent();
        }
        public String cek_text()
        {
            String hasil = "";
            if (tb_username.Text.Trim() == "")
            {
                hasil = "Username masih kosong";
            }
            else if (tb_pass.Text.Trim() == "")
            {
                hasil = "Password masih kosong";
            }
            else
            {
                hasil = "valid";
            }
            return hasil;
        }
        private void kosongtext()
        {
            tb_username.Clear();
            tb_pass.Clear();
        }
        private void cb_lihatpass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_lihatpass.Checked)
            {
                tb_pass.UseSystemPasswordChar = false;
            }
            else
            {
                tb_pass.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String cek = cek_text();
            if (cek.Equals("valid"))
            {
                String cek_login = new kelas.Login().cek_login(tb_username.Text.Trim(), tb_pass.Text.Trim());
                if (cek_login.Equals("No Injeksi"))
                {
                    MessageBox.Show("Login Tidak Bisa Diinjeksi");
                    kosongtext();
                }
                else
                {
                    if (cek_login.Equals("Gagal"))
                    {
                        MessageBox.Show("Username Dan Password Salah");
                        kosongtext();
                    }
                    else
                    {
                        if (cek_login.Equals("Tidak Aktif"))
                        {
                            MessageBox.Show("Maaf Akun Anda Tidak Aktif");
                            kosongtext();
                        }
                        else
                        {
                            if (cek_login.Equals("Admin"))
                            {
                                MessageBox.Show("Login Berhasil");
                                DasboardAdmin adm = new DasboardAdmin(tb_username.Text);
                                    adm.Show();
                                kosongtext();
                                
                            }
                            if (cek_login.Equals("Kasir"))
                            {
                                MessageBox.Show("Login Berhasil");
                                DasboardPeg peg = new DasboardPeg(tb_username.Text);
                                peg.Show();
                                kosongtext();
                            }
                            if (cek_login.Equals("Manager"))
                            {
                                MessageBox.Show("Login Berhasil");
                                DasboardManager man = new DasboardManager(tb_username.Text);
                                man.Show();
                                kosongtext();

                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show(cek);
            }
        }
    }
}
