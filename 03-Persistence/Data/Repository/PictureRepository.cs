using _01_Domain.Contract.IRepositories;
using EShop.Domain.DTOs;
using EShop.Domain.DTOs.Picture;
using EShop.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace EShop.Data.Repository
{
    public class PictureRepository : IPictureRepository
    {
        private readonly EshopContext _context;
        public PictureRepository(EshopContext context)
        {
            _context = context;
        }
        public async Task<GeneralDto<bool>> Create(PictureAddDto picture)
        {
            Picture pictures = new Picture()
            {
                LinsAddress = picture.LinkAddress,
                ProductId = picture.ProductId,

            };
            await _context.Pictures.AddAsync(pictures);
            int save = await _context.SaveChangesAsync();
            bool check = false;
            if (save > 0)
            {
                check = true;
            }
            return new GeneralDto<bool> { Id = pictures.Id, Data = check };

        }

        public async Task<GeneralDto<bool>> Delete(int pictureId)
        {
            var IsDelete = await _context.Pictures.FirstOrDefaultAsync(p => p.Id == pictureId);
            if (IsDelete == null)
            {
                return new GeneralDto<bool> { Id = pictureId, Data = false };
            }
            else
            {
                _context.Pictures.Remove(IsDelete);
                _context.SaveChanges();
                return new GeneralDto<bool> { Id = pictureId, Data = true };
            }
        }

        public async Task<List<PictureOutPutDto>> GetAll()
        {
            var picture = await _context.Pictures.AsNoTracking()
                .Select(p => new PictureOutPutDto()
                {
                    Id = p.Id,
                    LinkAddress = p.LinsAddress,
                    ProductId = p.ProductId,
                }).ToListAsync();

            return picture;

        }

        public async Task<PictureOutPutDto> GetById(int pictureId)
        {
            var getByID = await _context.Pictures.FirstOrDefaultAsync(p => p.Id == pictureId);
            var output = new PictureOutPutDto()
            {
                Id = pictureId,
                LinkAddress = getByID.LinsAddress,
                ProductId = getByID.ProductId,
            };
            return output;
        }

        public async Task<GeneralDto<bool>> Update(PictureEditDto picture)
        {
            var entity = _context.Pictures.Find(picture.Id);
            entity.LinsAddress = picture.LinkAddress;
            _context.Entry(entity).State = EntityState.Modified;
            int number = await _context.SaveChangesAsync();
            if (number == 0)
            {
                return new GeneralDto<bool> { Id = picture.Id, Data = false };
            }
            return new GeneralDto<bool> { Id = picture.Id, Data = true };
        }
    }

}
