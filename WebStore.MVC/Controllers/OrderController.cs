using Microsoft.AspNetCore.Mvc;

namespace WebStore.MVC.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
