using EShop.Domain.DTOs;
using EShop.Domain.DTOs.Product;

namespace _01_Domain.Contract.IRepositories
{
    public interface IProductRepository
    {
        Task<GeneralDto<bool>> Create(ProductAddDto product);
        Task<GeneralDto<bool>> Update(ProductEditDto product);
        Task<GeneralDto<bool>> Delete(int productId);
        Task<ProductOutPutDto> GetById(int productId);
        Task<List<ProductOutPutDto>> GetAll();
    }
}
