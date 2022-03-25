using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindEntities
{
    public class Products
    {
        public int ProductsID { get; set; }
        public int SupplierID { get; set; }
        public int CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public string UnitPrice { get; set; }
        public string UnitsInStock { get; set; }
        public string UnitsOnOrder { get; set; }
        public string ReorderLevel { get; set; }
        public string Discontinued { get; set; }
        public string ProductsName { get; set; }
    }
}
