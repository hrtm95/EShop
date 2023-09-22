using _01_Domain.Contract.IRepositories;
using _01_Domain.Contract.IServices.AdminService.Command;
using _01_Domain.Contract.IServices.AdminService.Queries;
using _01_Domain.Contract.IServices.CartService.Command;
using _01_Domain.Contract.IServices.CartService.Queries;
using _01_Domain.Contract.IServices.CategoryService.Command;
using _01_Domain.Contract.IServices.CategoryService.Queries;
using _01_Domain.Contract.IServices.CustomerService.Command;
using _01_Domain.Contract.IServices.CustomerService.Queries;
using _01_Domain.Contract.IServices.ProductService.Commands;
using _01_Domain.Contract.IServices.ProductService.Queries;
using EShop.Application.Services.UserService;
using EShop.Data.Repository;
using EShop.Domain.Services.AdminService.Command;
using EShop.Domain.Services.AdminService.Queries;
using EShop.Domain.Services.CartService.Command;
using EShop.Domain.Services.CartService.Queries;
using EShop.Domain.Services.Category.Command;
using EShop.Domain.Services.Category.Queries;
using EShop.Domain.Services.CustomerService.Command;
using EShop.Domain.Services.CustomerService.Queries;
using EShop.Domain.Services.Product.Command;
using EShop.Domain.Services.Product.Queries;

namespace EShop
{
    public  class InjectingStartUp
    {
        public void ConfigureServices(IServiceCollection services)
        {

            // repositories
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IAdminRepository, AdminRepository>();
            services.AddScoped<ICartRepository, CartRepository>();
            services.AddScoped<ICategoryRepository, CategoyRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IPictureRepository, PictureRepository>();


            // services

            services.AddScoped<IAdminCommandService, AdminCommandService>();
            services.AddScoped<IAdminQueryService, AdminQueryService>();

            services.AddScoped<ICartCommandService, CartCommandService>();
            services.AddScoped<ICartQueryService, CartQueryService>();

            services.AddScoped<ICategoryCommandService, CategoryCommandServices>();
            services.AddScoped<ICategoryQueryService, CategoryQueryServices>();

            services.AddScoped<ICustomerCommandService, CustomerCommandService>();
            services.AddScoped<ICustomerQueryService, CustomerQueryService>();

            services.AddScoped<IProductCommandService, ProductCommandServices>();
            services.AddScoped<IProductQueryService, ProductQueryService>();

          

        }
    }
}
