using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using AForge;
using AForge.Video;
using System.Media;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.QrCode;
using System.IO;
using System.Data.SqlClient;

namespace pointofsale.controlform
{
    public partial class BarcodeScanner : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        public string Kode, Nama, Harga, Diskon, potongan = "";

        kelas.Koneksi konn = new kelas.Koneksi();

        SoundPlayer player;
        public BarcodeScanner()
        {
            InitializeComponent();
        }
        private VideoCaptureDevice FinalFrame;
        private FilterInfoCollection CaptureDevice;
        public int i;

        private void button_exit_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (FinalFrame.IsRunning == true)
            {
                FinalFrame.Stop();
                FinalFrame.NewFrame -= new NewFrameEventHandler(FinalFrame_NewFrame);
            }
            this.Close();
        }

        private void checkBox_camera_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_camera.Checked == true)
            {
                comboBox_camera.Visible = true;
                button_select.Visible = true;
            }
            if (checkBox_camera.Checked == false)
            {
                comboBox_camera.Visible = false;
                button_select.Visible = false;
            }
        }
        public string decoded;

        private void timer1_Tick(object sender, EventArgs e)
        {
            BarcodeReader Reader = new BarcodeReader();
            Result result = Reader.Decode((Bitmap)pictureBox_camera.Image);
            if (result != null)
            {
                decoded = result.ToString().Trim();

                if (decoded != "")
                {
                    player.SoundLocation = textBox_sound.Text;
                    player.Play();
                    timer1.Stop();
                    if (FinalFrame.IsRunning == true)
                    {
                        FinalFrame.Stop();
                        FinalFrame.NewFrame -= new NewFrameEventHandler(FinalFrame_NewFrame);
                        MessageBox.Show(" TERBACA " + decoded);
                        //textBox1.Text = decoded;
                        if (comboBox_pilihan.Text == "Penjualan")
                        {
                            refresh_produk();
                        }
                        if (comboBox_pilihan.Text == "Voucher")
                        {
                            refresh_diskon();
                        }
                    }
                    //this.Hide();
                    player.Stop();
                }
            }
            button_cek.PerformClick();
        }

        public string value
        {
            get
            {
                return decoded;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            i++;

            if (pictureBox_camera.Image != null)
            {
                timer1.Start();
                timer2.Stop();
            }
        }
        void refresh_diskon()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from tb_diskon where KodeDiskon = '" + decoded + "'", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "tb_diskon");
                    dataGridView_scan.DataSource = ds;
                    dataGridView_scan.DataMember = "tb_diskon";
                    dataGridView_scan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_scan.AllowUserToAddRows = false;
                    dataGridView_scan.Refresh();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        void refresh_produk()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from tb_barang where KodeBarang = '" + decoded + "'", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "tb_barang");
                    dataGridView_scan.DataSource = ds;
                    dataGridView_scan.DataMember = "tb_barang";
                    dataGridView_scan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_scan.AllowUserToAddRows = false;
                    dataGridView_scan.Refresh();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void dataGridView_scan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (comboBox_pilihan.Text == "Penjualan")
            {
                try
                {
                    DataGridViewRow row = this.dataGridView_scan.Rows[e.RowIndex];
                    Kode = row.Cells["KodeBarang"].Value.ToString();
                    Nama = row.Cells["NamaBarang"].Value.ToString();
                    Harga = row.Cells["Harga"].Value.ToString();
                    this.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
            if (comboBox_pilihan.Text == "Voucher")
            {
                try
                {
                    DataGridViewRow row = this.dataGridView_scan.Rows[e.RowIndex];
                    Diskon = row.Cells["KodeDiskon"].Value.ToString();
                    potongan = row.Cells["Potongan"].Value.ToString();
                    this.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void BarcodeScanner_Load(object sender, EventArgs e)
        {
            player = new SoundPlayer();
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
            {
                comboBox_camera.Items.Add(Device.Name);
            }
            comboBox_camera.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice(CaptureDevice[comboBox_camera.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();

            pictureBox_camera.Focus();
            timer2.Start();
            //refresh_produk();
        }


        private void button_cek_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void button_select_Click(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[comboBox_camera.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
            checkBox_camera.Checked = false;
        }


        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                pictureBox_camera.Image = (Bitmap)eventArgs.Frame.Clone();
            }
            catch
            {

            }
            // pictureBox1.Image = eventArgs.Frame.Clone() as Bitmap;
            // pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();   
        }
        public string ambil_potongan
        {
            get
            {
                return potongan;
            }
        }
        public string ambil_voucher
        {
            get
            {
                return Diskon;
            }
        }
        public string ambil_KodeBarang
        {
            get
            {
                return Kode;
            }
        }
        public string ambil_NamaBarang
        {
            get
            {
                return Nama;
            }
        }
        public string ambil_HargaBarang
        {
            get
            {
                return Harga;
            }
        }
    }
}
