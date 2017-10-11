using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace RefactorKata
{
    internal class program
    {
        private static void Main(string[] args)
        {

            SqlConnection Conn = new SqlConnection("Server=.;Database=myDataBase;User Id=myUsername;Password = myPassword;");

            SqlCommand cmd = Conn.CreateCommand();
            cmd.CommandText = "select * from Products";
            /*
             * cmd.CommandText = "Select * from Invoices";
             */
            SqlDataReader reader = cmd.ExecuteReader();
            List<Product> products = new List<Product>();

            //TODO: Replace with Dapper
            while (reader.Read())
            {
                var prod = new Product { Name = reader{ ["Name"].ToString() };
              
                products.Add(prod);
            }
            
            Console.WriteLine("Products Loaded!");
            return products;
            {
                
            }
        }
    }
    
    {
        
       
    }
}
