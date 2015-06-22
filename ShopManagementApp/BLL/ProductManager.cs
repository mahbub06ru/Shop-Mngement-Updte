using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopManagementApp.DAL;
using ShopManagementApp.Model;

namespace ShopManagementApp.BLL
{
    public  class ProductManager
    {
        ProductGateway gateway=new ProductGateway();

        public string DataInsert(Product aProduct)
        {
            bool IsInsert = gateway.Insert(aProduct) > 0;
            if (IsInsert)
            {
                return "Insert is Successed";
            }
            else
            {
                return "Insert is Failed";
            }
        }

        internal List<Product> GetAllProducts()
        {
            return gateway.GetAllProducts();
        }
    }
}
