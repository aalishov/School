using System.Diagnostics;
using BarberRating.Data;
using BarberRating.ViewModels;
using BarberRating.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BarberRating.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            this.context = context;
        }

        public async Task<IActionResult> Index()
        {
            IndexHomeViewModel model = new IndexHomeViewModel()
            {
                UsersCount = await context.Users.CountAsync(),
                BarbersCount = await context.Barbers.CountAsync(),
                ReviewsCount = await context.Reviews.CountAsync()
            };
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
