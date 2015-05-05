using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Note - Using System.Data - is added & Using System.Data.SqlClient

namespace SwuptiStock
{
    class DAL
    {
        string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=\\nrh1\users$\aspit1020\dokumenter\SwuptiDB.mdf;Integrated Security=True;Connect Timeout=30";

        public DataTable GetData(string sql)
        {
            DataTable dt = new DataTable();
            using (var con = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            return dt;

        }

        //internal DataTable GetFromDB(string input)
        //{

        //    string sql = "SELECT * FROM "
        //}

    }
}
