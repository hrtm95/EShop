using EShop.Domain.DTOs;
using EShop.Domain.DTOs.Cart;

namespace EShop.Domain.IRepositories
{
    public interface ICartRepository
    {
        Task<GeneralDto<bool>> Create(CartAddDto cart);
        Task<GeneralDto<bool>> Update(CartEditDto cart);
        Task<GeneralDto<bool>> Delete(int cartId);
        Task<GeneralDto<CartOutputDto>> GetById(int cartId);
        Task<GeneralDto<List<CartOutputDto>>> GetAll();
    }
}
