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


        internal List<Stock> GetDataLstBox()
        {
            DataTable dt2 = dal.GetModelName();
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


      

    }
}
