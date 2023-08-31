using EShop.Domain.DTOs;

namespace EShop.Domain.IServices.CartService.Queries
{
    public interface ICartQueryService
    {
        Task<CartOutputDto> ReadByCartId(int CartId);
        Task<List<CartOutputDto>> ReadPaiedCustomerId(int CustomerId);
    }
}
