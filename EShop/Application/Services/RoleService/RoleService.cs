using EShop.Domain.Entity;
using EShop.Domain.IRepositories;
using EShop.Domain.IServices.RoleService;
using Microsoft.AspNetCore.Identity;

namespace EShop.Application.Services.RoleService
{
    public class RoleService : IRoleService
    {
        private readonly RoleManager<Role> _roleManager;
        private readonly IAdminRepository _adminRepository;
        private readonly UserManager<ApplicationUser> _userManager;

        public RoleService(RoleManager<Role> roleManager, IAdminRepository adminRepository, UserManager<ApplicationUser> userManager)
        {
            _roleManager = roleManager;
            _adminRepository = adminRepository;
            _userManager = userManager;
        }

        private async Task CreateRole(string name)
        {
            await _roleManager.CreateAsync(new Role()
            {
                Name = name,
                Id = new Guid().ToString(),
                Description = $"role name = {name}"
            });
        }


        public async Task<ApplicationUser?> AddAdminRole(ApplicationUser user, string personalCode)
        {
            if (await _adminRepository.IsExistAdmin(personalCode))
            {
                if (await _roleManager.RoleExistsAsync(nameof(Admin)))
                {
                    await _userManager.AddToRoleAsync(user, nameof(Admin));
                    return user;
                }
                await CreateRole(nameof(Admin));
                await _userManager.AddToRoleAsync(user, nameof(Admin));
                return user;
            }
            return null;

        }

        public async Task<ApplicationUser?> AddCustomerRole(ApplicationUser user)
        {
            if (await _roleManager.RoleExistsAsync(nameof(Customer)))
            {
                await _userManager.AddToRoleAsync(user, nameof(Customer));
                return user;
            }
            await CreateRole(nameof(Customer));
            await _userManager.AddToRoleAsync(user, nameof(Customer));
            return user;
        }
    }
}
