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

        internal int GetTotalNumberOfProducts()
        {
            DataTable dt = dal.GetTotalProductAmount();
                      
            int number = 0;
  
            foreach (DataRow product in dt.Rows)
            {
                number += Convert.ToInt32(product["Number"].ToString());
                   
            }

            return number;

        }

        internal decimal GetTotalPurchase()
        {
            DataTable dt = dal.GetTotalPurchase();

            decimal purchase = 0;
            decimal number = 0;
            decimal total = 0;

            foreach (DataRow info in dt.Rows)
            {
                purchase = Convert.ToDecimal(info["Purchase"].ToString());
                number = Convert.ToDecimal(info["Number"].ToString());
                total = (purchase * number) + total;

            }

            return total;
         
   
        }

        internal decimal GetTotalSellingPrice()
        {
            DataTable dt = dal.GetTotalSellingPrice();

            decimal sellingPrice = 0;
            decimal number = 0;
            decimal total = 0;

            foreach (DataRow info in dt.Rows)
            {
                sellingPrice = Convert.ToDecimal(info["SellingPrice"].ToString());
                number = Convert.ToDecimal(info["Number"].ToString());
                total = (sellingPrice * number) + total;
            }

            return total;

        }

        internal void InsertNewValues(int totalNumber, decimal totalPurchase, decimal totalSellingPrice, decimal profit)
        {
            Totals totals = new Totals();

           // totals.Id = id;
            //totals.InventoryDate = date;
            totals.TotalNumber = totalNumber;
            totals.TotalPurchase = totalPurchase;
            totals.TotalSellingPrice = totalSellingPrice;
            totals.Profit = profit;

            dal.InsertNewData(totals);

        }

        internal List<Totals> GetGridViewData()
        {
            DataTable dt = dal.GetDataInGridView();
            var list = new List<Totals>();

            foreach (DataRow item in dt.Rows)
            {
                var theItem = new Totals();
                theItem.Id = Convert.ToInt32(item["Id"].ToString());
                theItem.InventoryDate = Convert.ToDateTime(item["InventoryDate"].ToString());
                theItem.TotalNumber = Convert.ToInt32(item["TotalNumber"].ToString());
                theItem.TotalPurchase = Convert.ToDecimal(item["TotalPurchase"].ToString());
                theItem.TotalSellingPrice = Convert.ToDecimal(item["TotalSellingPrice"].ToString());
                theItem.Profit = Convert.ToDecimal(item["Profit"].ToString());

                list.Add(theItem);
 
            }

         //   list.Sort();

            return list;

        }

    }
}
