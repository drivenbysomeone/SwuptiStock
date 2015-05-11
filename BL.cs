using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwuptiStock
{

    class BL
    {
        DAL dal = new DAL();

        internal List<Brands> GetDataCmbBox()
        {

            DataTable dt = dal.GetFromDbBrands();
            var l = new List<Brands>();
            foreach (DataRow brand in dt.Rows)
            {
                var theBrand = new Brands();
                theBrand.Id = Convert.ToInt32(brand["BrandId"].ToString());
                theBrand.BrandName = brand["Brand"].ToString();
                l.Add(theBrand);
            }
            return l;

        }
        //Overloads 
        internal List<Stock> GetDataLstBox()
        {
            DataTable dt2 = dal.GetModelName();
            return TransferFromDBToObject(dt2);

        }

        //Overload
        internal List<Stock> GetDataLstBox(int id)
        {
            DataTable dt2 = dal.GetModelName(id);
            return TransferFromDBToObject(dt2);
        }

        private static List<Stock> TransferFromDBToObject(DataTable dt2)
        {
            var l2 = new List<Stock>();
            foreach (DataRow item in dt2.Rows)
            {
                var theModelName = new Stock();
                theModelName.ProductId = Convert.ToInt32(item["ProductId"].ToString());
                theModelName.ModelName = item["ModelName"].ToString();
                l2.Add(theModelName);
            }

            return l2;
        }

        internal Stock GetSingleStockById(int id)
        {
            
            DataTable dt2 = dal.GetAllStockProperties(id);
            var stock = new Stock();            
            foreach (DataRow item in dt2.Rows)
            {
                stock.ProductId = Convert.ToInt32(item["ProductId"].ToString());
                stock.ModelName = item["ModelName"].ToString();
                stock.Brand.BrandName = item["Brand"].ToString(); //--> accessed to Brands OK
                stock.Category = item["Category"].ToString();
                stock.ProductType = item["ProductType"].ToString();
                stock.Processor = item["Processor"].ToString();
                stock.Speed = Convert.ToDouble(item["Speed"].ToString());
                stock.OperatingSystem = item["OS"].ToString();
                stock.GraphicCard = item["GraphicCard"].ToString();
                stock.RAM = Convert.ToInt32(item["RAM"].ToString());
                stock.HardDrive = Convert.ToInt32(item["HardDrive"].ToString());
                stock.Screen = item["Screen"].ToString();
                stock.Purchase = Convert.ToDecimal(item["Purchase"].ToString());
                stock.SellingPrice = Convert.ToDecimal(item["SellingPrice"].ToString());
                stock.Number = Convert.ToInt32(item["Number"].ToString());
                stock.StorageLocation = item["StorageLocation"].ToString();
                
                
            }

            return stock;

        }

        internal void UpdateTheStock(decimal purchase, decimal sellingPrice, int number, string location, int productId)
        {

            Stock stock = new Stock();

            stock.ProductId = productId;
            stock.Purchase = purchase;
            stock.SellingPrice = sellingPrice;
            stock.Number = number;
            stock.StorageLocation = location;

   
            dal.UpdateStock(stock);
         
        }

    }
}
