using EShop.Domain.DTOs.Picture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Domain.Contract.IServices.PictureService.Queries
{
    public interface IPictureQueryService 
    {
        Task<List<PictureOutPutDto>> GetPictureByProductId(int id);
        Task<PictureOutPutDto> GetPictureById(int id);
    }
}
