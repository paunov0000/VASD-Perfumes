using Microsoft.AspNetCore.Mvc;
using WebStore.Core.Contracts.Admin;

namespace WebStore.MVC.Areas.Admin.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IProductManageService productManageService;

        public ProductController(IProductManageService _productManageService)
        {
            productManageService = _productManageService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = await productManageService.GetAllProductsAsync();

            return View(model);
        }
    }
}
