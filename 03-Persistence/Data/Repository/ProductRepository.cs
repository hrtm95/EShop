using EShop.Domain.DTOs;
using EShop.Domain.DTOs.Category;
using EShop.Domain.DTOs.Product;
using EShop.Domain.Entity;
using EShop.Domain.IRepositories;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace EShop.Data.Repository;

public class ProductRepository : IProductRepository
{
    private readonly EshopContext _context;

    public ProductRepository(EshopContext context)
    {
        _context = context;
    }

    public async Task<GeneralDto<bool>> Create(ProductAddDto productdto)
    {
        var product = new Product() {
            Name = productdto.Name,
            Description = productdto.Description,
            Price = productdto.Price,
            Quntity = productdto.Quntity,
            CategoryId = productdto.CategoryId,
        };
        await _context.Products.AddAsync(product);
        await _context.SaveChangesAsync();
        return new GeneralDto<bool> { Id = product.Id, Data = true};
        
    }

    public async Task<GeneralDto<bool>> Delete(int productId)    {

        var product  = await _context.Products.FindAsync(productId);
        product.IsDeleted = true;
        int number = await _context.SaveChangesAsync();
        if (number == 0)
        {
            return new GeneralDto<bool> { Id = product.Id, Data = false };
        }
        return new GeneralDto<bool> { Id = product.Id, Data = true };

    }
    
    public async Task<List<ProductOutPutDto>> GetAll()
    {
        var products = await _context.Products.AsNoTracking().Include(c => c.Categories).Select(p => new ProductOutPutDto { 
            Id = p.Id,
            Name = p.Name,
            Description = p.Description,
            Quntity = p.Quntity,
            CategoryId = p.CategoryId,
            Price = p.Price,
            Category = p.Categories.Select(C => new GeneralCategoryDto { Name = C.Name, Description = C.Description}).ToList(),
        }).ToListAsync();

        return products;

    }

    public async Task<ProductOutPutDto> GetById(int productId)
    {
        var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == productId);
        var output = new ProductOutPutDto
        {
            Id = product.Id,
            Name = product.Name,
            Description = product.Description,
            Quntity = product.Quntity,
            CategoryId = product.CategoryId,
            Price = product.Price,
        };
        return output;
    }

    public async Task<GeneralDto<bool>> Update(ProductEditDto productdto)
    {
        var entity = _context.Products.Find(productdto.Id);

            entity.Name = productdto.Name;
            entity.Description = productdto.Description;
            entity.Price = productdto.Price;
            entity.Quntity = productdto.Quntity;
            entity.CategoryId = productdto.CategoryId;

        _context.Entry(entity).State = EntityState.Modified;
        int number = await _context.SaveChangesAsync();
        if (number == 0)
        {
            return new GeneralDto<bool> { Id = entity.Id, Data = false };
        }
        return new GeneralDto<bool> { Id = entity.Id, Data = true };
    }
}
