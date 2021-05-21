using MediatR;

namespace Catalog.Service.Models.Command
{
    public class CreateSellerCommand: IRequest<Response>
    {
        public DataAccess.Models.Seller Seller { get; set; }
    }
}