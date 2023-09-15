using _01_Domain.Contract.IServices.CartService.Queries;
using EShop.Domain.DTOs.Cart;

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
