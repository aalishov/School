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
        public async Task<IActionResult> Index(int page=1, int itemsPerPage=10)
        {
            var model = new IndexUsersViewModel() { PageNumber = page, ItemsPerPage = itemsPerPage };
            IndexUsersViewModel newModel = await usersService.GetUsersAsync(model);
            return View(newModel);
        }
        [HttpPost]
        public async Task<IActionResult> Index(IndexUsersViewModel model)
        {
            IndexUsersViewModel newModel = await usersService.GetUsersAsync(model);
            return View(newModel);
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
        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            EditUserViewModel model =await usersService.GetUserToEdit(id);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(EditUserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await usersService.EditUserAsync(model);
            return RedirectToAction(nameof(this.Index));
        }
        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            DetailsUserViewModel model = await usersService.GetUserDetailsAsync(id);
            return View(model);
        }
    }
}
