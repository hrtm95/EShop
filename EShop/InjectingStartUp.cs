
using EShop.Application.Services.UserService;
using EShop.Data.Repository;
using EShop.Domain.IRepositories;
using EShop.Domain.IServices.AdminService.Command;
using EShop.Domain.IServices.AdminService.Queries;
using EShop.Domain.IServices.CartService.Command;
using EShop.Domain.IServices.CartService.Queries;
using EShop.Domain.IServices.CategoryService.Command;
using EShop.Domain.IServices.CategoryService.Queries;
using EShop.Domain.IServices.CustomerService.Command;
using EShop.Domain.IServices.CustomerService.Queries;
using EShop.Domain.IServices.ProductService.Commands;
using EShop.Domain.IServices.ProductService.Queries;
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
