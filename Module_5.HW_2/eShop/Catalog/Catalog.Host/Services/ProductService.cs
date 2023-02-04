using Catalog.Host.Data;
using Catalog.Host.Models;
using Catalog.Host.Services.Abstractions;

namespace Catalog.Host.Services
{
    public class ProductService : IProductService
    {
        public IEnumerable<Product>? GetProductsOrNull()
        {
            var producrSeeder = new ProductSeeder();
            return producrSeeder.GetProducts(10);
        }
    }
}
