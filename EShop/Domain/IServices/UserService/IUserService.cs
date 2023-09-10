using EShop.Application.Services.UserService;
using EShop.Models;

namespace EShop.Domain.IServices.UserService
{
    public interface IUserService
    {
        Task<bool> Register(UserCreateModel userModel);
        Task<bool> Login(UserLogin userLogin);
    }
}
