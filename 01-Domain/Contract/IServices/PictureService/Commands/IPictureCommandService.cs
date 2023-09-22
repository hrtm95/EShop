using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using EShop.Domain.DTOs.Picture;

namespace _01_Domain.Contract.IServices.PictureService.Commands
{
    public interface IPictureCommandService
    {
      Task<bool> CreatePicture(PictureAddDto  pictureAddDto);
      Task<bool> UpdatePicture(PictureEditDto pictureAddDto);
      Task<bool> DeletePicture(int id);
      //Task<bool> AddByProductId(PictureAddDto pictureAddDto, int id);


    }
}
