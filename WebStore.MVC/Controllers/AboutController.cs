using Microsoft.AspNetCore.Mvc;

namespace WebStore.Controllers
{
    public class AboutController : BaseController
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contacts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Shipping()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Payment()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Terms()
        {
            return View();
        }
    }
}
