namespace DemoUser.Data.Seeding
{
    using Contracts;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using DemoUser.Data.Models;

    public class UserSeeder : ISeeder
    {

        private const string password = "A123456";
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {

            
            if (dbContext.Users.Any())
            {
                return;
            }

            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var configuration = serviceProvider.GetRequiredService<IConfiguration>();
            var userManager = serviceProvider.GetRequiredService<UserManager<User>>();


             await SeedUserAsync(dbContext, userManager, roleManager, "Admin", "Admin", "admin@app.bg", "admin@app.bg", password, GlobalConstants.AdministratorRole);


            for (int i = 0; i < 25; i++)
            {
                await SeedUserAsync(dbContext, userManager, roleManager, $"UName{i}", $"ULastName{i}", $"user{i}@app.com", $"user{i}@app.com", password, GlobalConstants.UserRole);
            }
          

        }

        private static async Task SeedUserAsync(ApplicationDbContext context, UserManager<User> userManager, RoleManager<IdentityRole> roleManager, string firstName, string lastName, string userName, string email, string password, string roleName)
        {
           User user = await userManager.FindByNameAsync(userName);
            if (user == null)
            {
                IdentityResult result = await userManager.CreateAsync(
                    new User()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        UserName = userName,
                        Email = email,
                        SecurityStamp="MyCustomSecurityStamp"
                    }, password);


                if (!result.Succeeded)
                {
                    throw new Exception(string.Join(Environment.NewLine, result.Errors.Select(e => e.Description)));
                }
            }

            user = await userManager.FindByNameAsync(userName);

            var roleExists = await roleManager.RoleExistsAsync(roleName);

            if (roleExists)
            {
                var result = await userManager.AddToRoleAsync(user, roleName);

                if (!result.Succeeded)
                {
                    throw new Exception(string.Join(Environment.NewLine, result.Errors.Select(e => e.Description)));
                }
            }
        }
    }
}
