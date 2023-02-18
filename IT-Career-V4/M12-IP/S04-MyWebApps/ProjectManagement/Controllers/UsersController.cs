using Microsoft.AspNetCore.Mvc;
using ProjectManagement.ActionFilters;
using ProjectManagement.Entities;
using ProjectManagement.ExtentionMethods;
using ProjectManagement.Repositories;
using ProjectManagement.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Controllers
{
    [AuthenticationFilter]
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            ProjectManagementDbContext context = new ProjectManagementDbContext();

            IndexVM model = new IndexVM();
            model.Items = context.Users.ToList();

            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateVM model)
        {
            if (!ModelState.IsValid)
                return View(model);

            User item = new User();
            item.Username = model.Username;
            item.Password = model.Password;
            item.FirstName = model.FirstName;
            item.LastName = model.LastName;

            ProjectManagementDbContext context = new ProjectManagementDbContext();
            context.Users.Add(item);
            context.SaveChanges();

            return RedirectToAction("Index", "Users");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ProjectManagementDbContext context = new ProjectManagementDbContext();
            User item = context.Users.Where(u => u.Id == id)
                                     .FirstOrDefault();

            if (item == null)
                return RedirectToAction("Index", "Users");

            EditVM model = new EditVM();
            model.Id = item.Id;
            model.Username = item.Username;
            model.Password = item.Password;
            model.FirstName = item.FirstName;
            model.LastName = item.LastName;

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(EditVM model)
        {
            if (!ModelState.IsValid)
                return View(model);

            User item = new User();
            item.Id = model.Id;
            item.Username = model.Username;
            item.Password = model.Password;
            item.FirstName = model.FirstName;
            item.LastName = model.LastName;

            ProjectManagementDbContext context = new ProjectManagementDbContext();
            context.Users.Update(item);
            context.SaveChanges();

            return RedirectToAction("Index", "Users");
        }

        public IActionResult Delete(int id)
        {
            ProjectManagementDbContext context = new ProjectManagementDbContext();
            User item = new User();
            item.Id = id;

            context.Users.Remove(item);
            context.SaveChanges();

            return RedirectToAction("Index", "Users");
        }
    }
}
