using DemoUser.Data;
using DemoUser.Data.Models;
using DemoUser.Services.Contracts;
using DemoUser.ViewModels.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.WebUtilities;
using System.Security.Policy;
using System.Text.Encodings.Web;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DemoUser.Services
{
    public class UsersService : IUsersService
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<User> userManager;
        private readonly IUserStore<User> userStore;
        private readonly IUserEmailStore<User> emailStore;


        public UsersService(ApplicationDbContext context, UserManager<User> userManager, IUserStore<User> userStore)
        {
            this.context = context;
            this.userManager = userManager;
            this.userStore = userStore;
            this.emailStore = (IUserEmailStore<User>)userStore;
        }

        public async Task<string> CreateUserAsync(CreateUserViewModel model)
        {
            var user = Activator.CreateInstance<User>();

            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.BirthDate = model.BirthDate;

            await this.userStore.SetUserNameAsync(user, model.Email, CancellationToken.None);
            await this.emailStore.SetEmailAsync(user, model.Email, CancellationToken.None);
            var result = await this.userManager.CreateAsync(user, model.Password);

            await this.userManager.AddToRoleAsync(user, model.Role);

            if (result.Succeeded)
            {
                var userId = await userManager.GetUserIdAsync(user);
                var code = await userManager.GenerateEmailConfirmationTokenAsync(user);
                code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
            }
            return user.Id;
        }
        public async Task<bool> DeleteUserAsync(string id)
        {
            User user = await userManager.FindByIdAsync(id);
            var result = await userManager.DeleteAsync(user);
            return result.Succeeded;
        }

        public async Task<string> EditUserAsync(EditUserViewModel model)
        {
            User user = await userManager.FindByIdAsync(model.Id);
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            // var roles = await userManager.GetRolesAsync(user);

            if (model.IsAdmin && !await userManager.IsInRoleAsync(user, GlobalConstants.AdministratorRole))
            {
               await userManager.AddToRoleAsync(user, GlobalConstants.AdministratorRole);
            }
            else if(!model.IsAdmin)
            {
                await userManager.RemoveFromRoleAsync(user, GlobalConstants.AdministratorRole);
            }

            if (model.IsUser && !await userManager.IsInRoleAsync(user, GlobalConstants.UserRole))
            {
                await userManager.AddToRoleAsync(user, GlobalConstants.UserRole);
            }
            else if(!model.IsUser)
            {
                await userManager.RemoveFromRoleAsync(user, GlobalConstants.UserRole);
            }

            await userManager.UpdateAsync(user);
            return user.Id;
        }

        public async Task<ICollection<IndexUserViewModel>> GetAllUsersAsync()
        {
            return await context
                 .Users
                 .Select(u => new IndexUserViewModel()
                 {
                     Id = u.Id,
                     FirstName = u.FirstName,
                     LastName = u.LastName,
                     Role = string.Join(" ", userManager.GetRolesAsync(u).GetAwaiter().GetResult())
                 })
                 .ToListAsync();
        }

        public async Task<EditUserViewModel> GetUserToEdit(string id)
        {
            User user = await userManager.FindByIdAsync(id);
            return new EditUserViewModel()
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                IsAdmin = await userManager.IsInRoleAsync(user, GlobalConstants.AdministratorRole),
                IsUser = await userManager.IsInRoleAsync(user, GlobalConstants.UserRole)
            };
        }
    }
}
