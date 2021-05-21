using Catalog.DataAccess.Models;

namespace Catalog.Web.Models
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int AvailableStock  { get; set; }

        public ProductType ProductType { get; set; }
        public int ProductTypeId { get; set; }
        
        public SellerDto SellerDto { get; set; }
        public int SellerId { get; set; }
    }
}