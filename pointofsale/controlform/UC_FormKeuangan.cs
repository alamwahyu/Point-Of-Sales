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
    public partial class UC_FormKeuangan : UserControl
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        kelas.Koneksi konn = new kelas.Koneksi();

        void bersih()
        {
            comboBox_jenis.Text = "-pilih laporan-";
        }
        void refresh_akun()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from tb_akun", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "tb_akun");
                    dataGridView_akun.DataSource = ds;
                    dataGridView_akun.DataMember = "tb_akun";
                    dataGridView_akun.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_akun.AllowUserToAddRows = false;
                    dataGridView_akun.Refresh();
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
        void cari_akunrinci()
        {
            if (comboBox_jenis.Text == "ALL")
            {
                SqlConnection conn = konn.GetConn();
                {
                    try
                    {
                        conn.Open();
                        cmd = new SqlCommand("select * from tb_akunrinci WHERE Tanggal BETWEEN '" + dateTimePicker_awal + "' AND '" + dateTimePicker_akhir + "'", conn);
                        ds = new DataSet();
                        da = new SqlDataAdapter(cmd);
                        da.Fill(ds, "tb_akunrinci");
                        dataGridView_akunrinci.DataSource = ds;
                        dataGridView_akunrinci.DataMember = "tb_akunrinci";
                        dataGridView_akunrinci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridView_akunrinci.AllowUserToAddRows = false;
                        dataGridView_akunrinci.Refresh();
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
            if (comboBox_jenis.Text == "PENJUALAN")
            {
                SqlConnection conn = konn.GetConn();
                {
                    try
                    {
                        conn.Open();
                        cmd = new SqlCommand("select * from tb_akunrinci WHERE Tanggal BETWEEN '" + dateTimePicker_awal + "' AND '" + dateTimePicker_akhir + "'", conn);
                        ds = new DataSet();
                        da = new SqlDataAdapter(cmd);
                        da.Fill(ds, "tb_akunrinci");
                        dataGridView_akunrinci.DataSource = ds;
                        dataGridView_akunrinci.DataMember = "tb_akunrinci";
                        dataGridView_akunrinci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridView_akunrinci.AllowUserToAddRows = false;
                        dataGridView_akunrinci.Refresh();
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
            if (comboBox_jenis.Text == "PEMBELIAN")
            {
                SqlConnection conn = konn.GetConn();
                {
                    try
                    {
                        conn.Open();
                        cmd = new SqlCommand("select * from tb_akunrinci WHERE Tanggal BETWEEN '" + dateTimePicker_awal + "' AND '" + dateTimePicker_akhir + "'", conn);
                        ds = new DataSet();
                        da = new SqlDataAdapter(cmd);
                        da.Fill(ds, "tb_akunrinci");
                        dataGridView_akunrinci.DataSource = ds;
                        dataGridView_akunrinci.DataMember = "tb_akunrinci";
                        dataGridView_akunrinci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridView_akunrinci.AllowUserToAddRows = false;
                        dataGridView_akunrinci.Refresh();
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
            
        }
        void refresh_akunrincian()
        {
            if (comboBox_jenis.Text == "ALL")
            {
                SqlConnection conn = konn.GetConn();
                {
                    try
                    {
                        conn.Open();
                        cmd = new SqlCommand("select * from tb_akunrinci", conn);
                        ds = new DataSet();
                        da = new SqlDataAdapter(cmd);
                        da.Fill(ds, "tb_akunrinci");
                        dataGridView_akunrinci.DataSource = ds;
                        dataGridView_akunrinci.DataMember = "tb_akunrinci";
                        dataGridView_akunrinci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridView_akunrinci.AllowUserToAddRows = false;
                        dataGridView_akunrinci.Refresh();
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
            if (comboBox_jenis.Text == "PENJUALAN")
            {
                SqlConnection conn = konn.GetConn();
                {
                    try
                    {
                        conn.Open();
                        cmd = new SqlCommand("select * from tb_akunrinci where Keterangan='PENJUALAN'", conn);
                        ds = new DataSet();
                        da = new SqlDataAdapter(cmd);
                        da.Fill(ds, "tb_akunrinci");
                        dataGridView_akunrinci.DataSource = ds;
                        dataGridView_akunrinci.DataMember = "tb_akunrinci";
                        dataGridView_akunrinci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridView_akunrinci.AllowUserToAddRows = false;
                        dataGridView_akunrinci.Refresh();
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
            if (comboBox_jenis.Text == "PEMBELIAN")
            {
                SqlConnection conn = konn.GetConn();
                {
                    try
                    {
                        conn.Open();
                        cmd = new SqlCommand("select * from tb_akunrinci where Keterangan='PEMBELIAN'", conn);
                        ds = new DataSet();
                        da = new SqlDataAdapter(cmd);
                        da.Fill(ds, "tb_akunrinci");
                        dataGridView_akunrinci.DataSource = ds;
                        dataGridView_akunrinci.DataMember = "tb_akunrinci";
                        dataGridView_akunrinci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridView_akunrinci.AllowUserToAddRows = false;
                        dataGridView_akunrinci.Refresh();
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
            if (comboBox_jenis.Text == "PENDAPATAN")
            {
                SqlConnection conn = konn.GetConn();
                {
                    try
                    {
                        conn.Open();
                        cmd = new SqlCommand("select * from tb_akunrinci where Keterangan='PENDAPATAN'", conn);
                        ds = new DataSet();
                        da = new SqlDataAdapter(cmd);
                        da.Fill(ds, "tb_akunrinci");
                        dataGridView_akunrinci.DataSource = ds;
                        dataGridView_akunrinci.DataMember = "tb_akunrinci";
                        dataGridView_akunrinci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridView_akunrinci.AllowUserToAddRows = false;
                        dataGridView_akunrinci.Refresh();
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
        }
        public UC_FormKeuangan()
        {
            InitializeComponent();
            bersih();
            refresh_akun();
            refresh_akunrincian();
        }

        private void comboBox_jenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh_akunrincian();
        }

        private void button_cari_Click(object sender, EventArgs e)
        {
            cari_akunrinci();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            laporan.LaporanKeuangan akun = new laporan.LaporanKeuangan();
            akun.Show();
        }
    }
}
