using Microsoft.AspNetCore.Mvc;
using WebStore.Core.Contracts;
using WebStore.Core.Contracts.Admin;
using WebStore.Core.Model.Product;
using static WebStore.Core.Constants.TempDataKeyConstants;

namespace WebStore.MVC.Areas.Admin.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IProductManageService productManageService;
        private readonly IProductService productService;

        public ProductController(
            IProductManageService _productManageService,
            IProductService _productService)
        {
            productManageService = _productManageService;
            productService = _productService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = await productManageService.GetAllProductsAsync();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new ProductAddViewModel();

            ViewBag.Categories = await productManageService.GetAllCategories();
            ViewBag.Brands = await productManageService.GetAllBrands();
            ViewBag.Subcategories = await productManageService.GetAllSubcategories();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(ProductAddViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Categories = await productManageService.GetAllCategories();
                ViewBag.Brands = await productManageService.GetAllBrands();

                TempData[Status.Error] = Product.InvalidInputMessage;

                return View(model);
            }

            await productManageService.AddProductAsync(model);

            TempData[Status.Success] = Product.SuccessOnAddMessage;

            return RedirectToAction("Index", "Home", new {area= ""});
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            try
            {
                var model = await productService.GetProductByIdAsync(id);

                ViewBag.ProductCategories = await productManageService.GetAllCategories();

                return View(model);
            }
            catch (InvalidOperationException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ProductAddViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.ProductCategories = await productManageService.GetAllCategories();

                TempData[Status.Error] = Product.InvalidInputMessage;

                return View(model);
            }

            try
            {
                await productManageService.EditProductAsync(model);

                TempData[Status.Success] = Product.SuccessOnEditMessage;

                return RedirectToAction("Index", "Product");
            }
            catch (InvalidOperationException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                await productManageService.DeleteProductAsync(id);

                return RedirectToAction("Index", "Home");
            }
            catch (InvalidOperationException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
