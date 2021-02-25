using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace pointofsale.kelas
{
    class Koneksi
    {
        public SqlConnection GetConn()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source = LAPTOP-HTFI5LEL; Initial Catalog=db_uinmarket; Integrated Security=True";
            return conn;
        }
    }
}
