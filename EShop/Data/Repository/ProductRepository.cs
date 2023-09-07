﻿using EShop.Domain.DTOs;
using EShop.Domain.Entity;
using EShop.Domain.IRepositories;

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
        return new GeneralDto<bool> { Id = product.Id, Data = Product };
        
    }

    public Task<GeneralDto<bool>> Delete(int productId)
    {
        throw new NotImplementedException();
    }

    public Task<GeneralDto<List<ProductOutPutDto>>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<GeneralDto<ProductOutPutDto>> GetById(int productId)
    {
        throw new NotImplementedException();
    }

    public Task<GeneralDto<bool>> Update(ProductEditDto product)
    {
        throw new NotImplementedException();
    }
}