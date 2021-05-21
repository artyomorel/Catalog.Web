using MediatR;

namespace Catalog.Service.Models.Command
{
    public class CreateProductCommand : IRequest<Product>
    {
        public Product Product { get; set; }
    }
}