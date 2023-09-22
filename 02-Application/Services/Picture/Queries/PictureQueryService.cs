using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Domain.Contract.IRepositories;
using _01_Domain.Contract.IServices.PictureService.Queries;
using EShop.Domain.DTOs.Picture;

namespace _02_Application.Services.Picture.Queries
{
    public class PictureQueryService : IPictureQueryService
    {
        private readonly IPictureRepository _pictureRepository;
        public PictureQueryService(IPictureRepository pictureRepository)
        {
                _pictureRepository = pictureRepository;
        }
        public Task<List<PictureOutPutDto>> GetPictureById(int id)
        {
            
        }

        public Task<List<PictureOutPutDto>> GetPictureByProductId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
