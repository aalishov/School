using HotelManager.Services;
using HotelManager.ViewModels.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManager.Controllers
{
    [Authorize(Roles ="Admin")]
    public class UsersController : Controller
    {
        private readonly IUsersService usersService;

        public UsersController(IUsersService usersService)
        {
            this.usersService = usersService;
        }
        public async Task<IActionResult> Index(int page = 1, int itemsPerPage = 10)
        {
            IndexUsersViewModel model = await usersService.GetUsersAsync(page, itemsPerPage);
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateUserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await usersService.CreateUserAsync(model);
            return RedirectToAction(nameof(this.Index));
        }
    }
}
