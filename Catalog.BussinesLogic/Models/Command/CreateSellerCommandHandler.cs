using System.Threading;
using System.Threading.Tasks;
using Catalog.DataAccess.Repositories;
using MediatR;

namespace Catalog.Service.Models.Command
{
    public class CreateSellerCommandHandler: IRequestHandler<CreateSellerCommand,Response>
    {
        private readonly ISellerRepository _repository;

        public CreateSellerCommandHandler(ISellerRepository repository)
        {
            _repository = repository;
        }
        
        public async Task<Response> Handle(CreateSellerCommand request, CancellationToken cancellationToken)
        {
            try
            {
                await _repository.AddAsync(request.Seller);
                return new Response(true);
            }
            catch
            {
                return new Response(false);
            }
            
            
        }
    }
}