using EShop.Domain.DTOs.Category;
using EShop.Domain.IRepositories;
using EShop.Domain.IServices.CategoryService.Queries;

namespace EShop.Domain.Services.Category.Queries
{
    public class CategoryQueryServices : ICategoryQueryService
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryQueryServices(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public async Task<List<CategoryOutputDto>> GetAllCategory()
        {
            return await categoryRepository.GetAll();
        }
    }
}
