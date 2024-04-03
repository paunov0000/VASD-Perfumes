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
        public async Task<IActionResult> Index([FromQuery] int count = 10)
        {
            var model = await productManageService.GetProducts(count);

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

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            try
            {
                var model = await productService.GetProductByIdAsync(id);

                ViewBag.Subcategories = await productManageService.GetAllSubcategories();
                ViewBag.Brands = await productManageService.GetAllBrands();
                ViewBag.Categories = await productManageService.GetAllCategories();

                return View(model);
            }
            catch (NullReferenceException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ProductAddViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Subcategories = await productManageService.GetAllSubcategories();
                ViewBag.Brands = await productManageService.GetAllBrands();
                ViewBag.Categories = await productManageService.GetAllCategories();

                TempData[Status.Error] = Product.InvalidInputMessage;

                return View(model);
            }

            try
            {
                await productManageService.EditProductAsync(model);

                TempData[Status.Success] = Product.SuccessOnEditMessage;

                return RedirectToAction("Index", "Product");
            }
            catch (NullReferenceException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Restock()
        {
            ViewBag.Products = await productManageService.GetAllProductsAsync();

            var model = new ProductRestockViewModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Restock(ProductRestockViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Products = await productManageService.GetAllProductsAsync();

                return View(model);
            }

            try
            {
                await productManageService.RestockProductAsync(model.Id, model.Count);

                TempData[Status.Success] = Product.SuccessOnRestockMessage; //TODO: Make it a success on action generic message

                return RedirectToAction("Index", "Product");
            }
            catch (NullReferenceException ex)
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
