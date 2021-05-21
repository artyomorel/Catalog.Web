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
        public async Task<Response> AddAsync(SellerDto sellerDto)
        {
            var seller = GetMappingSeller(sellerDto);
            return await _sellerService.AddSellerAsync(seller);
        }

        private Seller GetMappingSeller(SellerDto sellerDto)
        {
           return _mapper.Map<Seller>(sellerDto);
        }

        [HttpDelete]
        [Route("Delete/{id:int}")]
        public async Task<Response> DeleteAsync(int id)
        {
            return await _sellerService.DeleteSellerAsync(id);
        }

        [HttpPut]
        [Route("update")]
        public async Task<SellerDto> UpdateAsync(SellerDto sellerDto)
        {
            var seller = GetMappingSeller(sellerDto);
            seller = await _sellerService.UpdateSellerAsync(seller);
            return GetMappingSellerDto(seller);
        }
        
        private SellerDto GetMappingSellerDto(Seller seller)
        {
            return _mapper.Map<SellerDto>(seller);
        }
    }
}