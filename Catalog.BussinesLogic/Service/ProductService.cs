using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Catalog.Service.Models;
using Catalog.Service.Models.Command;
using Catalog.Service.Models.Queries;
using MediatR;

namespace Catalog.Service.Service
{
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public ProductService(IMapper mapper,IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task<List<Product>> GetProductsAsync()
        {
           var products = await _mediator.Send(new GetProductsQuery());
           return _mapper.Map<List<Product>>(products);
        }

        public async Task<Product> AddProductsAsync(Product product)
        {
            try
            {
                return await _mediator.Send(new CreateProductCommand
                {
                    Product = product
                });
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }

    
}