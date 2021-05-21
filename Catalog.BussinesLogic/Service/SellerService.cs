using System.Threading.Tasks;
using AutoMapper;
using Catalog.Service.Models;
using Catalog.Service.Models.Command;
using MediatR;

namespace Catalog.Service.Service
{
    public class SellerService : ISellerService
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public SellerService(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task<Response> AddSellerAsync(Seller seller)
        {
            var response = await _mediator.Send(new CreateSellerCommand
            {
                Seller = _mapper.Map<DataAccess.Models.Seller>(seller)
            });
            return response;
        }

        public async Task<Response> DeleteSellerAsync(int id)
        {
            var response = await _mediator.Send(new DeleteSellerCommand(id));
            return response;
        }

        public async Task<Seller> UpdateSellerAsync(Seller seller)
        {
           return await _mediator.Send(new UpdateSellerCommand(seller));
        }
    }
    
}