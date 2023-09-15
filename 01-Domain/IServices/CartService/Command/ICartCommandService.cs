using EShop.Domain.DTOs;

namespace EShop.Domain.IServices.CartService.Command
{
    public interface ICartCommandService
    {
        Task<bool>DeleteCart( int CartId );
        Task<bool> AddPicture(int PictureId, int item);
    }
}
