using EShop.Domain.DTOs.Cart;
using EShop.Domain.IServices.CartService.Queries;

namespace EShop.Domain.Services.CartService.Queries
{
    public class CartQueryService : ICartQueryService
    {
        public Task<CartOutputDto> ReadByCartId(int CartId)
        {
            throw new NotImplementedException();
        }

        public Task<List<CartOutputDto>> ReadPaiedCustomerId(int CustomerId)
        {
            throw new NotImplementedException();
        }
    }
}
