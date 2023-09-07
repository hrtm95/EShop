using EShop.Domain.DTOs;
using EShop.Domain.DTOs.Category;

namespace EShop.Domain.IRepositories
{
    public interface ICategoryRepository
    {
        Task<GeneralDto<bool>> Create(CategoryAddDto category);
        Task<GeneralDto<bool>> Update(CategoryEditDto category);
        Task<GeneralDto<bool>> Delete(int categoryId);
        Task<GeneralDto<CategoryOutputDto>> GetById(int categoryId);
        Task<GeneralDto<List<CategoryOutputDto>>> GetAll();
    }
}
