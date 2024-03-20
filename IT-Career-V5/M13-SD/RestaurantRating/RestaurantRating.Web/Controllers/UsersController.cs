using Microsoft.AspNetCore.Mvc;
using RestaurantRating.Services.Contracts;
using RestaurantRating.ViewModels.Users;

namespace RestaurantRating.Web.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUsersService service;

        public UsersController(IUsersService service)
        {
            this.service = service;
        }

        public async Task<IActionResult> Index([FromBody] IndexUsersViewModel? model)
        {

            model = await service.GetUsersAsync(model);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            var model = await service.GetUserToEditAsync(id);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(EditUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                await service.UpdateUserAsync(model);
                return this.RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Seed()
        {
            const string Password = "A123456";
            for (int i = 0; i < 50; i++)
            {
                string result = await service.CreateUserAsync(

                      new CreateUserViewModel()
                      {
                          FirstName = $"Name {i}",
                          LastName = $"LastName {i}",
                          Password = Password,
                          ConfirmPassword = Password,
                          Email=$"user{i}@app.bg"
                      }
                      );
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
