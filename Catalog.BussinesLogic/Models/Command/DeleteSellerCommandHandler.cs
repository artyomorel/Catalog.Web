using System.Threading;
using System.Threading.Tasks;
using Catalog.DataAccess.Repositories;
using MediatR;

namespace Catalog.Service.Models.Command
{
    public class DeleteSellerCommandHandler : IRequestHandler<DeleteSellerCommand,Response>
    {
        private readonly ISellerRepository _sellerRepository;

        public DeleteSellerCommandHandler(ISellerRepository sellerRepository)
        {
            _sellerRepository = sellerRepository;
        }
        public async Task<Response> Handle(DeleteSellerCommand request, CancellationToken cancellationToken)
        {
           var result= await _sellerRepository.DeleteById(request.Id);
           return new Response(result);
        }
    }
}