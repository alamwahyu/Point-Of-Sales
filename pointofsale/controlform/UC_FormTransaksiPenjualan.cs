using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace pointofsale.controlform
{
    public partial class UC_FormTransaksiPenjualan : UserControl
    {
        private SqlCommand cmd;
        private SqlCommand money;
        private SqlCommand saldoin;
        private SqlDataReader rd;
        private DataSet ds;
        private SqlDataAdapter da;

        kelas.Koneksi konn = new kelas.Koneksi();

        void bersih()
        {
            textBox_nokwitansi.Text = "";
            dateTimePicker_kwitansi.Value = DateTime.Now;
            textBox_iduser.Text = "";
            textBox_namauser.Text = "";
            textBox_kodebarang.Text = "";
            textBox_namabrg.Text = "";
            textBox_harga.Text = "0";
            textBox_qty.Text = "0";
            textBox_diskon.Text = "0";
            textBox_iduser.Enabled = false;
            textBox_namauser.Enabled = false;
            textBox_kodebarang.Enabled = false;
            textBox_namabrg.Enabled = false;
            textBox_harga.Enabled = false;
            button_simpan.Enabled = false;
            button_mines.Enabled = false;
            textBox_kembali.Enabled = false;

        }
        private void awal()
        {
            bersih();
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from vw_penjualan order by NoKwitansi DESC", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "vw_penjualan");
                    dataGridView_transaksijual.DataSource = ds;
                    dataGridView_transaksijual.DataMember = "vw_penjualan";
                    dataGridView_transaksijual.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_transaksijual.AllowUserToAddRows = false;
                    dataGridView_transaksijual.Refresh();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
                groupBox_transaksijual.Enabled = false;
            }
        }
        void auto_number()
        {
            long hitung;
            string urut;
            //SqlDataReader rd;
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("select NoKwitansi from tb_penjualan where NoKwitansi in (select max (NoKwitansi) from tb_penjualan) order by NoKwitansi desc", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["NoKwitansi"].ToString().Length - 4, 4)) + 1;
                string joinstr = "0000" + hitung;
                urut = "KW" + joinstr.Substring(joinstr.Length - 4, 4);
            }
            else
            {
                urut = "KW0001";
            }
            rd.Close();
            textBox_nokwitansi.Text = urut;
            textBox_nokwitansi.Enabled = false;
            conn.Close();
        }

        public UC_FormTransaksiPenjualan()
        {
            InitializeComponent();
            awal();
            auto_number();
        }

        private void button_caribrg_Click(object sender, EventArgs e)
        {
            Barang log_brg = new Barang();
            log_brg.ShowDialog();
            textBox_kodebarang.Text = log_brg.ambil_id_barang;
            textBox_namabrg.Text = log_brg.ambil_namabarang;
            textBox_harga.Text = log_brg.ambil_harga;
        }

        private void button_cariuser_Click(object sender, EventArgs e)
        {
            Pegawai log_pgw = new Pegawai();
            log_pgw.ShowDialog();
            textBox_iduser.Text = log_pgw.ambil_id_user;
            textBox_namauser.Text = log_pgw.ambil_namauser;
        }

        private void button_baru_Click(object sender, EventArgs e)
        {
            awal();
            auto_number();
            dateTimePicker_kwitansi.Focus();
            button_cariuser.Enabled = true;
        }
        private void Simpan_MasterPenjualan()
        {
            SqlConnection conn = konn.GetConn();
            {
                cmd = new SqlCommand("insert into tb_penjualan values ('" + textBox_nokwitansi.Text + "','" + dateTimePicker_kwitansi.Text + "','" + textBox_iduser.Text + "')", conn);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        private void Simpan_MasterDetailPenjualan()
        {
            SqlConnection conn = konn.GetConn();
            {
                cmd = new SqlCommand("insert into tb_detailpenjualan values ('" + textBox_nokwitansi.Text + "','" + textBox_kodebarang.Text + "','" + textBox_qty.Text + "','" + textBox_diskon.Text + "')", conn);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void refresh_penjualan()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from vw_detail where NoKwitansi = '" + textBox_nokwitansi.Text + "'", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "vw_detail");
                    dataGridView_transaksijual.DataSource = ds;
                    dataGridView_transaksijual.DataMember = "vw_detail";
                    dataGridView_transaksijual.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_transaksijual.AllowUserToAddRows = false;
                    dataGridView_transaksijual.Refresh();
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
        private void RefreshTransaksi()
        {
            refresh_penjualan();
            textBox_kodebarang.Clear();
            textBox_namabrg.Clear();
            textBox_harga.Text = "0";
            textBox_qty.Text = "0";
            textBox_qty.Focus();
            textBox_diskon.Text = "0";
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = null;
            SqlConnection conn = konn.GetConn();
            {
                if (textBox_nokwitansi.Text.Trim() == "" || textBox_iduser.Text.Trim() == "" || textBox_kodebarang.Text.Trim() == "" || textBox_qty.Text.Trim() == "")
                {
                    MessageBox.Show("Data Belum Lengkap, Lengkapi Data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from tb_penjualan where NoKwitansi = '" + textBox_nokwitansi.Text + "'", conn);
                    cmd.ExecuteNonQuery();
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        Simpan_MasterDetailPenjualan();
                        totalseluruh();
                    }
                    else
                    {
                        Simpan_MasterPenjualan();
                        Simpan_MasterDetailPenjualan();
                        totalseluruh();
                    }
                    button_cariuser.Enabled = false;
                    button_simpan.Enabled = true;
                    groupBox_transaksijual.Enabled = true;
                    if (textBox_diskon.Text.Trim() == "0")
                    {

                    }
                    else
                    {

                        Diskon d = new Diskon(textBox1.Text);
                        d.ShowDialog();
                    }
                    RefreshTransaksi();
                }
            }

        }

        private void dataGridView_transaksijual_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            button_plus.Enabled = false;
            button_mines.Enabled = true;
            DataGridViewRow row = this.dataGridView_transaksijual.Rows[e.RowIndex];
            textBox_kodebarang.Text = row.Cells["KodeBarang"].Value.ToString();
            textBox_namabrg.Text = row.Cells["NamaBarang"].Value.ToString();
            textBox_harga.Text = row.Cells["Harga"].Value.ToString();
            textBox_qty.Text = row.Cells["Qty"].Value.ToString();
        }

        private void button_mines_Click(object sender, EventArgs e)
        {
            SqlConnection conn = konn.GetConn();
            {
                cmd = new SqlCommand("delete from tb_detailpenjualan where NoKwitansi = '" + textBox_nokwitansi.Text + "' AND KodeBarang = '" + textBox_kodebarang.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                totalseluruh();
                RefreshTransaksi();
                button_plus.Enabled = true;
                button_mines.Enabled = false;
            }
        }
        private void totalseluruh()
        {
            SqlConnection conn = konn.GetConn();
            {
                conn.Open();
                cmd = new SqlCommand("Select sum(Harga*Qty-Potongan) as TotalBayar from vw_detail where NoKwitansi= '" + textBox_nokwitansi.Text + "'", conn);
                cmd.Connection = conn;
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                String TotalSeluruh = result.ToString();
                label_totalseluruh.Text = result.ToString();
                conn.Close();
            }

        }
        void kembalian()
        {
            Double total, uang, kembalian;
            uang = Double.Parse(textBox_bayar.Text);
            total = Double.Parse(label_totalseluruh.Text);
            kembalian = uang - total;
            textBox_kembali.Text = kembalian.ToString();
        }

        private void button_simpan_Click(object sender, EventArgs e)
        {
            fungsi_keuangan();
            MessageBox.Show("Transaksi Selesai");
            kembalian();

            FormKembalian k = new FormKembalian(textBox_kembali.Text);
            k.ShowDialog();
            Feedback f = new Feedback();
            f.ShowDialog();
            laporan.LaporanTransaksiPenjualan a = new laporan.LaporanTransaksiPenjualan(textBox_nokwitansi.Text);
            a.Show();

            awal();
            label_totalseluruh.Text = "0";
            button_cariuser.Enabled = true;
            auto_number();
            textBox_bayar.Text = "";
            textBox_kembali.Text = "";
        }
        private void fungsi_keuangan()
        {
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("Select sum(Harga*Qty-Potongan) as TotalBayar from vw_detail where NoKwitansi= '" + textBox_nokwitansi.Text + "'", conn);
            cmd.Connection = conn;
            int result_totalharga = Convert.ToInt32(cmd.ExecuteScalar());
            //     String TotalSeluruh = result.ToString();
            //      textBox2.Text = result.ToString();

            money = new SqlCommand("select Saldo from tb_akun where NamaAkun='Pemasukan';");
            money.Connection = conn;

            int result_saldo = Convert.ToInt32(money.ExecuteScalar());

            int totalin = result_saldo + result_totalharga;

            String totalon = totalin.ToString();
            textBox2.Text = totalon.ToString();

            saldoin = new SqlCommand("update tb_akun set Saldo = '" + textBox2.Text + "' where NamaAkun='Pendapatan' ", conn);


            saldoin.ExecuteNonQuery();


            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BarcodeScanner scan = new BarcodeScanner();
            scan.ShowDialog();
            textBox_kodebarang.Text = scan.ambil_KodeBarang;
            textBox_namabrg.Text = scan.ambil_NamaBarang;
            textBox_harga.Text = scan.ambil_HargaBarang;
        }

        private void button_scandiskon_Click(object sender, EventArgs e)
        {
            BarcodeScanner s = new BarcodeScanner();
            s.ShowDialog();
            textBox_diskon.Text = s.ambil_voucher;
            textBox1.Text = s.ambil_potongan;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_harga_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
