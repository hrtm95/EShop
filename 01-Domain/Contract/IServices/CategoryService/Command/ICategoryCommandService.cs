﻿using EShop.Domain.DTOs.Category;

namespace _01_Domain.Contract.IServices.CategoryService.Command
{
    public interface ICategoryCommandService
    {
        Task<bool> CreateCategory(CategoryAddDto category);
        Task<bool> EditCategory(CategoryEditDto category);
        Task<bool> DeleteCategory(int catrguryId);
        Task<bool> AddPicture(int PictureId, int item);
    }
}
