using Patterns.Chap3.Model;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace Patterns.Chap3.Respository
{
    public class ProductRepository : IProductRepository
    {
        private const string CONNECTION_STRING = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=PatternsChap3; Integrated Security=True;";

        public List<Product> FindAll()
        {
            const string QUERY = @"SELECT [ProductId], [ProductName], [RRP], [SellingPrice] FROM [dbo].[Products]";

            var products = new List<Product>();
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                var command = new SqlCommand(QUERY, connection);

                connection.Open();
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var product = new Product
                    {
                        Id = int.Parse(reader["ProductId"].ToString()),
                        Name = reader["ProductName"].ToString(),
                        Price = new Price(decimal.Parse(reader["RRP"].ToString()), decimal.Parse(reader["SellingPrice"].ToString()))
                    };

                    products.Add(product);
                }
            }

            return products;
        }
    }
}
