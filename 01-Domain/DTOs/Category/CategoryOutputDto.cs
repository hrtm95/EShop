using EShop.Domain.DTOs.Product;

namespace EShop.Domain.DTOs.Category
{
    public class CategoryOutputDto
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public List<ProductOutPutDto> Products { get; set; }
    }
}

