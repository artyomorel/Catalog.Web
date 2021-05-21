using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Catalog.DataAccess.Models;
using Catalog.DataAccess.Repositories;
using Catalog.Service.Service;
using Catalog.Web.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CatalogController: ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public CatalogController(IProductService productService,IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }


        [HttpGet]
        [Route("Products")]
        public async Task<ActionResult<List<Product>>> Products()
        {
            try
            {
                var productsFromDb =  await _productService.GetProductsAsync();
                return Ok(_mapper.Map<List<ProductDto>>(productsFromDb));
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }
    }
}