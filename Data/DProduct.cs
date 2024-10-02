using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Data
{
    public class DProduct
    {
      
        string connectionString = "Server=DESKTOP-K4C4NU8\\SQLEXPRESSS;Initial Catalog=InvoiceDB;User ID=user1;Password=123456;";
        public List<Products> Get()
        {
            List<Products> products = new List<Products>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("GetActiveProducts", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Products product = new Products
                        {
                            ProductId = (int)reader["product_id"],
                        
                            Price = (decimal)reader["price"],
                            Stock = (int)reader["stock"],
                            Active = (bool)reader["active"]
                        };

                        products.Add(product);
                    }
                }
            }

            return products;
        }

        // Método para buscar productos por nombre usando procedimiento almacenado
        public List<Products> GetProductsByName(string name)
        {
            List<Products> products = new List<Products>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("GetProductsByName", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@name", name);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Products product = new Products
                        {
                            ProductId = (int)reader["product_id"],
                            Name = reader["name"]?.ToString() ?? string.Empty,
                            Price = (decimal)reader["price"],
                            Stock = (int)reader["stock"],
                            Active = (bool)reader["active"]
                        };

                        products.Add(product);
                    }
                }
            }

            return products;
        }
    }
}
