using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static WebStore.Areas.Admin.Constants.AdminConstants;

namespace WebStore.Areas.Admin.Controllers
{
    [Authorize(Roles = AdminRoleName)]
    [Area(AdminAreaName)]
    public class BaseController : Controller
    {
    }
}
