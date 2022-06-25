using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace odrer_Assignment
{
    internal class Customer
    {
        public static string sqlconnection = "Data Source=LAPTOP-2D3FN7GQ;Initial Catalog=Orders;Integrated Security=True";
        public void insert()
        {
            Console.WriteLine("Enter the First Name:");
            string firstname = Console.ReadLine();
            if (firstname == null || firstname.Length == 0)
            {
                Console.WriteLine("First Name should not be Empty" + "\n" + "Please enter the First Name");
                firstname = Console.ReadLine();
            }
            Console.WriteLine("Enter the Last Name:");
            string Lastname = Console.ReadLine();
            if (Lastname == null || Lastname.Length == 0)
            {
                Console.WriteLine("Last Name should not be Empty" + "\n" + "Please enter the LastFirst Name");
                Lastname = Console.ReadLine();
            }
            Console.WriteLine("Enter the Email Id:");
            string email = Console.ReadLine();
            Regex regex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",RegexOptions.CultureInvariant | RegexOptions.Singleline);
            bool isValidEmail = regex.IsMatch(email);
            if (!isValidEmail)
            {
                Console.WriteLine($"The email {email} is invalid"+"\n"+"Please enter the vaild email");
                email= Console.ReadLine();
            }
            Console.WriteLine("Enter the Phone Number:");
            long Number = Convert.ToInt64(Console.ReadLine());
            #region insert
            SqlConnection sqlConnection = new SqlConnection(sqlconnection);
            SqlDataAdapter adapter = new SqlDataAdapter("Insert into Customer_Master values('"+firstname+"','"+Lastname+"',"+Number+ ",'" + email + "')", sqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            #endregion

        }
       public void updatebyNumber(long num)
        {
            Console.WriteLine("Enter the First Name:");
            string firstname = Console.ReadLine();
            if (firstname == null || firstname.Length == 0)
            {
                Console.WriteLine("First Name should not be Empty" + "\n" + "Please enter the First Name");
                firstname = Console.ReadLine();
            }
            Console.WriteLine("Enter the Last Name:");
            string Lastname = Console.ReadLine();
            if (Lastname == null || Lastname.Length == 0)
            {
                Console.WriteLine("Last Name should not be Empty" + "\n" + "Please enter the LastFirst Name");
                Lastname = Console.ReadLine();
            }
            Console.WriteLine("Enter the Email Id:");
            string email = Console.ReadLine();
            Regex regex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", RegexOptions.CultureInvariant | RegexOptions.Singleline);
            bool isValidEmail = regex.IsMatch(email);
            if (!isValidEmail)
            {
                Console.WriteLine($"The email {email} is invalid" + "\n" + "Please enter the vaild email");
                email = Console.ReadLine();
            }
            #region disconnected mode
            SqlConnection sqlConnection = new SqlConnection(sqlconnection);
            SqlDataAdapter adapter = new SqlDataAdapter("update Customer_Master set First_Name='" + firstname + "',Last_Name='" + Lastname + "',Email_Id='"+email+"' where Phone_Number='" +num+ "'", sqlConnection);
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
        public void delete(long num)
        {

            #region disconnected mode
            SqlConnection sqlConnection = new SqlConnection(sqlconnection);
            SqlDataAdapter adapter = new SqlDataAdapter("delete Customer_Masterwhere Phone_Number='" + num + "'", sqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            #endregion
        }
    }
}
