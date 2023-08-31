using EShop.Domain.DTOs;
using EShop.Domain.Entity;

namespace EShop.Domain.IServices.ProductService.Commands
{
    public interface IProductCommandService
    {
        Task<bool> CreateProduct(ProductAddDto product);
        Task<bool> DeleteProduct(int productId);
        Task<bool> EditeProduct(ProductEditDto product);
        Task<bool> AddProductToCartByProductid(int customerid, int productid);
        Task<bool> DeleteProductFromCart(int cartId, int productId);
    }
}
