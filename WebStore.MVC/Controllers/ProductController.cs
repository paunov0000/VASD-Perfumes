using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebStore.Core.Contracts;
using WebStore.Core.Model.Product;
using static WebStore.Core.Constants.TempDataKeyConstants;

namespace WebStore.MVC.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Index(string search = "")
        {
            IEnumerable<ProductViewModel> model;

            if (string.IsNullOrEmpty(search))
            {
                model = await productService.GetAllProductsAsync();
            }
            else
            {
                model = await productService.GetFilteredProductsAsync(search);

                if (model.Count() == 0)
                {
                    TempData[Status.Error] = "Няма намерени резултати";
                }
            }

            return View(model);
        }

        

        [HttpGet]
        public async Task<IActionResult> Details(Guid id)
        {
            try
            {
                var model = await productService.GetProductByIdAsync(id);

                return View(model);
            }
            catch (InvalidOperationException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }

}
