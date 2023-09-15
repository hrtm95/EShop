using Microsoft.AspNetCore.Identity;

namespace EShop.Domain.Entity;

public class ApplicationUser : IdentityUser
{
    public string FullName { get; set; }
}
