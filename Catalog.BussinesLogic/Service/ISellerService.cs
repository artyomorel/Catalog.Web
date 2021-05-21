using System.Threading.Tasks;
using Catalog.Service.Models;

namespace Catalog.Service.Service
{
    public interface ISellerService
    {
        Task<Response> AddSellerAsync(Seller seller);
        Task<Response> DeleteSellerAsync(int id);
        Task<Seller> UpdateSellerAsync(Seller seller);
    }
}