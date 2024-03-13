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
    }
}
