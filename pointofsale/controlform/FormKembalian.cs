using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace pointofsale.controlform
{
    public partial class FormKembalian : Form
    {
        public FormKembalian(string kembalian)
        {
            InitializeComponent();
            label_kembalian.Text = "Rp. " + kembalian;
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i % 2 == 0)
            {
                this.BackColor = Color.White;
                label1.ForeColor = Color.Red;
                label_kembalian.ForeColor = Color.Red;
                label3.ForeColor = Color.Red;
                i++;
            }
            else
            {
                this.BackColor = Color.Yellow;
                label1.ForeColor = Color.Black;
                label_kembalian.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                i++;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            i++;
        }
    }
}
