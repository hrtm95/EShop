using EShop.Domain.DTOs;
using EShop.Domain.Entity;

namespace EShop.Domain.IServices.ProductService.Queries
{
    public interface IProductQueryService
    {
        Task<List<ProductOutPutDto>> GetAllProducts();
        Task<List<ProductOutPutDto>> GetProductsByCategoryId(int categoryId);
        Task<List<ProductOutPutDto>> SeachInProduct(string name);
    }
}
