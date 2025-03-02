using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using VacationManagerWebApp.Services.Contracts;
using VacationManagerWebApp.ViewModels.Users;
using System.Security.Claims;

namespace VacationManagerWebApp.Web.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUsersService service;

        public UsersController(IUsersService service)
        {
            this.service = service;
        }

        [Authorize(Roles = GlobalConstants.AdminRole)]
        public async Task<IActionResult> Index(IndexUsersViewModel? model)
        {

            model = await service.GetUsersAsync(model);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                await service.CreateUserAsync(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [Authorize(Roles = GlobalConstants.AdminRole)]
        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            var model = await service.GetUserToEditAsync(id);
            return View(model);
        }

        [Authorize(Roles = GlobalConstants.AdminRole)]
        [HttpPost]
        public async Task<IActionResult> Edit(EditUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                await service.UpdateUserAsync(model);
                return this.RedirectToAction(nameof(Index));
            }
            model.Roles = service.GetRolesList();
            return View(model);
        }


        [HttpGet]
        public async Task<IActionResult> Seed()
        {
            await service.SeedUsersAsync();
            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = GlobalConstants.AdminRole)]
        [HttpGet]
        public async Task<IActionResult> Delete(string id)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            if (id != userId)
            {
                await service.DeleteUserAsync(id);
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            string returnUrl = Url.Content("~/");


            if (ModelState.IsValid)
            {
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                var result = await service.Login(model);
                if (result.Succeeded)
                {
                    // _logger.LogInformation("User logged in.");
                    return LocalRedirect(returnUrl);
                }
                if (result.RequiresTwoFactor)
                {
                    return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = model.RememberMe });
                }
                if (result.IsLockedOut)
                {
                    // _logger.LogWarning("User account locked out.");
                    return RedirectToPage("./Lockout");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return View(model);
                }
            }

            // If we got this far, something failed, redisplay form
            return RedirectToAction(nameof(Index), "Home");
        }
    }
}
