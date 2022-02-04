using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using P04_DemoAuthenticationAndAuthorization.Data;
using P04_DemoAuthenticationAndAuthorization.Data.Models;
using System.Threading.Tasks;

namespace P04_DemoAuthenticationAndAuthorization.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<AppUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public UserController(ApplicationDbContext context, UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.context = context;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        public async Task<IActionResult> CreateRole()
        {
            var result = await roleManager.CreateAsync(new IdentityRole("User"));
            return Json(result.Succeeded);
        }

        public async Task<IActionResult> AddUserToRole()
        {
            AppUser user = await userManager.GetUserAsync(this.User);
            var result = await userManager.AddToRoleAsync(user, "Admin");
            return Json(result.ToString());
        }
    }
}
