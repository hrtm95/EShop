using EShop.Domain.Entity;
using EShop.Domain.IServices.UserService;
using EShop.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace EShop.Application.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public UserService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<bool> Login(UserLogin userLogin)
        {
            var user = _userManager.FindByNameAsync(userLogin.UserName).Result;
            if (user != null)
            {
                var result = _userManager.CheckPasswordAsync
                    (user, userLogin.Password).Result;

                if (!result)
                {
                    return false;
                }
                var claim = new Claim(ClaimTypes.Name, user.UserName);
                await _userManager.AddClaimAsync(user, claim);
                await _signInManager.PasswordSignInAsync(userLogin.UserName, userLogin.Password, true, true);
                return true;
            }
            return true;
        }

        public async Task<bool> Register(UserCreateModel userModel)
        {
            var user = new ApplicationUser
            {
                Email = userModel.Email,
                UserName = userModel.Email,
                PasswordHash = userModel.Password,
                FullName = userModel.FullName
            };
            var result = await _userManager.CreateAsync(user, userModel.Password);
            if (!result.Succeeded)
            {
                return false;
            }
            var claim = new Claim(ClaimTypes.Name, user.UserName);
            await _userManager.AddClaimAsync(user, claim);
            await _signInManager.SignInAsync(user, true);
            return true;
        }
    }
}
