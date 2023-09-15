using _01_Domain.Contract.IRepositories;
using _01_Domain.Contract.IServices.AdminService.Command;
using EShop.Domain.DTOs;

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
