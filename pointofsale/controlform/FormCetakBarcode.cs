using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace pointofsale.controlform
{
    public partial class FormCetakBarcode : Form
    {
        public FormCetakBarcode()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string barcode = textBox1.Text;
            Bitmap bitmap = new Bitmap(barcode.Length * 40, 150);
            using (Graphics grafik = Graphics.FromImage(bitmap))
            {
                Font font = new System.Drawing.Font("IDAHC39M Code 39 Barcode", 20);
                PointF poin = new PointF(2f, 2f);
                SolidBrush black = new SolidBrush(Color.Black);
                SolidBrush white = new SolidBrush(Color.White);
                grafik.FillRectangle(white, 0, 0, bitmap.Width, bitmap.Height);
                grafik.DrawString("*" + barcode + "*", font, black, poin);
            }
            using (MemoryStream ms = new MemoryStream())
            {
                bitmap.Save(ms, ImageFormat.Png);
                pictureBox1.Image = bitmap;
                //pictureBox1.Height = bitmap.Height;
                //pictureBox1.Width = bitmap.Width;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Barcode Berhasil Disimpan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Hide();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            textBox1.Clear();
            textBox_qrcode.Clear();
        }

        private void button_qrcode_Click(object sender, EventArgs e)
        {
            Zen.Barcode.CodeQrBarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox1.Image = barcode.Draw(textBox_qrcode.Text, 50);
        }
    }
}
