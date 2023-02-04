using Catalog.Host.Models;

namespace Catalog.Host.Services.Abstractions
{
    public interface IProductService
    {
        public IEnumerable<Product> GetProductsOrNull();
    }
}