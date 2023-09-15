using _01_Domain.Contract.IRepositories;
using EShop.Domain.DTOs;
using EShop.Domain.DTOs.Cart;
using EShop.Domain.DTOs.Category;
using EShop.Domain.DTOs.Product;
using EShop.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace EShop.Data.Repository
{
    public class CategoyRepository : ICategoryRepository
    {
        private readonly EshopContext _context;

        public CategoyRepository(EshopContext context)
        {
            _context = context;
        }
        public async Task<GeneralDto<bool>> Create(CategoryAddDto categoryDto)
        {
            var category = new Category()
            {
                Name = categoryDto.Name,
                Description = categoryDto.Description
            };
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
            return new GeneralDto<bool> { Id = category.Id, Data = true };
        }
        public async Task<GeneralDto<bool>> Delete(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            category.IsDeleted = true;
            int number = await _context.SaveChangesAsync();
            if (number == 0)
            {
                return new GeneralDto<bool> { Id = id, Data = false };
            }
            return new GeneralDto<bool> { Id = id, Data = true };
        }

        public async Task<List<CategoryOutputDto>> GetAll()
        {
            var category = await _context.Categories.AsNoTracking().Include(c => c.Products)
                .Select(p => new CategoryOutputDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,

                    Products = p.Products.Select(C => new ProductOutPutDto { Name = C.Name, Description = C.Description }).ToList()
                }).ToListAsync();

            return category;
        }

        public async Task<CategoryOutputDto> GetById(int id)
        {
            var category = await _context.Categories.FirstOrDefaultAsync(p => p.Id == id);
            var output = new CategoryOutputDto
            {
                Id = id,
                Name = category.Name,
                Description = category.Description
            };
            return output;
        }

        public async Task<GeneralDto<bool>> Update(CategoryEditDto dto)
        {
            var entity = _context.Categories.Find(dto.Id);
            entity.Name = dto.Name;
            entity.Description = dto.Description;
            _context.Entry(entity).State = EntityState.Modified;
            int number = await _context.SaveChangesAsync();
            if (number == 0)
            {
                return new GeneralDto<bool> { Id = entity.Id, Data = false };
            }
            return new GeneralDto<bool> { Id = entity.Id, Data = true };
        }


    }
}
