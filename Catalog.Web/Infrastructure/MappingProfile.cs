using AutoMapper;
using Catalog.Service.Models;
using Catalog.Service.Service;
using Catalog.Web.Models;

namespace Catalog.Web.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductDto, Product>().ReverseMap();
            CreateMap<DataAccess.Models.Product, Product>().ReverseMap();
            CreateMap<Seller, DataAccess.Models.Seller>().ReverseMap();
            CreateMap<SellerDto, Seller>().ReverseMap();
        }
    }
}