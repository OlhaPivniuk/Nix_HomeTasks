using System.Collections.Generic;
using Catalog.Host.Models;

namespace Catalog.Host.Data
{
    public class ProductSeeder
    {
        public IEnumerable<Product> GetProducts(int productAmount)
        {
            var products = new List<Product>();
            var random = new Random();
            for (var i = 0; i < productAmount; i++)
            {
                products.Add(new Product
                {
                    Id = i,
                    Name = $"Name: {i}",
                    Description = $"Desciption: {i}",
                    Price = random.Next(1, int.MaxValue)
                });
            }

            return products;
        }
    }
}
