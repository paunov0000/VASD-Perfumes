using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static WebStore.MVC.Areas.Admin.Constants.AdminConstants;

namespace WebStore.MVC.Areas.Admin.Controllers
{
    [Authorize(Roles = AdminRoleName)]
    [Area(AdminAreaName)]
    public class BaseController : Controller
    {
    }
}
