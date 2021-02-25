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
    public partial class Diskon : Form
    {
        public Diskon(string diskon)
        {
            InitializeComponent();
            label_potongan.Text = "Rp. " + diskon;
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i % 2 == 0)
            {
                this.BackColor = Color.Black;
                label1.ForeColor = Color.Red;
                label2.ForeColor = Color.Red;
                label_potongan.ForeColor = Color.Red;
                i++;
            }
            else
            {
                this.BackColor = Color.Yellow;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label_potongan.ForeColor = Color.Black;
                i++;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            i++;
        }
    }
}
