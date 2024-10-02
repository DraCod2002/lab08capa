using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Data
{
    public class DCustomer
    {
       
        string cadena = "Data Source=DESKTOP-K4C4NU8\\SQLEXPRESSS;Initial Catalog=InvoiceDB;User ID=user1;Password=123456;";

    
        public List<Products> Get()
        {
          
            List<Products> products = new List<Products>();

           
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                connection.Open();

               
                SqlCommand command = new SqlCommand("SELECT * FROM products WHERE active = 1", connection);

              
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    
                    while (reader.Read())
                    {
                        
                        Products product = new Products
                        {
                            ProductId = (int)reader["product_id"],
                            Name = reader["name"].ToString(),
                            Price = (decimal)reader["price"],
                            Stock = (int)reader["stock"],
                            Active = (bool)reader["active"]
                        };

                  
                        products.Add(product);
                    }
                }
            }

            // Retornar la lista de productos
            return products;
        }
    }
}
