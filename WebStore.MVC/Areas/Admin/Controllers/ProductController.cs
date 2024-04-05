using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebStore.Core.Contracts;
using WebStore.Core.Contracts.Admin;
using WebStore.Core.Model.Admin.Product;
using WebStore.Core.Model.Product;
using WebStore.Infrastructure.Data.Entities;
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
        public async Task<IActionResult> Index([FromQuery] int count = 0, [FromQuery] string? sort = "name-asc")
        {
            IQueryable<Infrastructure.Data.Entities.Product> model;

            if (count == 0)
            {
                model = productManageService.GetIQueryableProducts();
            }
            else
            {
                model = productManageService.GetIQueryableProducts(count);
            }


            model = sort switch                                                                 //TODO: extract this to a method in the service
            {                                                                                   //TODO: extract this to a method in the service
                "name-asc" => model.OrderBy(p => p.Name),                                       //TODO: extract this to a method in the service
                "name-desc" => model.OrderByDescending(p => p.Name),                            //TODO: extract this to a method in the service
                "brand-asc" => model.OrderBy(p => p.Brand.Name),                                //TODO: extract this to a method in the service
                "brand-desc" => model.OrderByDescending(p => p.Brand.Name),                     //TODO: extract this to a method in the service
                "price-asc" => model.OrderBy(p => p.Price),                                     //TODO: extract this to a method in the service
                "price-desc" => model.OrderByDescending(p => p.Price),                          //TODO: extract this to a method in the service
                "quantity-asc" => model.OrderBy(p => p.Quantity),                               //TODO: extract this to a method in the service
                "quantity-desc" => model.OrderByDescending(p => p.Quantity),                    //TODO: extract this to a method in the service
                "category-asc" => model.OrderBy(p => p.Category.Name),                          //TODO: extract this to a method in the service
                "category-desc" => model.OrderByDescending(p => p.Category.Name),               //TODO: extract this to a method in the service
                "subcategory-asc" => model.OrderBy(p => p.Subcategory.Name),                    //TODO: extract this to a method in the service
                "subcategory-desc" => model.OrderByDescending(p => p.Subcategory.Name),         //TODO: extract this to a method in the service
                "soldcount-asc" => model.OrderBy(p => p.SoldCount),                             //TODO: extract this to a method in the service
                "soldcount-desc" => model.OrderByDescending(p => p.SoldCount),                  //TODO: extract this to a method in the service
                "onsale-f" => model.OrderBy(p => p.OnSale),                                     //TODO: extract this to a method in the service
                "onsale-t" => model.OrderByDescending(p => p.OnSale),                           //TODO: extract this to a method in the service
                                                                                                //TODO: extract this to a method in the service
                _ => model.OrderBy(p => p.Name),                                                //TODO: extract this to a method in the service
            };                                                                                  //TODO: extract this to a method in the service

            var result = await model.Select(p => new ProductTableModel()
        {
                Id = p.Id,
                Name = p.Name,
                BrandName = p.Brand.Name,
                Price = p.Price,
                SoldCount = p.SoldCount,
                CategoryName = p.Category.Name,
                SubcategoryName = p.Subcategory.Name,
                OnSale = p.OnSale,
                Quantity = p.Quantity,
                IsActive = p.IsActive
            }).ToListAsync();


            //var model = await productManageService.GetProducts(count);

            return View(result);
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

                TempData[Status.Error] = Core.Constants.TempDataKeyConstants.Product.InvalidInputMessage;

                return View(model);
            }

            await productManageService.AddProductAsync(model);

            TempData[Status.Success] = Core.Constants.TempDataKeyConstants.Product.SuccessOnAddMessage;

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

                TempData[Status.Error] = Core.Constants.TempDataKeyConstants.Product.InvalidInputMessage;

                return View(model);
            }

            try
            {
                await productManageService.EditProductAsync(model);

                TempData[Status.Success] = Core.Constants.TempDataKeyConstants.Product.SuccessOnEditMessage;

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

                TempData[Status.Success] = Core.Constants.TempDataKeyConstants.Product.SuccessOnRestockMessage; //TODO: Make it a success on action generic message

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
