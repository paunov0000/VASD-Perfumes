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

        public async Task<IActionResult> Index()
        {
            var model = await productService.GetAllProductsAsync(isDeleted: true);

            return View(model);
        }

        //[Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new ProductAddViewModel();

            ViewBag.ProductCategories = await productService.GetAllProductCategories();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(ProductAddViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.ProductCategories = await productService.GetAllProductCategories();

                TempData[Status.Error] = Product.InvalidInputMessage;

                return View(model);
            }

            await productService.AddProductAsync(model);

            TempData[Status.Success] = Product.SuccessOnAddMessage;

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            try
            {
                var model = await productService.GetProductByIdAsync(id);

                ViewBag.ProductCategories = await productService.GetAllProductCategories();

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
                ViewBag.ProductCategories = await productService.GetAllProductCategories();

                TempData[Status.Error] = Product.InvalidInputMessage;

                return View(model);
            }

            try
            {
                await productService.EditProductAsync(model);

                TempData[Status.Success] = Product.SuccessOnEditMessage;

                return RedirectToAction("Index", "Home");
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
                await productService.DeleteProductAsync(id);

                return RedirectToAction("Index", "Home");
            }
            catch (InvalidOperationException ex)
            {
                return NotFound(ex.Message);
            }
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
