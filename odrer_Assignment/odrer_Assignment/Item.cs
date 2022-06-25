using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace odrer_Assignment
{
  public class Item
    {
        public static string sqlconnection = "Data Source=LAPTOP-2D3FN7GQ;Initial Catalog=Orders;Integrated Security=True";
        public void Add()
        {
            Console.WriteLine("Enter the Item Name");
            string Item_name=Console.ReadLine();
            if(Item_name.Length ==0 || Item_name== null)
            {
                Console.WriteLine("Item name should not be Empty" + "\n" + "Please enter the Quantity");
                 Item_name = Console.ReadLine();
            }
            Console.WriteLine("Enter the Price of a Item");
            int Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Quantity of item(in Kgs)");
            string a = "Kgs";
            int b =Convert.ToInt32( Console.ReadLine());         
            object quantity = b + a;
            Console.WriteLine(quantity);
            #region disconnected mode
            SqlConnection sqlConnection = new SqlConnection(sqlconnection);
            SqlDataAdapter adapter = new SqlDataAdapter("Insert into Item_Master (Item,Rate,Quantity) values('" + Item_name+"',"+Price+",'"+quantity+"')",sqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            #endregion
        }
        public void update(string itemName)
        {

            Console.WriteLine("Enter the Price of a Item");
            int Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Quantity of item(in Kgs)");
            string a = "Kgs";
            int b = Convert.ToInt32(Console.ReadLine());
            object quantity = b + a;
            Console.WriteLine(quantity);


            #region disconnected mode
            SqlConnection sqlConnection = new SqlConnection(sqlconnection);
            SqlDataAdapter adapter = new SqlDataAdapter("update Item_Master set rate="+ Price + ",Quantity='"+quantity+"' where Item='"+ itemName + "'", sqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            #endregion
        }
       public void delete(string ItemName)
        {
            #region disconnected mode
            SqlConnection sqlConnection = new SqlConnection(sqlconnection);
            SqlDataAdapter adapter = new SqlDataAdapter("delete Item_Master where Item='" + ItemName + "'", sqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            #endregion

        }
         public DataTable select()
        {
            #region disconnected mode
            SqlConnection sqlConnection = new SqlConnection(sqlconnection);
            SqlDataAdapter adapter = new SqlDataAdapter("select *from Item_Master", sqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
            #endregion
        }

    }
    }
  
