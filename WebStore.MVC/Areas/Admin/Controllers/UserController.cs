using Microsoft.AspNetCore.Mvc;
using WebStore.Core.Contracts.Admin;

namespace WebStore.MVC.Areas.Admin.Controllers
{
    public class UserController : BaseController
    {
        private readonly IUserManageService userManageService;

        public UserController(IUserManageService _userManageService)
        {
            userManageService = _userManageService;
        }

        [HttpGet]
        public async Task<IActionResult> Index([FromQuery] int count = 0, [FromQuery] string sort = "userName-asc")
        {
            var model = await userManageService.GetTableUsers(count, sort);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Details(Guid id)
        {
            var model = await userManageService.GetUserByIdAsync(id);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Promote(Guid id)
        {
            try
            {
                await userManageService.PromoteUserAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (NullReferenceException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Demote(Guid id)
        {
            try
            {
                await userManageService.DemoteUserAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (NullReferenceException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Ban(Guid id)
        {
            try
            {
                await userManageService.BanUserAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (NullReferenceException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
