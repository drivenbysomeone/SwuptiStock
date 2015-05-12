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

        public void UpdateData(string sql)
        {
            using (var con = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        internal void UpdateStock(Stock stock)
        {
System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");



//string sql = "UPDATE Stock SET (Purchase, SellingPrice, Number, StorageLocation) VALUES (" + Convert.ToString(stock.Purchase, culture) + ", " + Convert.ToString(stock.SellingPrice, culture) + ", " + Convert.ToString(stock.Number, culture) + ", '" + stock.StorageLocation + "') WHERE ProductId = " + stock.ProductId;

            //http://lamahashim.blogspot.dk/2010/04/c-read-insert-update-delete-from-sql.html
string sql = "UPDATE Stock SET Purchase =" + Convert.ToString(stock.Purchase, culture) + ", SellingPrice = " + Convert.ToString(stock.SellingPrice, culture) + ", Number =" + Convert.ToString(stock.Number, culture) + ", StorageLocation = '" + stock.StorageLocation + "' WHERE ProductId = " + stock.ProductId;

            UpdateData(sql);

        }


        //Create the insert/overload
    
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

        internal DataTable GetTotalProductAmount()
        {
            string queryString = "SELECT Number FROM Stock";
            return GetData(queryString);
        }

        internal DataTable GetTotalPurchase()
        {
            string queryString = "SELECT Purchase, Number FROM Stock";
            return GetData(queryString);
        }

        internal DataTable GetTotalSellingPrice()
        {
            string queryString = "SELECT SellingPrice, Number FROM Stock";
            return GetData(queryString);
        }

        internal DataTable InsertNewData(Totals totals)
        {
         
            string queryString = "INSERT INTO Totals (InventoryDate, TotalNumber, TotalPurchase, TotalSellingPrice, Profit) VALUES (NOW(), )";
            return GetData(queryString);
        }


    }
}

