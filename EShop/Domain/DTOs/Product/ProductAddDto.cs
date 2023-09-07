namespace EShop.Domain.DTOs.Product
{
    public class ProductAddDto
    {
        public string Name { get; set; } = null!;

        public string? Description { get; set; }

        public decimal? Price { get; set; }

        public int CategoryId { get; set; }

        public int? Quntity { get; set; }
    }
}
