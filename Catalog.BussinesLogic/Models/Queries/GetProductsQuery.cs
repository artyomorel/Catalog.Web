using System.Collections.Generic;
using MediatR;

namespace Catalog.Service.Models.Queries
{
    public class GetProductsQuery: IRequest<List<Catalog.DataAccess.Models.Product>>
    {
        
    }
}