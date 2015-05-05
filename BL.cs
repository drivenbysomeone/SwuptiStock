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
        internal List<Brands> GetData()
        {

            DataTable dt = dal.GetFromDB();
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
    }
}
