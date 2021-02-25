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
    public partial class UC_FormProfil : UserControl
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        kelas.Koneksi konn = new kelas.Koneksi();
        
        public UC_FormProfil(string biodata)
        {
            InitializeComponent();
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("SELECT tb_pegawai.IDUser, tb_user.Username, Nama, JenisKelamin, TempatLahir, TanggalLahir, Alamat, Telp, Jabatan, Status FROM tb_user INNER JOIN tb_pegawai ON tb_pegawai.IDUser = tb_user.IDUser WHERE Username ='" + biodata + "'", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "tb_user");
                    dataGridView_biodata.DataSource = ds;
                    dataGridView_biodata.DataMember = "tb_user";
                    dataGridView_biodata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_biodata.AllowUserToAddRows = false;
                    dataGridView_biodata.Refresh();
                    
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

        private void dataGridView_biodata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView_biodata.Rows[e.RowIndex];
                tb_user.Text = row.Cells["IDUser"].Value.ToString();
                tb_username.Text = row.Cells["Username"].Value.ToString();
                tb_nama.Text = row.Cells["Nama"].Value.ToString();
                tb_jk.Text = row.Cells["JenisKelamin"].Value.ToString();
                tb_tempatlahir.Text = row.Cells["TempatLahir"].Value.ToString();
                dateTimePicker_tanggal.Text = row.Cells["TanggalLahir"].Value.ToString();
                richTextBox1.Text = row.Cells["Alamat"].Value.ToString();
                tb_telp.Text = row.Cells["Telp"].Value.ToString();
                tb_jabatan.Text = row.Cells["Jabatan"].Value.ToString();
                tb_status.Text = row.Cells["Status"].Value.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void btn_gantipass_Click(object sender, EventArgs e)
        {
            FormUbahPassword pass = new FormUbahPassword();
            pass.Show();
        }
    }
}
