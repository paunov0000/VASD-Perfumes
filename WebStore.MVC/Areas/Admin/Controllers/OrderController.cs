using Microsoft.AspNetCore.Mvc;
using WebStore.Core.Contracts.Admin;
using WebStore.Core.Services.Admin;

namespace WebStore.MVC.Areas.Admin.Controllers
{
    public class OrderController : BaseController
    {
        private readonly IOrderManageService orderManageService;

        public OrderController(IOrderManageService _orderManageService)
        {
            orderManageService = _orderManageService;
        }

        public async Task<IActionResult> Index([FromQuery] int count = 0, [FromQuery] string sort = "date-asc")
        {
            var model = await orderManageService.GetAllOrders(count, sort);

            return View(model);
        }
    }
}
