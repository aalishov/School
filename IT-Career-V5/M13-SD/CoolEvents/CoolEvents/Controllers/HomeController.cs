using CoolEvents.Data;
using CoolEvents.Data.Models;
using CoolEvents.ViewModels;
using CoolEvents.ViewModels.Home;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CoolEvents.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext context;
        private readonly UserManager<User> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            _logger = logger;
            this.context = context;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        public async Task<IActionResult> Index()
        {
            var roleAdmin = await roleManager.Roles.FirstOrDefaultAsync(x => x.Name == GlobalConstants.AdminRole);
            var roleUser = await roleManager.Roles.FirstOrDefaultAsync(x => x.Name == GlobalConstants.UserRole);

            IndexViewModel model = new IndexViewModel();
            model.AdminsCount = await userManager.Users.Where(x => x.Roles.Any(x => x.RoleId == roleAdmin.Id)).CountAsync();
            model.UsersCount = await userManager.Users.Where(x => x.Roles.Any(x => x.RoleId == roleUser.Id)).CountAsync();

            model.EventsCount =await context.Events.CountAsync();
            model.TicketsCount = await context.Tickets.CountAsync();
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
