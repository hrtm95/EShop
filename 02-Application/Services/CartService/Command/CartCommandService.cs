using EShop.Domain.IRepositories;
using EShop.Domain.IServices.CartService.Command;

namespace EShop.Domain.Services.CartService.Command
{
    public class CartCommandService : ICartCommandService
    {
        private readonly ICartRepository _cartRepository;

        public CartCommandService(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        public Task<bool> AddPicture(int PictureId, int item)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteCart(int CartId)
        {
            var result =await _cartRepository.Delete(CartId);
            return result.Data;
        }
    }
}
