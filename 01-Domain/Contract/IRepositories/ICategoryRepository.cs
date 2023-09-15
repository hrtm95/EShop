using EShop.Domain.DTOs;
using EShop.Domain.DTOs.Category;

namespace _01_Domain.Contract.IRepositories
{
    public interface ICategoryRepository
    {
        Task<GeneralDto<bool>> Create(CategoryAddDto category);
        Task<GeneralDto<bool>> Update(CategoryEditDto category);
        Task<GeneralDto<bool>> Delete(int categoryId);
        Task<CategoryOutputDto> GetById(int id);
        Task<List<CategoryOutputDto>> GetAll();
    }
}
