using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwuptiStock
{
    class Totals
    {

        public int Id { get; set; }
        public DateTime InventoryDate { get; set; } //evt se Stock --> Brands
        public int TotalNumber { get; set; }
        public decimal TotalPurchase { get; set; }
        public decimal TotalSellingPrice { get; set; }
        public decimal Profit { get; set; }

    }
}
