using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace pointofsale.controlform
{
    public partial class Feedback : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        kelas.Koneksi konn = new kelas.Koneksi();
        public Feedback()
        {
            InitializeComponent();
        }


        private void pb_smile_Click(object sender, EventArgs e)
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO tb_feedback(suka, tidaksuka) values('1','0')", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Terima Kasih telah memberikan Penilaian kepada Kami", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void pb_sad_Click(object sender, EventArgs e)
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO tb_feedback(suka, tidaksuka) values('0','1')", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Terima Kasih telah memberikan Penilaian kepada Kami", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
