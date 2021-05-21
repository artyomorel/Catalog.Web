using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Catalog.DataAccess.Repositories;
using MediatR;

namespace Catalog.Service.Models.Command
{
    public class UpdateSellerCommandHandler : IRequestHandler<UpdateSellerCommand, Seller>
    {
        private readonly ISellerRepository _sellerRepository;
        private readonly IMapper _mapper;

        public UpdateSellerCommandHandler(ISellerRepository sellerRepository,IMapper mapper)
        {
            _sellerRepository = sellerRepository;
            this._mapper = mapper;
            _mapper = mapper;
        }
        public async Task<Seller> Handle(UpdateSellerCommand request, CancellationToken cancellationToken)
        {
            var sellerDb = _mapper.Map<DataAccess.Models.Seller>(request.Seller);
            sellerDb = await _sellerRepository.UpdateAsync(sellerDb);
            return _mapper.Map<Seller>(sellerDb);
        }
    }
}