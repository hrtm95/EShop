using EShop.Domain.DTOs.Product;
using EShop.Domain.Entity;

namespace _01_Domain.Contract.IServices.ProductService.Queries
{
    public interface IProductQueryService
    {
        Task<List<ProductOutPutDto>> GetAllProducts();
        Task<List<ProductOutPutDto>> GetProductsByCategoryId(int categoryId);
        Task<List<ProductOutPutDto>> SeachInProduct(string name);
        Task <ProductOutPutDto> GetById(int productId);
    }
}
