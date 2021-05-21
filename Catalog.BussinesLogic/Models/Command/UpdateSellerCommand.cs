using MediatR;

namespace Catalog.Service.Models.Command
{
    public record UpdateSellerCommand( Seller Seller) : IRequest<Seller>;
}