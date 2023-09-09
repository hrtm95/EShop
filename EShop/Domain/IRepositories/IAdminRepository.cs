using EShop.Domain.DTOs.Cart;
using EShop.Domain.DTOs;

namespace EShop.Domain.IRepositories
{
    public interface IAdminRepository
    {
        Task<GeneralDto<bool>> Update(AdminEditDto dto);
    }
}
