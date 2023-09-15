using EShop.Domain.DTOs.Cart;
using EShop.Domain.DTOs;

namespace _01_Domain.Contract.IRepositories
{
    public interface IAdminRepository
    {
        Task<GeneralDto<bool>> Update(AdminEditDto dto);
        Task<bool> IsExistAdmin(string personalCode);
    }
}
