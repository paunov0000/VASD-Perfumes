using Microsoft.AspNetCore.Mvc;
using WebStore.Core.Contracts.Admin;
using WebStore.Core.Model.Admin.Order;
using WebStore.Core.Model.Admin.Product;
using WebStore.Core.Services.Admin;

namespace WebStore.Areas.Admin.Controllers
{
    public class OrderController : BaseController
    {
        private readonly IOrderManageService orderManageService;

        public OrderController(IOrderManageService _orderManageService)
        {
            orderManageService = _orderManageService;
        }

        [HttpGet]
        public async Task<IActionResult> Index([FromQuery] int count = 0, [FromQuery] string sort = "date-asc")
        {
            var model = await orderManageService.GetAllOrders(count, sort);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var entity = await orderManageService.GetOrderById(id);

            var model = new OrderFormModel()
            {
                OrderStatusId = entity.OrderStatusId,
                Products = entity.Products.Select(p => new ProductOrderModel()
                {
                    Name = p.Name
                }),
            };

            ViewBag.OrderStatuses = await orderManageService.GetAllOrderStatuses();

            return View(model);
        }
    }
}
