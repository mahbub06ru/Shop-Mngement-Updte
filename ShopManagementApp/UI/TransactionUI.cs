using ShopManagementApp.BLL;
using ShopManagementApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagementApp.UI
{
    public partial class TransactionUI : Form
    {
        ProductManager pManager = new ProductManager();
        public TransactionUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void productNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TransactionUI_Load(object sender, EventArgs e)
        {
            LoadAllProductInComboBox();
        }

        private void LoadAllProductInComboBox()
        {
            List<Product> products = pManager.GetAllProducts();
            productNameComboBox.DisplayMember = "ProductCode";
            productNameComboBox.ValueMember = "ProductName";

            //productNameComboBox.DisplayMember = "ProductName";
            //productNameComboBox.ValueMember = "ProductCode";
            productNameComboBox.DataSource = null;
            productNameComboBox.DataSource = products;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
