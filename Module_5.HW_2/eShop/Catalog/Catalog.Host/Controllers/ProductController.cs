using Catalog.Host.Models;
using Catalog.Host.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Host.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            var products = _productService.GetProductsOrNull();
            if (products == null)
            {
                return Enumerable.Empty<Product>();
            }

            return products;
        }
    }
}
