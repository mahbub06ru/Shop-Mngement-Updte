using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagementApp.Model
{
   public class Product
    {
        public string ProductName { set; get; }
        public string ProductCode { set; get; }
        public string ProductQuantity { set; get; }
        public decimal ProductPrice { set; get; }
    }
}
