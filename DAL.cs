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
        string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=U:\dokumenter\SwuptiDB.mdf;Integrated Security=True;Connect Timeout=30";

        public DataTable GetDataCmbBox(string sql)
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

        public DataTable GetDataLstBox(string sql)
        {
            DataTable dt2 = new DataTable();
            using (var con = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt2.Load(reader);
                    }
                }
                return dt2;
            }

        }

        internal DataTable GetFromDbBrands()
        {
            string queryString = "SELECT * FROM Brands";
            return GetDataCmbBox(queryString);
        }

        internal DataTable GetModelName()
        {
            string queryString = "SELECT ModelName FROM Stock";
            return GetDataLstBox(queryString);
        }
      
    }
}

