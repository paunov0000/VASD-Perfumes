using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebStore.Core.Contracts;
using WebStore.Core.Model.Product;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService productService;
        private readonly IBrandService brandService;

        public HomeController(
            ILogger<HomeController> logger,
            IProductService _productService,
            IBrandService _brandService)
        {
            _logger = logger;
            productService = _productService;
            brandService = _brandService;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var countToFetch = 12;

            var mostRecent = await productService.GetMostRecent(countToFetch);
            var mostSold = await productService.GetMostSold(countToFetch);
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
