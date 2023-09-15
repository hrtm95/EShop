using EShop.Domain.DTOs;
using EShop.Domain.IRepositories;
using EShop.Domain.IServices.AdminService.Command;

namespace EShop.Domain.Services.AdminService.Command
{
    public class AdminCommandService : IAdminCommandService
    {
        private readonly IAdminRepository _adminRepository;

        public AdminCommandService(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }

        public async Task<bool> EditeProfile(AdminEditDto admineditdto)
        {
            var result =await _adminRepository.Update(admineditdto);
            return result.Data;
        }
    }
}
