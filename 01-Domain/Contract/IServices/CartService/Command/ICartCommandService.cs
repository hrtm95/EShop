using EShop.Domain.DTOs;

namespace _01_Domain.Contract.IServices.CartService.Command
{
    public interface ICartCommandService
    {
        Task<bool> DeleteCart(int CartId);
        Task<bool> AddPicture(int PictureId, int item);
    }
}
