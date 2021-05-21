using System.Threading.Tasks;
using Catalog.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace Catalog.DataAccess.Repositories
{
    public class SellerRepository: Repository<Seller>, ISellerRepository
    {
        public SellerRepository(ApplicationContext customerContext) : base(customerContext)
        {
        }

        async Task<Seller> ISellerRepository.GetSellerById(int id)
        {
            return await CustomerContext.Sellers.FirstOrDefaultAsync(x=>x.Id == id);
        }
    }
}