using EShop.Domain.DTOs;
using EShop.Domain.DTOs.Product;

namespace EShop.Domain.IRepositories
{
    public interface IProductRepository
    {
        Task<GeneralDto<bool>> Create(ProductAddDto product);
        Task<GeneralDto<bool>> Update(ProductEditDto product);
        Task<GeneralDto<bool>> Delete(int productId);
        Task<GeneralDto<ProductOutPutDto>> GetById(int productId);
        Task<List<ProductOutPutDto>> GetAll();
    }
}
