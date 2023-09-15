using _01_Domain.Contract.IRepositories;
using _01_Domain.Contract.IServices.CategoryService.Queries;
using EShop.Domain.DTOs.Category;

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
