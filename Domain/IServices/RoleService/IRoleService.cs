using EShop.Domain.Entity;

namespace EShop.Domain.IServices.RoleService
{
    public interface IRoleService
    {
        Task<ApplicationUser?> AddAdminRole(ApplicationUser user, string personalCode);
    }
}
