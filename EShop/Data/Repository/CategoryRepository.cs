using EShop.Domain.DTOs;
using EShop.Domain.DTOs.Category;
using EShop.Domain.IRepositories;

namespace EShop.Data.Repository
{
    public class CategoyRepository : ICategoryRepository
    {
        public Task<GeneralDto<bool>> Create(CategoryAddDto category)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralDto<bool>> Delete(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralDto<List<CategoryOutputDto>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<GeneralDto<CategoryOutputDto>> GetById(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralDto<bool>> Update(CategoryEditDto category)
        {
            throw new NotImplementedException();
        }
    }
}
