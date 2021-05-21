using System.Threading.Tasks;
using Catalog.DataAccess.Models;

namespace Catalog.DataAccess.Repositories
{
    public interface ISellerRepository: IRepository<Seller>
    {
        Task<Seller> GetSellerById(int id);

        Task<bool> DeleteById(int id);
    }
}