using EShop.Domain.DTOs.Category;
using EShop.Domain.IRepositories;
using EShop.Domain.IServices.CategoryService.Command;

namespace EShop.Domain.Services.Category.Command
{
    public class CategoryCommandServices : ICategoryCommandService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryCommandServices(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public Task<bool> AddPicture(int PictureId, int item)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> CreateCategory(CategoryAddDto category)
        {
            var result = await _categoryRepository.Create(category);
            return result.Data;
        }

        public async Task<bool> DeleteCategory(int catrguryId)
        {
            var result = await _categoryRepository.Delete(catrguryId);
            return result.Data;
        }

        public async Task<bool> EditCategory(CategoryEditDto category)
        {
            var result = await _categoryRepository.Update(category);
            return result.Data;
        }
    }
}
