using EShop.Domain.DTOs.Category;

namespace _01_Domain.Contract.IServices.CategoryService.Queries
{
    public interface ICategoryQueryService
    {
        Task<List<CategoryOutputDto>> GetAllCategory();
    }
}
