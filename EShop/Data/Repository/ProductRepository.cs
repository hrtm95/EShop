using EShop.Domain.DTOs;
using EShop.Domain.IRepositories;

namespace EShop.Data.Repository;

public class ProductRepository : IProductRepository
{
    public Task<GeneralDto<bool>> Create(ProductAddDto product)
    {

        throw new NotImplementedException();
    }

    public Task<GeneralDto<bool>> Delete(int productId)
    {
        throw new NotImplementedException();
    }

    public Task<GeneralDto<List<ProductOutPutDto>>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<GeneralDto<ProductOutPutDto>> GetById(int productId)
    {
        throw new NotImplementedException();
    }

    public Task<GeneralDto<bool>> Update(ProductEditDto product)
    {
        throw new NotImplementedException();
    }
}
