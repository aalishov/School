using DemoUser.Services.Contracts;
using DemoUser.ViewModels.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace DemoUser.Controllers
{
    [Authorize(Roles = GlobalConstants.AdministratorRole)]
    public class UsersController : Controller
    {
        private readonly IUsersService usersService;

        public UsersController(IUsersService usersService)
        {
            this.usersService = usersService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await usersService.GetAllUsersAsync());
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewData["Roles"] = new SelectList(new List<string>() { GlobalConstants.AdministratorRole, GlobalConstants.UserRole });
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateUserViewModel model)
        {

            if (ModelState.IsValid)
            {
                await usersService.CreateUserAsync(model);
                return RedirectToAction(nameof(Index));
            }
            ViewData["Roles"] = new SelectList(new List<string>() { GlobalConstants.AdministratorRole, GlobalConstants.UserRole });
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            EditUserViewModel model = await usersService.GetUserToEdit(id);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditUserViewModel model)
        {

            if (ModelState.IsValid)
            {
                await usersService.EditUserAsync(model);
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
    }
}
