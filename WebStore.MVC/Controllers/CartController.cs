using Microsoft.AspNetCore.Mvc;
using WebStore.Core.Model.Product;
using static WebStore.Core.Constants.TempDataKeyConstants;

namespace WebStore.Controllers
{
    public class CartController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index([FromBody] List<ProductCartViewModel> productsJson)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }

            return View(productsJson);
        }
    }
}
