using System.Collections.Generic;
using System.Threading.Tasks;
using Catalog.Service.Models;

namespace Catalog.Service.Service
{
    public interface IProductService
    {
        Task<List<Product>> GetProductsAsync();
        Task<Product> AddProductsAsync(Product product);
    }
}