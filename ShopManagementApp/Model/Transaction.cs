using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagementApp.Model
{
    class Transaction
    {
        public string OrderQuantity { set; get; }
        public string ProductName { set; get; }
        public decimal ProductPrice { set; get; }
        public string CustomerName { set; get; }
        public string ContactName { set; get; }
    }
}
