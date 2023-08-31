using EShop.Domain.Entity;

namespace EShop.Domain.IServices.CartService.Command
{
    public interface ICartCommandService
    {
        Task<bool>DeleteCart(int CustomerId , int CartId );
        Task<CartOutputDto>ReadByCartId(int CartId);
        Task<List<CartOutputDto>>ReadPaiedCustomerId(int CustomerId);
    }

    public class CartOutputDto
    {
        public int Id { get; set; }

        public int? Quntity { get; set; }

        public int CustomerId { get; set; }

        public List<Product> Products { get; set; } = new List<Product>();
    }
}
