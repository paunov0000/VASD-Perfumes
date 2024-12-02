using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebStore.Core.Model.Product;
using static WebStore.Core.Constants.TempDataKeyConstants;

namespace WebStore.Controllers
{
    public class CartController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var productModels = new List<ProductCartViewModel>();

            if (TempData["CartItems"] != null)
            {
                productModels = JsonConvert.DeserializeObject<List<ProductCartViewModel>>(TempData["CartItems"].ToString());
            }

            return View(productModels);
        }

        [HttpPost]
        public void FetchCartItems([FromBody] List<ProductCartViewModel> cartItems)
        {
            TempData["CartItems"] = JsonConvert.SerializeObject(cartItems);
        }
    }
}
