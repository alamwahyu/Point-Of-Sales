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
    public partial class UC_Iklan : UserControl
    {
        private int imageNumber = 1;

        public UC_Iklan()
        {
            InitializeComponent();
        }

        private void LoadNextImage()
        {
            if (imageNumber == 6)
            {
                imageNumber = 1;
            }
            pictureBox1.ImageLocation = string.Format(@"imageiklan\{0}.jpg", imageNumber);
            imageNumber++;
        }
        private void timerIklan_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }
    }
}
