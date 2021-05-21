using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Catalog.DataAccess.Repositories;
using MediatR;

namespace Catalog.Service.Models.Queries
{
    public class GetProductsQueryHandler: IRequestHandler<GetProductsQuery,List<Catalog.DataAccess.Models.Product>>
    {
        private readonly IProductRepository _repository;

        public GetProductsQueryHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<DataAccess.Models.Product>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            return _repository.GetAll().ToList();
        }
    }
}