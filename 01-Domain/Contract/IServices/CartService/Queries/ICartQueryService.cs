using EShop.Domain.DTOs.Cart;

namespace _01_Domain.Contract.IServices.CartService.Queries
{
    public interface ICartQueryService
    {
        Task<CartOutputDto> ReadByCartId(int CartId);
        Task<List<CartOutputDto>> ReadPaiedCustomerId(int CustomerId);
    }
}
