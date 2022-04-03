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

        public async Task<IndexUsersViewModel> GetUsersAsync(IndexUsersViewModel model)
        {
            model.Users = await context.Users
                .Select(x => new IndexUserViewModel()
                {
                    Id = x.Id,
                    FirstName = x.FirstName,
                    LastName = x.LastName
                })
                .ToListAsync();

            if (!string.IsNullOrWhiteSpace(model.Filter.FirstName))
            {
                model.Users = model.Users
                    .Where(x =>x.FirstName.Contains(model.Filter.FirstName)).ToList();
            }
            if (!string.IsNullOrWhiteSpace(model.Filter.LastName))
            {
                model.Users = model.Users
                    .Where(x => x.FirstName.Contains(model.Filter.LastName)).ToList();
            }

            model.ElementsCount = model.Users.Count();
            model.Users = model.Users
                .Skip((model.PageNumber - 1) * model.ItemsPerPage)
                .Take(model.ItemsPerPage)
                .ToList();

            return model;
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

        public async Task<EditUserViewModel> GetUserToEdit(string id)
        {
            User user = await this.context.Users.FindAsync(id);
            if (user == null)
            {
                throw new ArgumentException("User not found!");
            }

            return new EditUserViewModel()
            {
                Id = user.Id,
                FirstName = user.FirstName,
                MiddleName = user.MiddleName,
                LastName = user.LastName,
                IsActive = user.IsActive
            };
        }

        public async Task EditUserAsync(EditUserViewModel model)
        {
            User user = await this.context.Users.FindAsync(model.Id);
            if (user == null)
            {
                throw new ArgumentException("User not found!");
            }
            user.FirstName = model.FirstName;
            user.MiddleName = model.MiddleName;
            user.LastName = model.LastName;
            if (model.IsActive == false && user.IsActive == true)
            {
                user.IsActive = model.IsActive;
                user.ContractEndDate = DateTime.UtcNow;
                user.EmailConfirmed = false;
            }
            else if (model.IsActive == true && user.IsActive == false)
            {
                user.IsActive = model.IsActive;
                user.DateOfIssue = DateTime.UtcNow;
                user.ContractEndDate = null;
                user.EmailConfirmed = true;
            }
            this.context.Users.Update(user);
            await context.SaveChangesAsync();
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

        public async Task<DetailsUserViewModel> GetUserDetailsAsync(string id)
        {
            User user = await this.context.Users.FindAsync(id);
            if (user == null)
            {
                throw new ArgumentException("User not found!");
            }
            return new DetailsUserViewModel()
            {
                Id = user.Id,
                FirstName = user.FirstName,
                MiddleName = string.IsNullOrWhiteSpace(user.MiddleName) ? "-" : user.MiddleName,
                LastName = user.LastName,
                Email = user.Email,
                DateOfIssue = user.DateOfIssue.ToShortDateString(),
                EndDate = user.ContractEndDate != null ? ((DateTime)user.ContractEndDate).ToShortDateString() : "-",
                IsActive = user.IsActive
            };
        }
    }
}
