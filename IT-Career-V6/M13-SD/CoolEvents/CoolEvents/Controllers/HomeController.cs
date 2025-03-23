using System.Diagnostics;
using CoolEvents.Data;
using CoolEvents.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CoolEvents.Controllers
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

        public IActionResult Index()
        {
            ViewBag.UsersCount = context.Users.Count();
            ViewBag.TicketsCount = context.Tickets.Count();
            ViewData["EventsCount"] = context.Events.Count();
            return View();
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
