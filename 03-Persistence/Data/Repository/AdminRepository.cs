using _01_Domain.Contract.IRepositories;
using EShop.Domain.DTOs;
using EShop.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace EShop.Data.Repository
{
    public class AdminRepository : IAdminRepository
    {
        private readonly EshopContext _context;

        public AdminRepository(EshopContext context)
        {
            _context = context;
        }

        public async Task<GeneralDto<bool>> Update(AdminEditDto dto)
        {
            var entity = _context.Admins.Find(dto.Id);
            entity.Name = dto.Name;
            entity.LastName = dto.LastName;

            _context.Entry(entity).State = EntityState.Modified;
            int number = await _context.SaveChangesAsync();
            if (number == 0)
            {
                return new GeneralDto<bool> { Id = entity.Id, Data = false };
            }
            return new GeneralDto<bool> { Id = entity.Id, Data = true };
        }

        public async Task<bool> IsExistAdmin(string personalCode)
        {
            var admin =await _context.Admins.SingleOrDefaultAsync(a => a.PersonalCode == personalCode);
            return (admin != null);
        }
    }
}
