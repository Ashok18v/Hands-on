using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace odrer_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Item item = new Item();
            //item.Add();
            // item.update("Apples");
            //item.delete("Apples");
            //DataTable dataTable = item.select();
            //Console.WriteLine("Item" + "\t" + "Rate" + "\t" + "Quantity");
            //for (int i = 0; i < dataTable.Rows.Count; i++)
            //{
            //    for (int j = 0; j < dataTable.Columns.Count; j++)
            //    {
            //        Console.Write(dataTable.Rows[i][j] + "\t");
            //    }
            //    Console.WriteLine();    
            //}
            //Customer customer = new Customer();
            //customer.insert();
            Email email = new Email();
            email.sendEmail("ashokveera444@gmail.com", "Hii Ashok", "This is me");
        }
    }
}
