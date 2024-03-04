using Microsoft.AspNetCore.Mvc;
using WebStore.Core.Contracts;

namespace WebStore.MVC.Areas.Admin.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IProductService productService;

        public ProductController(IProductService _productService)
        {
            productService = _productService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = await productService.GetAllProductsAsync();

            return View(model);
        }
    }
}
