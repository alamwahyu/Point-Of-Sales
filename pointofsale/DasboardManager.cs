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
    public partial class DasboardManager : Form
    {
        int PanelWidth;
        bool isCollapsed;
        public DasboardManager(string manager)
        {
            InitializeComponent();
            lb_username.Text = manager;
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
            controlform.UC_Iklan iklan = new controlform.UC_Iklan();
            AddControlToPanel(iklan);
        }

        private void btn_profil_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_profil);
            controlform.UC_FormProfil profil = new controlform.UC_FormProfil(lb_username.Text);
            AddControlToPanel(profil);
        }

        private void btn_keuangan_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_keuangan);
            controlform.UC_FormKeuangan keu = new controlform.UC_FormKeuangan();
            AddControlToPanel(keu);
        }

        private void btn_barang_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_barang);
            laporan.LaporanBarang brg = new laporan.LaporanBarang();
            brg.Show();
        }

        private void btn_voucher_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_voucher);
            laporan.LaporanVoucher dis = new laporan.LaporanVoucher();
            dis.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            moveSidePanel(button1);
            laporan.LaporanFeedback fed = new laporan.LaporanFeedback();
            fed.Show();
        }
    }
}
