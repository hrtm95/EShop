using EShop.Domain.DTOs;
using EShop.Domain.DTOs.Cart;

namespace _01_Domain.Contract.IRepositories
{
    public interface ICartRepository
    {
        Task<GeneralDto<bool>> Create(CartAddDto cart);
        Task<GeneralDto<bool>> Update(CartEditDto cart);
        Task<GeneralDto<bool>> Delete(int cartId);
        Task<CartOutputDto> GetById(int cartId);
        Task<List<CartOutputDto>> GetAll();
        Task<CartOutputDto> GetActiveCart(int customerId);
    }
}
