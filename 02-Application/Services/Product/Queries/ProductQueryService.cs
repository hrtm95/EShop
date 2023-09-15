using _01_Domain.Contract.IRepositories;
using _01_Domain.Contract.IServices.ProductService.Queries;
using EShop.Domain.DTOs.Product;
using EShop.Domain.Entity;

namespace EShop.Domain.Services.Product.Queries
{
    public class ProductQueryService : IProductQueryService
    {
        private readonly IProductRepository productRepository;
        private readonly ICategoryRepository categoryRepository;

        public ProductQueryService(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            this.productRepository = productRepository;
            this.categoryRepository = categoryRepository;
        }

        public async Task<List<ProductOutPutDto>> GetAllProducts()
        {
            var getAllProduct = await productRepository.GetAll();
            if (getAllProduct != null)
            {
                return getAllProduct;
            }
            return null;
        }

        public async Task<List<ProductOutPutDto>> GetProductsByCategoryId(int categoryId)
        {
            var products = (await productRepository.GetAll()).Where(x => x.CategoryId == categoryId).ToList();
            return products;
        }

        public async Task<List<ProductOutPutDto>> SeachInProduct(string name)
        {
            var products = (await productRepository.GetAll()).Where(x => x.Name == name).ToList();
            return products;
        }
    }
}
