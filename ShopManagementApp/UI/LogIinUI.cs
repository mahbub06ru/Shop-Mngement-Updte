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
    public partial class LogIinUI : Form
    {
        public LogIinUI()
        {
            InitializeComponent();
        }

        private void loginSubmitButton_Click(object sender, EventArgs e)
        {
            LogIn aLogin = new LogIn();
            aLogin.UserName = enterUserNameTextBox.Text;
            aLogin.Password = enterPasswordTextBox.Text;
            LoginManager lManager = new ProductManager();
            MessageBox.Show(lManager.DataInsert(aProduct));





        }
    }
}
