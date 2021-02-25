using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace pointofsale.kelas
{
    class Login
    {
        //Open Koneksi
        SqlConnection sqlcon = new kelas.Koneksi().GetConn();

        // Method cek_login yang digunakan untuk model login
        public String cek_login(String usr, String pwd)
        {
            String hasil = "";
            try
            {
                sqlcon.Open();
                // execute query yang dicari berdasarkan username
                SqlCommand mySqlCommand = sqlcon.CreateCommand();
                mySqlCommand.CommandText = "SELECT * FROM vw_user WHERE Username=@usr";

                mySqlCommand.Parameters.Add("@usr", SqlDbType.Char, 10);
                mySqlCommand.Parameters["@usr"].Value = usr;

                SqlDataReader dr;
                dr = mySqlCommand.ExecuteReader();
                if (dr.Read())
                {
                    // pencacahan data user berdasarkan username yang login
                    String password = dr["Password"].ToString().Trim();
                    String status = dr["Status"].ToString().Trim();
                    String jataban = dr["Jabatan"].ToString().Trim();

                    // pengecekan password, status, jabatan
                    if (pwd == password)
                    {
                        if (status == "Aktif")
                        {
                            if (jataban == "Admin")
                            {
                                hasil = "Admin";
                            }
                            if (jataban == "Kasir")
                            {
                                hasil = "Kasir";
                            }
                            if (jataban == "Manager")
                            {
                                hasil = "Manager";
                            }
                        }
                        else
                        {
                            hasil = "Tidak Aktif";
                        }
                    }
                    else
                    {
                        hasil = "Gagal";
                    }
                }
                else
                {
                    hasil = "No Injeksi";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
            return hasil;
        }
    }
}
