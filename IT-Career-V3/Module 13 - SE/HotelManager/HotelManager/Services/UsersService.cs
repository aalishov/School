using HotelManager.Data;
using HotelManager.Data.Models;
using HotelManager.ViewModels.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManager.Services
{
    public class UsersService : IUsersService
    {
        private readonly AppDbContext context;
        private readonly UserManager<User> userManager;

        public UsersService(AppDbContext context, UserManager<User> userManager)
        {
            this.context = context;
            this.userManager = userManager;
        }

        public async Task<IndexUsersViewModel> GetUsersAsync(int page, int itemsPerPage = 10)
        {
            IndexUsersViewModel users = new IndexUsersViewModel();

            users.ItemsPerPage = itemsPerPage;
            users.PageNumber = page;
            users.ElementsCount = context.Users.Count();

            users.Users = await context.Users
                .Skip((page - 1) * users.ItemsPerPage)
                .Take(users.ItemsPerPage)
                .Select(x => new IndexUserViewModel()
                {
                    Id = x.Id,
                    FirstName = x.FirstName,
                    LastName = x.LastName
                })
                .ToListAsync();

            return users;
        }
        public async Task CreateUserAsync(CreateUserViewModel model)
        {
            var user = new User
            {
                UserName = model.Email,
                Email = model.Email,
                FirstName = model.FirstName,
                MiddleName = model.MiddleName,
                LastName = model.LastName,
                NationalId = model.NationalId
            };

            var createResult = await userManager.CreateAsync(user, model.Password);
            if (createResult.Succeeded)
            {
                var addToRoleResult = await userManager.AddToRoleAsync(user, "User");
                if (!addToRoleResult.Succeeded)
                {
                    throw new ArgumentException("Add user to role error....");
                }
            }
            else
            {
                throw new ArgumentException("Create user error....");
            }
        }
        public async Task DeleteUserAsync(string id)
        {
            User user = this.context.Users.Find(id);
            if (user != null)
            {
                await this.userManager.DeleteAsync(user);
            }
            throw new ArgumentException("User not found!");
        }
    }
}
