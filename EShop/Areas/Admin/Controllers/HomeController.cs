using EShop.Domain.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace EShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly IProductRepository productRepository;

        public HomeController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IActionResult Index()
        {
            return View("Index");
        }
    }
}
