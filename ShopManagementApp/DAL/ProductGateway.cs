using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopManagementApp.Model;

namespace ShopManagementApp.DAL
{
   public class ProductGateway
   {
       private string connectionString = ConfigurationManager.ConnectionStrings["shop"].ConnectionString;

       public int Insert(Product aProduct)
       {
           SqlConnection con=new SqlConnection(connectionString);
           string sql = @"INSERT INTO ProductTable VALUES('" + aProduct.ProductCode + "','" + aProduct.ProductName + "'," +
                     "'"+aProduct.ProductQuantity+"','"+aProduct.ProductPrice+"')";
           SqlCommand cmd=new SqlCommand(sql,con);
           con.Open();
           int rowAffected = cmd.ExecuteNonQuery();
           con.Close();
           return rowAffected;
       }

       public List<Product> GetAllProducts()
       {
           SqlConnection connnection = new SqlConnection(connectionString);
           string query = "SELECT * FROM ProductTable ";
           SqlCommand command = new SqlCommand(query, connnection);
           connnection.Open();
           SqlDataReader reader = command.ExecuteReader();
           List<Product> products = new List<Product>();
           while(reader.Read())
           {
               Product aProduct = new Product();
               aProduct.ProductCode=reader["ProductCode"].ToString();
               aProduct.ProductName=reader["ProductName"].ToString();
               aProduct.ProductQuantity=reader["ProductQuantity"].ToString();
               aProduct.ProductPrice = Convert.ToDecimal(reader["ProductPrice"].ToString());
               products.Add(aProduct);
           }
           reader.Close();
           connnection.Close();
           return products;
       }
   }
}
