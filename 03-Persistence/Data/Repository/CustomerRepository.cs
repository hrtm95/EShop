using _01_Domain.Contract.IRepositories;
using EShop.Domain.DTOs;
using EShop.Domain.DTOs.Category;
using EShop.Domain.DTOs.Customer;
using EShop.Domain.DTOs.Product;
using EShop.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace EShop.Data.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly EshopContext _context;

        public CustomerRepository(EshopContext context)
        {
            _context = context;
        }

        public async Task<GeneralDto<bool>> Create(CustomerAddDto customerDto , ApplicationUser user)
        {

            var customer = new Customer()
            {
                Name = customerDto.Name,
                LastName = customerDto.LastName,
                IsActive = true,
                Address = customerDto.Address,
                User = user,
                UserId = user.Id
            };
            await _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();
            return new GeneralDto<bool> { Id = customer.Id, Data = true };
        }

        public async Task<GeneralDto<bool>> Delete(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            customer.IsDeleted = true;
            int number = await _context.SaveChangesAsync();
            if (number == 0)
            {
                return new GeneralDto<bool> { Id = id, Data = false };
            }
            return new GeneralDto<bool> { Id = id, Data = true };
        }

        public async Task<List<CustomerOutPutDto>> GetAll()
        {
            var category = await _context.Customers.AsNoTracking()
                .Select(p => new CustomerOutPutDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    LastName = p.LastName,
                    Address = p.Address,

                }).ToListAsync();

            return category;
        }

        public Task<GeneralDto<CustomerOutPutDto>> GetById(int customerId)
        {
            throw new NotImplementedException();
        }

        public async Task<GeneralDto<bool>> Update(CustomerEditDto dto)
        {
            var entity = _context.Customers.Find(dto.Id);
            entity.Name = dto.Name;
            entity.LastName = dto.LastName;
            entity.Address = dto.Address;
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
