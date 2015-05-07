using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwuptiStock
{
    class Stock
    {
        //accessing the Brands class
         public Brands Brand;
        public Stock()
        {
            Brand = new Brands();
        }

        public int ProductId { get; set; }
       // public Brands Brand { get; set; }
        public int BrandId { get; set; }
        public string ModelName { get; set; }
        public string Category { get; set; }
        public string ProductType { get; set; }
        public string Processor { get; set; }
        public double Speed { get; set; }
        public string OperatingSystem { get; set; }
        public string GraphicCard { get; set; }
        public int RAM { get; set; }
        public int HardDrive { get; set; }
        public string Screen { get; set; }
        public decimal Purchase { get; set; }
        public decimal SellingPrice { get; set; }
        public int Number { get; set; }
        public string StorageLocation { get; set; }
        
    }
}
