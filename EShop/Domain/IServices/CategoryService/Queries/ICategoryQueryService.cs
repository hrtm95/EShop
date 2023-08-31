using EShop.Domain.DTOs;

namespace EShop.Domain.IServices.CategoryService.Queries
{
    public interface ICategoryQueryService
    {
        Task<List<CategoryOutputDto>> GetAllCategory();
    }
}
