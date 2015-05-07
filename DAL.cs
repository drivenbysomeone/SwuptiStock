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

        internal DataTable GetFromDbBrands()
        {
            string queryString = "SELECT * FROM Brands";
            return GetData(queryString);
        }

        //Overloads
        internal DataTable GetModelName()
        {
            string queryString = "SELECT ProductId, ModelName FROM Stock";
            return GetData(queryString);
        }

        //Overloads
        internal DataTable GetModelName(int id)
        {
            string queryString = "SELECT ProductId, Modelname FROM Stock, Brands WHERE Brands.BrandId = Stock.BrandId AND Brands.BrandId = " + id;
            return GetData(queryString);
        }

        internal DataTable GetAllStockProperties()
        {
            string queryString = "SELECT * FROM Stock";
            return GetData(queryString);

        }

        internal DataTable GetAllStockProperties(int id)
        {
            string queryString = "SELECT * FROM Stock, Brands WHERE Stock.BrandId = Brands.BrandId AND ProductId = " + id;
            return GetData(queryString);
        }
    }
}

