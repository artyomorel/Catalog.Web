using MediatR;

namespace Catalog.Service.Models.Command
{
    public record DeleteSellerCommand(int Id) : IRequest<Response>;

}