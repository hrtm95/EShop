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
        private readonly IProductRepository _productRepository;

        public PictureQueryService(IPictureRepository pictureRepository, IProductRepository productRepository)
        {
            _pictureRepository = pictureRepository;
            _productRepository = productRepository;
        }


        public async Task<PictureOutPutDto> GetPictureById(int id)
        {
            var Result= await _pictureRepository.GetById(id);
            return Result;
        }

        public async Task<List<PictureOutPutDto>> GetPictureByProductId(int id)
        {
            return await _productRepository.GetPictureByProductId(id);
        }
    }
}
