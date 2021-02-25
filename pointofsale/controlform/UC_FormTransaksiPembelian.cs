using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace pointofsale.controlform
{
    public partial class UC_FormTransaksiPembelian : UserControl
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
            textBox_nomasuk.Text = "";
            dateTimePicker_masuk.Value = DateTime.Now;
            textBox_iduser.Text = "";
            textBox_namauser.Text = "";
            textBox_idsupplier.Text = "";
            textBox_namasupplier.Text = "";
            textBox_kodebarang.Text = "";
            textBox_namabrg.Text = "";
            textBox_hargabeli.Text = "0";
            textBox_qty.Text = "0";
            textBox_iduser.Enabled = false;
            textBox_namauser.Enabled = false;
            textBox_idsupplier.Enabled = false;
            textBox_namasupplier.Enabled = false;
            textBox_kodebarang.Enabled = false;
            textBox_namabrg.Enabled = false;
            textBox_hargabeli.Enabled = true;
            button_simpan.Enabled = false;
            button_mines.Enabled = false;

        }
        private void awal()
        {
            bersih();
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from vw_pembelian order by NoMasuk DESC", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "vw_pembelian");
                    dataGridView_transaksipembelian.DataSource = ds;
                    dataGridView_transaksipembelian.DataMember = "vw_pembelian";
                    dataGridView_transaksipembelian.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_transaksipembelian.AllowUserToAddRows = false;
                    dataGridView_transaksipembelian.Refresh();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
                groupBox_transaksibeli.Enabled = false;
            }
        }
        void auto_number()
        {
            long hitung;
            string urut;
            //SqlDataReader rd;
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("select NoMasuk from tb_pembelian where NoMasuk in (select max (NoMasuk) from tb_pembelian) order by NoMasuk desc", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["NoMasuk"].ToString().Length - 4, 4)) + 1;
                string joinstr = "0000" + hitung;
                urut = "MS" + joinstr.Substring(joinstr.Length - 4, 4);
            }
            else
            {
                urut = "MS0001";
            }
            rd.Close();
            textBox_nomasuk.Enabled = false;
            textBox_nomasuk.Text = urut;
            conn.Close();
        }
        public UC_FormTransaksiPembelian()
        {
            InitializeComponent();
            awal();
            auto_number();
        }

        private void button_cariuser_Click(object sender, EventArgs e)
        {
            Pegawai log_pgw = new Pegawai();
            log_pgw.ShowDialog();
            textBox_iduser.Text = log_pgw.ambil_id_user;
            textBox_namauser.Text = log_pgw.ambil_namauser;
        }

        private void button_carisupplier_Click(object sender, EventArgs e)
        {
            Supplier log_sup = new Supplier();
            log_sup.ShowDialog();
            textBox_idsupplier.Text = log_sup.ambil_id_supplier;
            textBox_namasupplier.Text = log_sup.ambil_namasupplier;
        }

        private void button_caribrg_Click(object sender, EventArgs e)
        {
            Barang log_brg = new Barang();
            log_brg.ShowDialog();
            textBox_kodebarang.Text = log_brg.ambil_id_barang;
            textBox_namabrg.Text = log_brg.ambil_namabarang;
        }

        private void button_baru_Click(object sender, EventArgs e)
        {
            awal();
            auto_number();
            dateTimePicker_masuk.Focus();
            button_cariuser.Enabled = true;
        }
        private void Simpan_MasterPembelian()
        {
            SqlConnection conn = konn.GetConn();
            {
                cmd = new SqlCommand("insert into tb_pembelian values ('" + textBox_nomasuk.Text + "','" + textBox_idsupplier.Text + "','" + textBox_iduser.Text + "','" + dateTimePicker_masuk.Text + "')", conn);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        private void Simpan_MasterDetailPembelian()
        {
            SqlConnection conn = konn.GetConn();
            {
                cmd = new SqlCommand("insert into tb_detailpembelian values ('" + textBox_nomasuk.Text + "','" + textBox_kodebarang.Text + "','" + textBox_qty.Text + "','" + textBox_hargabeli.Text + "')", conn);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        void refresh_pembelian()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from vw_detailpembelian where NoMasuk = '" + textBox_nomasuk.Text + "'", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "vw_detailpembelian");
                    dataGridView_transaksipembelian.DataSource = ds;
                    dataGridView_transaksipembelian.DataMember = "vw_detailpembelian";
                    dataGridView_transaksipembelian.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_transaksipembelian.AllowUserToAddRows = false;
                    dataGridView_transaksipembelian.Refresh();
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
            refresh_pembelian();
            textBox_kodebarang.Clear();
            textBox_namabrg.Clear();
            textBox_hargabeli.Text = "0";
            textBox_qty.Text = "0";
            textBox_qty.Focus();
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = null;
            SqlConnection conn = konn.GetConn();
            {
                if (textBox_nomasuk.Text.Trim() == "" || textBox_iduser.Text.Trim() == "" || textBox_idsupplier.Text.Trim() == "" || textBox_kodebarang.Text.Trim() == "" || textBox_qty.Text.Trim() == "")
                {
                    MessageBox.Show("Data Belum Lengkap, Lengkapi Data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from tb_pembelian where NoMasuk = '" + textBox_nomasuk.Text + "'", conn);
                    cmd.ExecuteNonQuery();
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        Simpan_MasterDetailPembelian();
                        totalseluruh();
                    }
                    else
                    {
                        Simpan_MasterPembelian();
                        Simpan_MasterDetailPembelian();
                        totalseluruh();
                    }
                    button_cariuser.Enabled = false;
                    button_simpan.Enabled = true;
                    groupBox_transaksibeli.Enabled = true;
                    RefreshTransaksi();
                }
            }
        }

        private void dataGridView_transaksipembelian_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            button_plus.Enabled = false;
            button_mines.Enabled = true;
            DataGridViewRow row = this.dataGridView_transaksipembelian.Rows[e.RowIndex];
            textBox_kodebarang.Text = row.Cells["KodeBarang"].Value.ToString();
            textBox_namabrg.Text = row.Cells["NamaBarang"].Value.ToString();
            textBox_hargabeli.Text = row.Cells["HargaBeli"].Value.ToString();
            textBox_qty.Text = row.Cells["Qty"].Value.ToString();
        }

        private void button_mines_Click(object sender, EventArgs e)
        {
            SqlConnection conn = konn.GetConn();
            {
                cmd = new SqlCommand("delete from tb_detailpembelian where NoMasuk = '" + textBox_nomasuk.Text + "' AND KodeBarang = '" + textBox_kodebarang.Text + "'", conn);
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
                cmd = new SqlCommand("Select sum(HargaBeli*Qty) as TotalBayar from vw_detailpembelian where NoMasuk= '" + textBox_nomasuk.Text + "'", conn);
                cmd.Connection = conn;
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                String TotalSeluruh = result.ToString();
                label_totalseluruh.Text = result.ToString();
                conn.Close();
            }

        }

        private void button_simpan_Click(object sender, EventArgs e)
        {
            fungsi_keuangan();
            MessageBox.Show("Transaksi Selesai");

            laporan.LaporanTransaksiPembelian a = new laporan.LaporanTransaksiPembelian(textBox_nomasuk.Text);
            a.Show();

            awal();
            label_totalseluruh.Text = "0";
            button_cariuser.Enabled = true;
            auto_number();
        }
        private void fungsi_keuangan()
        {
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("select sum(JumlahBayar) as TotalBayar from vw_cetaktransaksipembelian where NoMasuk= '" + textBox_nomasuk.Text + "'", conn);
            cmd.Connection = conn;
            int result_totalharga = Convert.ToInt32(cmd.ExecuteScalar());
            //     String TotalSeluruh = result.ToString();
            //      textBox2.Text = result.ToString();

            money = new SqlCommand("select Saldo from tb_akun where NamaAkun='Pengeluaran';");
            money.Connection = conn;

            int result_saldo = Convert.ToInt32(money.ExecuteScalar());

            int totalin = result_saldo + result_totalharga;

            String totalon = totalin.ToString();
            textBox1.Text = totalon.ToString();

           saldoin = new SqlCommand("update tb_akun set Saldo = '" + textBox1.Text + "' where NamaAkun='Pengeluaran' ", conn);


           saldoin.ExecuteNonQuery();


            conn.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSupplier supplier = new FormSupplier();
            supplier.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormBarang brg = new FormBarang();
            brg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCetakBarcode kode = new FormCetakBarcode();
            kode.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fungsi_keuangan();
        }

        private void textBox_hargabeli_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
