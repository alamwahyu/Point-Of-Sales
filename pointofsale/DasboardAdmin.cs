using pointofsale.controlform;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pointofsale
{
    public partial class DasboardAdmin : Form
    {
        int PanelWidth;
        bool isCollapsed;
        public DasboardAdmin(string admin)
        {
            InitializeComponent();
            lb_username.Text = admin;
            timerTime.Start();
            PanelWidth = panelleft.Width;
            isCollapsed = false;

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelleft.Width = panelleft.Width + 10;
                if (panelleft.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelleft.Width = panelleft.Width - 10;
                if (panelleft.Width <= 58)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void btn_side_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void AddControlToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(c);
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lbl_Time.Text = dt.ToString("HH:MM:ss");
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_home);
            UC_Iklan iklan = new UC_Iklan();
            AddControlToPanel(iklan);
        }

        private void btn_profil_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_profil);
            UC_FormProfil profil = new UC_FormProfil(lb_username.Text);
            AddControlToPanel(profil);
        }

        private void btn_trpembelian_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_trpembelian);
            UC_FormTransaksiPembelian tran = new UC_FormTransaksiPembelian();
            AddControlToPanel(tran);
        }

        private void btn_barang_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_barang);
            UC_FormBarang brg = new UC_FormBarang();
            AddControlToPanel(brg);
        }

        private void btn_newakun_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_newakun);
            UC_BuatAkun akun = new UC_BuatAkun();
            AddControlToPanel(akun);
        }

        private void btn_peg_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_peg);
            UC_FormPegawai peg = new UC_FormPegawai();
            AddControlToPanel(peg);
        }

        private void btn_supp_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_supp);
            UC_FormSupplier supp = new UC_FormSupplier();
            AddControlToPanel(supp);
        }

        private void btn_produk_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_produk);
            UC_FormProduk produk = new UC_FormProduk();
            AddControlToPanel(produk);
        }

        private void btn_voucher_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_voucher);
            UC_Voucher vouc = new UC_Voucher();
            AddControlToPanel(vouc);
        }
    }
}
