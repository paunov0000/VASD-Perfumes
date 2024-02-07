using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebStore.Core.Contracts;
using WebStore.Core.Model.Product;
using WebStore.MVC.Models;

namespace WebStore.MVC.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService productService;

        public HomeController(
            ILogger<HomeController> logger,
            IProductService _productService)
        {
            _logger = logger;
            productService = _productService;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var mostRecent = await productService.Get12MostRecent();
            var mostSold = await productService.GetMostSold();
            var onSale = await productService.GetOnSale();
            var allProducts = await productService.GetAllProductsAsync();

            var model = new ProductHomeViewModel()
            {
                MostRecent = mostRecent,
                MostSold = mostSold,
                OnSale = onSale,
                AllProducts = allProducts
            };

            return View(model);
        }

        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
