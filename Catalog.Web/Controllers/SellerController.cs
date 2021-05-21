using System.Threading.Tasks;
using AutoMapper;
using Catalog.Service.Models;
using Catalog.Service.Service;
using Catalog.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SellerController : ControllerBase
    {
        private readonly ISellerService _sellerService;
        private readonly IMapper _mapper;

        public SellerController(ISellerService sellerService, IMapper mapper)
        {
            _sellerService = sellerService;
            _mapper = mapper;
        }

        [HttpPost]
        [Route("Add")]
        public async Task<Response> AddSellerAsync(SellerDto sellerDto)
        {
            var seller = _mapper.Map<Seller>(sellerDto);
            return await _sellerService.AddSellerAsync(seller);
        }
    }
}