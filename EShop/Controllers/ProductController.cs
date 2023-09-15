using _01_Domain.Contract.IServices.ProductService.Commands;
using _01_Domain.Contract.IServices.ProductService.Queries;
using EShop.Domain.DTOs.Product;
using EShop.Domain.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;

namespace EShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductCommandService _productCommandService;
        private readonly IProductQueryService _productQueryService;
        public ProductController(IProductCommandService productCommandService, IProductQueryService productQueryService)
        {
            _productCommandService = productCommandService;
            _productQueryService = productQueryService;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _productQueryService.GetAllProducts();
            return View(products);
        }


        public async Task<IActionResult> Edit(int Id)
        {
            var productUpdate = await _productQueryService.GetById(Id);
            if (productUpdate != null)
            {
                return View(productUpdate);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ProductOutPutDto productOutPutDto, int Id)
        {
            var productUpdate = await _productQueryService.GetById(Id);

            if (productUpdate != null)
            {
                var Edit = new ProductEditDto
                {
                    Id = productOutPutDto.Id,
                    Name = productOutPutDto.Name,
                    Description = productOutPutDto.Description,
                    Price = productOutPutDto.Price,
                    Quntity = productOutPutDto.Quntity
                };
                await _productCommandService.EditeProduct(Edit);
                return RedirectToAction("Index");
            }
            return View(productUpdate);
        }

        public async Task<IActionResult> Delete(int Id)
        {
            await _productCommandService.DeleteProduct(Id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Detail(int Id)
        {
           var product =  await _productQueryService.GetById(Id);
            return View(product);
        }
    }
}
