using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RestaurantRating.Data;
using RestaurantRating.Data.Models;
using RestaurantRating.Services.Contracts;
using RestaurantRating.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantRating.Services
{

    public class UsersService : IUsersService
    {
        private readonly UserManager<User> userManager;
        private readonly ApplicationDbContext context;
        private const int ItemsCount = 0;

        public UsersService(UserManager<User> userManager, ApplicationDbContext context)
        {
            this.userManager = userManager;
            this.context = context;
        }

        public async Task<string> CreateUserAsync(CreateUserViewModel model)
        {
            User user = new User()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,  
                UserName=model.Email
            };
            var result = await userManager.CreateAsync(user, model.Password);
            return user.Id;
        }

        public async Task<bool> DeleteUserAsync(string id)
        {
            User? user = await GetUserByIdAsync(id);
            if (user != null)
            {
                var result = await userManager.DeleteAsync(user);
                return result.Succeeded;
            }
            return false;
        }



        public async Task<DetailsUserViewModel?> GetUserDetailsAsync(string id)
        {
            DetailsUserViewModel? result = null;

            User? user = await GetUserByIdAsync(id);

            if (user != null)
            {
                string roles = string.Join(", ", await userManager.GetRolesAsync(user));

                result = new DetailsUserViewModel()
                {
                    Id = user.Id,
                    Name = $"{user.FirstName} {user.LastName}",
                    Email = user.Email != null ? user.Email : "n/a",
                    Phone = user.PhoneNumber != null ? user.PhoneNumber : "n/a",
                    Role = roles
                };
            }

            return result;
        }

        public async Task<IndexUsersViewModel> GetUsersAsync(IndexUsersViewModel users)
        {
            if (users == null)
            {
                users = new IndexUsersViewModel(0);
            }
            users.ElementsCount = await GetUsersCountAsync();

            users.Users = await userManager
                .Users
                .Skip((users.Page - 1) * users.ItemsPerPage)
                .Take(users.ItemsPerPage)
                .Select(x => new IndexUserViewModel()
                {
                    Id = x.Id,
                    Name = $"{x.FirstName} {x.LastName}",
                    Role = string.Join(", ", userManager.GetRolesAsync(x).GetAwaiter().GetResult())
                })
                .ToListAsync();

            return users;
        }

        public async Task<int> GetUsersCountAsync()
        {
            return await userManager.Users.CountAsync();
        }

        public async Task<EditUserViewModel?> GetUserToEditAsync(string id)
        {
            EditUserViewModel? result = null;

            User? user = await GetUserByIdAsync(id);

            if (user != null)
            {
                result = new EditUserViewModel()
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                };
            }

            return result;


        }

        public async Task<string> UpdateUserAsync(EditUserViewModel user)
        {
            User? oldUser = await GetUserByIdAsync(user.Id);

            if (oldUser != null)
            {
                oldUser.FirstName = user.FirstName;
                oldUser.LastName = user.LastName;
                await userManager.UpdateAsync(oldUser);
            }

            return user.Id;
        }

        private async Task<User?> GetUserByIdAsync(string id)
        {
            return await userManager.Users.FirstOrDefaultAsync(u => u.Id == id);
        }
    }
}
