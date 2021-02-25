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
    public partial class Form1 : Form
    {

        int PanelWidth;
        bool isCollapsed;
        public Form1()
        {
            InitializeComponent();
            timerTime.Start();
            PanelWidth = panelleft.Width;
            isCollapsed = false;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

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

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
        private void btn_home_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_home);
            UC_Iklan iklan = new UC_Iklan();
            AddControlToPanel(iklan);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_login);
            UC_login login = new UC_login();
            AddControlToPanel(login);
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lbl_Time.Text = dt.ToString("HH:MM:ss");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
