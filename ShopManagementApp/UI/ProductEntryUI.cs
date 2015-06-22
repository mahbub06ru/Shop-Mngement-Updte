using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopManagementApp.BLL;
using ShopManagementApp.Model;

namespace ShopManagementApp.UI
{
    public partial class ProductEntryUI : Form
    {
        public ProductEntryUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Product aProduct=new Product();
            aProduct.ProductCode = productCodeTextBox.Text;
            aProduct.ProductName = productNameTextBox.Text;
            aProduct.ProductQuantity = productQuantityTextBox.Text;
            aProduct.ProductPrice =Convert.ToDecimal(productPriceTextBox.Text);
            ProductManager manager=new ProductManager();
            MessageBox.Show(manager.DataInsert(aProduct));
        }
    }
}
