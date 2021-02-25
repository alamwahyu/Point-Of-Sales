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
    public partial class DasboardPeg : Form
    {
        public string username = "";
        int PanelWidth;
        bool isCollapsed;
        public DasboardPeg(string user)
        {
            InitializeComponent();
            lb_username.Text = user;
            setNama();
            timerTime.Start();
            PanelWidth = panelleft.Width;
            isCollapsed = false;
        }
        public void setNama()
        {
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

        private void btn_transaksi_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_transaksi);
            UC_FormTransaksiPenjualan transaksi = new UC_FormTransaksiPenjualan();
            AddControlToPanel(transaksi);
        }

        private void btn_barang_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_barang);
            UC_DialogBarang barang = new UC_DialogBarang();
            AddControlToPanel(barang);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lb_username_Click(object sender, EventArgs e)
        {

        }
        public string ambil_username_user
        {
            get
            {
                return username;
            }
        }
    }
}
