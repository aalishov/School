namespace HotelManager.Data
{
    using HotelManager.Data.Models;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;
    using System;
    using System.Linq;
    public class DbInitializer
    {
        public static void Initialize(AppDbContext context, IServiceProvider services)
        {
            // Get a logger
            var logger = services.GetRequiredService<ILogger<DbInitializer>>();
            var userManager = services.GetRequiredService<UserManager<User>>();
            var roleManager = services.GetRequiredService<RoleManager<IdentityRole<string>>>();

            // Make sure the database is created
            // We already did this in the previous step
            context.Database.EnsureCreated();

            if (context.Roles.Any())
            {
                logger.LogInformation("The database already has roles");
            }
            else
            {
                roleManager.CreateAsync(new IdentityRole() { Name = "Admin" }).Wait();
                logger.LogInformation("Role admin is add...");
                roleManager.CreateAsync(new IdentityRole() { Name = "User" }).Wait();
                logger.LogInformation("Role user is add...");
            }

            if (context.Users.Any())
            {
                logger.LogInformation("The database already has users");
            }
            else
            {
                User user = new User()
                {
                    UserName = "admin@admin.bg",
                    Email = "admin@admin.bg",
                    FirstName="Admin",
                    LastName="Admin",
                    NationalId="----------"
                };
                userManager.CreateAsync(user, "123456").Wait();
                logger.LogInformation("User admin is add...");
                userManager.AddToRoleAsync(user, "Admin").Wait();
                logger.LogInformation("User admin is add to role...");

                for (int i = 10; i < 99; i++)
                {
                    user = new User()
                    {
                        UserName = $"user{i}@user.bg",
                        Email = $"user{i}@user.bg",
                        FirstName = $"FName{i}",
                        LastName = $"LName{i}",
                        NationalId = $"--------{i}"
                    };
                    userManager.CreateAsync(user, "123456").Wait();
                    logger.LogInformation($"User user{i} is add...");
                    userManager.AddToRoleAsync(user, "User").Wait();
                    logger.LogInformation($"User user{i} is add to role...");
                }
            }

        }
    }
}
