using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopManagementApp.UI;

namespace ShopManagementApp
{
    public partial class MenuUI : Form
    {
        public MenuUI()
        {
            InitializeComponent();
        }

        private void inventoryEntryButton_Click(object sender, EventArgs e)
        {
            ProductEntryUI productUI=new ProductEntryUI();
            productUI.Show();
        }

        private void transactionButton_Click(object sender, EventArgs e)
        {
            TransactionUI ui=new TransactionUI();
            ui.Show();
        }

      
    }
}
