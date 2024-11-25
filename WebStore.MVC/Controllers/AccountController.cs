using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebStore.Infrastructure.Data.Entities;
using WebStore.Models.Account;
using static WebStore.Core.Constants.ErrorMessageConstants.Account;
using static WebStore.Core.Constants.TempDataKeyConstants.Account;
using static WebStore.Core.Constants.TempDataKeyConstants;
using WebStore.Infrastructure.Common;
using Microsoft.Identity.Client;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using WebStore.Core.Model.Order;
using WebStore.Core.Contracts;

namespace WebStore.Controllers
{
    public class AccountController : BaseController
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IOrderService _orderService;
        private readonly IRepository repo;

        public AccountController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IOrderService orderService,
            IRepository _repo)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            repo = _repo;
            this._orderService = orderService;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(AccountRegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = new ApplicationUser
            {
                Email = model.Email,
                UserName = model.Email,
                CreatedOn = DateTime.UtcNow
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                var customer = new Customer
                {
                    UserId = user.Id,
                };

                await repo.AddAsync<Customer>(customer);
                await repo.SaveChangesAsync();

                await _signInManager.SignInAsync(user, false);

                TempData[Status.Success] = SuccessOnRegisterMessage;

                return RedirectToAction(nameof(HomeController.Index), "Home");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            return View(model);

        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {

            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(AccountLoginViewModel model, string returnUrl = "")
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var result = await _signInManager
                .PasswordSignInAsync(
                model.Email,
                model.Password,
                model.RememberMe,
                false);

            if (result.Succeeded)
            {
                TempData[Status.Success] = SuccessOnLoginMessage;

                if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                {
                    return Redirect(returnUrl);
                }

                return RedirectToAction(nameof(HomeController.Index), "Home");
            }

            //ModelState.AddModelError(string.Empty, InvalidCredentialsMessage);

            TempData[Status.Error] = InvalidCredentialsMessage;

            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            TempData[Status.Success] = SuccessOnLogoutMessage;

            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        [HttpGet]
        public IActionResult AccessDenied()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Details()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Orders()
        {
            var customerId = this._userManager.GetUserId(User);

            var result = await this._orderService.GetUserOrders(customerId); //basically cant be null lol


            return View(result);
        }

    }
}
