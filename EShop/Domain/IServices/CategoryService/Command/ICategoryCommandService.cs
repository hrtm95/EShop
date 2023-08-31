﻿using EShop.Domain.DTOs;

namespace EShop.Domain.IServices.CategoryService.Command
{
    public interface ICategoryCommandService
    {
        Task<bool> CreateCategory(CategoryAddDto category);
        Task<bool> EditCategory(CategoryEditDto category);
        Task<bool> DeleteCategory(int catrguryId);
    }
}
