using EShop.Domain.DTOs.Product;

namespace EShop.Domain.DTOs.Cart
{
    public class CartEditDto
    {
        public int Id { get; set; }

        public int? Quntity { get; set; }

        public int CustomerId { get; set; }

        public bool? IsPaied { get; set; }

        public List<ProductOutPutDto> productDtos { get; set; }   
    }
}
