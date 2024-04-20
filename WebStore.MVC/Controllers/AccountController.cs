using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebStore.Infrastructure.Data.Entities;
using WebStore.Models.Account;
using static WebStore.Core.Constants.ErrorMessageConstants.Account;
using static WebStore.Core.Constants.TempDataKeyConstants.Account;
using static WebStore.Core.Constants.TempDataKeyConstants;
using WebStore.Infrastructure.Common;

namespace WebStore.Controllers
{
    public class AccountController : BaseController
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IRepository repo;

        public AccountController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IRepository _repo)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            repo = _repo;
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
            {                                                   //TODO: is it okay to create users this way?
                var customer = new Customer                     //TODO: is it okay to create users this way?
                {                                               //TODO: is it okay to create users this way?
                    UserId = user.Id,                           //TODO: is it okay to create users this way?
                };                                              //TODO: is it okay to create users this way?
                                                                //TODO: is it okay to create users this way?
                await repo.AddAsync<Customer>(customer);        //TODO: is it okay to create users this way?
                await repo.SaveChangesAsync();                  //TODO: is it okay to create users this way?

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


    }
}
