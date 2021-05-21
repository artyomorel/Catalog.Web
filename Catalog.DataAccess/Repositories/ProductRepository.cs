using System.Threading.Tasks;
using Catalog.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace Catalog.DataAccess.Repositories
{
    public class ProductRepository : Repository<Product>,IProductRepository
    {

        public ProductRepository(ApplicationContext context):base(context)
        { }

        public async Task<Product> GetProductById(int id)
        {
            return await CustomerContext.Products.FirstOrDefaultAsync(x => x.Id == id);
        }
        
    }
}