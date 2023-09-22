using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Domain.Contract.IRepositories;
using _01_Domain.Contract.IServices.PictureService.Commands;
using EShop.Domain.DTOs.Picture;

namespace _02_Application.Services.Picture.Command
{
    public class PictureCommandService : IPictureCommandService
    {
        private readonly IPictureRepository _pictureRepository;
        public PictureCommandService(IPictureRepository pictureRepository)
        {
            _pictureRepository = pictureRepository;
        }
        public Task<bool> AddByProductId(PictureAddDto pictureAddDto, int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreatePicture(PictureAddDto pictureAddDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletePicture(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdatePicture(PictureEditDto pictureAddDto)
        {
            throw new NotImplementedException();
        }
    }
}
