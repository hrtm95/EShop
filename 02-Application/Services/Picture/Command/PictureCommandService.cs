using _01_Domain.Contract.IRepositories;
using _01_Domain.Contract.IServices.PictureService.Commands;
using EShop.Domain.DTOs.Picture;
using EShop.Domain.DTOs.Product;

namespace _02_Application.Services.Picture.Command
{
    public class PictureCommandService : IPictureCommandService
    {
        private readonly IPictureRepository _pictureRepository;
        private readonly IProductRepository _productRepository;

        public PictureCommandService(IPictureRepository pictureRepository, IProductRepository productRepository)
        {
            _pictureRepository = pictureRepository;
            _productRepository = productRepository;
        }

        public async Task<bool> AddByProductId(PictureEditDto pictureEditDto, int id)
        {
            var product = await _productRepository.GetById(id);
            product.Pictures.Add(new PictureOutPutDto
            {
                LinkAddress = pictureEditDto.LinkAddress,
                ProductId = product.Id,
            });
            var Result = await _productRepository.Update(
                new ProductEditDto
                {
                    Id = product.Id,
                    Name = product.Name,
                    CategoryId = product.CategoryId,
                    Description = product.Description,
                    Price = product.Price,
                    Quntity = product.Quntity,
                    pictureOutPuts = product.Pictures
                }
                );
            return Result.Data;
        }

        public async Task<bool> CreatePicture(PictureAddDto pictureAddDto)
        {
            var res = await _pictureRepository.Create(pictureAddDto);
            return res.Data;
        }

        public async Task<bool> DeletePicture(int id)
        {
            var res = await _pictureRepository.Delete(id);
            return res.Data;
        }

        public async Task<bool> UpdatePicture(PictureEditDto pictureAddDto)
        {
            var res = await _pictureRepository.Update(pictureAddDto);
            return res.Data;
        }
    }
}
