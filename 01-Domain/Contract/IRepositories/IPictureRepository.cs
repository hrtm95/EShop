using EShop.Domain.DTOs;
using EShop.Domain.DTOs.Picture;
using EShop.Domain.Entity;

namespace _01_Domain.Contract.IRepositories
{
    public interface IPictureRepository
    {
        Task<GeneralDto<bool>> Create(PictureAddDto picture);
        Task<GeneralDto<bool>> Update(PictureEditDto picture);
        Task<GeneralDto<bool>> Delete(int pictureId);
        Task<GeneralDto<PictureOutPutDto>> GetById(int pictureId);
        Task<GeneralDto<List<PictureOutPutDto>>> GetAll();
    }
}
