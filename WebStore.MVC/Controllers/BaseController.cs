using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebStore.MVC.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {

    }
}
