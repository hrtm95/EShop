using EShop.Domain.DTOs.Product;
using EShop.Domain.Entity;

namespace EShop.Domain.DTOs.Cart
{
    public class CartOutputDto
    {
        public int Id { get; set; }

        public int? Quntity { get; set; }

        public int CustomerId { get; set; }

        public List<ProductOutPutDto> Products { get; set; } = new List<ProductOutPutDto>();
    }
}
