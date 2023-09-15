using _01_Domain.Contract.IServices.ProductService.Commands;
using _01_Domain.Contract.IServices.ProductService.Queries;
using Microsoft.AspNetCore.Mvc;

namespace EShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductCommandService _productCommandService;
        private readonly IProductQueryService _productQueryService;
        public ProductController(IProductCommandService productCommandService , IProductQueryService productQueryService)
        {
            _productCommandService = productCommandService;
            _productQueryService = productQueryService;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _productQueryService.GetAllProducts();
            return View(products);
        }
    }
}
