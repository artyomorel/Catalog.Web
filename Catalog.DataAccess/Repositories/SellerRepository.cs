using System.Threading.Tasks;
using Catalog.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace Catalog.DataAccess.Repositories
{
    public class SellerRepository : Repository<Seller>, ISellerRepository
    {
        public SellerRepository(ApplicationContext customerContext) : base(customerContext)
        {
        }

        public async Task<Seller> GetSellerById(int id)
        {
            return await CustomerContext.Sellers.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<bool> DeleteById(int id)
        {
            var seller = await CustomerContext.Sellers.FirstOrDefaultAsync(x => x.Id == id);
            if (seller == null) return false;
            CustomerContext.Sellers.Remove(seller);
            await CustomerContext.SaveChangesAsync();
            return true;
        }
    }
}