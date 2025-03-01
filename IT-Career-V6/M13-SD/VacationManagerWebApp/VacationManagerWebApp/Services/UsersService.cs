using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VacationManagerWebApp.Data;
using VacationManagerWebApp.Data.Models;
using VacationManagerWebApp.Services.Contracts;
using VacationManagerWebApp.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace VacationManagerWebApp.Services
{

    public class UsersService : IUsersService
    {
        private readonly UserManager<User> userManager;
        private readonly ApplicationDbContext context;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly SignInManager<User> signInManager;
        private const int ItemsCount = 0;

        public UsersService(UserManager<User> userManager, ApplicationDbContext context, RoleManager<IdentityRole> roleManager, SignInManager<User> signInManager)
        {
            this.userManager = userManager;
            this.context = context;
            this.roleManager = roleManager;
            this.signInManager = signInManager;
        }

        public async Task<string> CreateUserAsync(CreateUserViewModel model)
        {
            User user = new User()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                UserName = model.Email
            };

            var result = await userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                if (userManager.Users.Count() <= 1)
                {
                    IdentityRole firstRole = new IdentityRole() { Name = GlobalConstants.AdminRole };
                    IdentityRole secondRole = new IdentityRole() { Name = GlobalConstants.DeveloperRole };
                    IdentityRole thirdRole = new IdentityRole() { Name = GlobalConstants.TeamLeadRole };
                    IdentityRole fourthRole = new IdentityRole() { Name = GlobalConstants.UnassignedRole };

                    await roleManager.CreateAsync(firstRole);
                    await roleManager.CreateAsync(secondRole);
                    await roleManager.CreateAsync(thirdRole);
                    await roleManager.CreateAsync(fourthRole);

                    await userManager.AddToRoleAsync(user, GlobalConstants.AdminRole);
                }
                else
                {
                    await userManager.AddToRoleAsync(user, GlobalConstants.UnassignedRole);
                }
            }
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

        public async Task<IndexUsersViewModel> GetUsersAsync(IndexUsersViewModel model)
        {
            if (model == null)
            {
                model = new IndexUsersViewModel(0);
            }

            IQueryable<User> dataUsers = userManager.Users;

            if (!string.IsNullOrWhiteSpace(model.FilterByName))
            {
                dataUsers = dataUsers.Where(x => x.FirstName.Contains(model.FilterByName) || x.LastName.Contains(model.FilterByName));
            }
            //if (!string.IsNullOrWhiteSpace(model.FilterByRole))
            //{
            //    dataUsers = dataUsers.Where(x => string.Join("", x.Roles.Select(x=>x.)).Contains(model.FilterByRole));
            //}

            model.ElementsCount = await dataUsers.CountAsync();

            if (model.IsAsc)
            {
                model.IsAsc = false;
                if (model.SortUsersBy == "Name")
                {
                    dataUsers = dataUsers.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName);
                }
                else
                {
                    //dataUsers = dataUsers.OrderByDescending(x =>x.Roles.FirstOrDefault().RoleId);
                }
            }
            else
            {
                model.IsAsc = true;
                if (model.SortUsersBy == "Name")
                {
                    dataUsers = dataUsers.OrderBy(x => x.FirstName).ThenBy(x => x.LastName);
                }
                else
                {
                    //dataUsers = dataUsers.OrderBy(x => x.Roles.FirstOrDefault().RoleId);
                }
            }

            model.Users = await dataUsers
                .Skip((model.Page - 1) * model.ItemsPerPage)
                .Take(model.ItemsPerPage)
                .Select(x => new IndexUserViewModel()
                {
                    Id = x.Id,
                    Name = $"{x.FirstName} {x.LastName}",
                    Role = string.Join(", ", userManager.GetRolesAsync(x).GetAwaiter().GetResult())
                })
                .ToListAsync();

            return model;
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

        public async Task Logout()
        {
            await signInManager.SignOutAsync();
        }

        public async Task<SignInResult> Login(LoginViewModel model)
        {
            return await signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, lockoutOnFailure: false);
        }


        public async Task SeedUsersAsync()
        {
            if (userManager.Users.Any())
            {
                return;
            }

            //Create roles
            IdentityRole firstRole = new IdentityRole() { Name = GlobalConstants.AdminRole };
            IdentityRole secondRole = new IdentityRole() { Name = GlobalConstants.DeveloperRole };
            IdentityRole thirdRole = new IdentityRole() { Name = GlobalConstants.TeamLeadRole };
            IdentityRole fourthRole = new IdentityRole() { Name = GlobalConstants.UnassignedRole };

            await roleManager.CreateAsync(firstRole);
            await roleManager.CreateAsync(secondRole);
            await roleManager.CreateAsync(thirdRole);
            await roleManager.CreateAsync(fourthRole);

            //Create admin
            string email = string.Format(GlobalConstants.DefaultEmail, $"ceo", "");
            User ceo = new User()
            {
                FirstName = $"CEO",
                LastName = $"CEO",
                Email = email,
                UserName = email
            };

            await userManager.CreateAsync(ceo, GlobalConstants.Password);
            await userManager.AddToRoleAsync(ceo,GlobalConstants.AdminRole);

            //Create users
            await SeedUsersInRole(GlobalConstants.DeveloperRole.ToLower(), GlobalConstants.DeveloperRole);
            await SeedUsersInRole(GlobalConstants.TeamLeadRole.ToLower(), GlobalConstants.TeamLeadRole);
            await SeedUsersInRole(GlobalConstants.UnassignedRole.ToLower(), GlobalConstants.UnassignedRole);

        }
        private async Task SeedUsersInRole(string userName, string role)
        {
            for (int i = 0; i < 20; i++)
            {
                string email = string.Format(GlobalConstants.DefaultEmail, userName, i.ToString());
                User user = new User()
                {
                    FirstName = $"{userName}{i}",
                    LastName = $"{userName}{i}",
                    Email = email,
                    UserName = email
                };

                await userManager.CreateAsync(user, GlobalConstants.Password);
                await userManager.AddToRoleAsync(user,role);
            }
        }
    }
}
