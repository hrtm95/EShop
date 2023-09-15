using EShop.Domain.DTOs;
using EShop.Domain.Entity;

namespace _01_Domain.Contract.IServices.AdminService.Command
{
    public interface IAdminCommandService
    {
        Task<bool> EditeProfile(AdminEditDto admineditdto);
    }
}
