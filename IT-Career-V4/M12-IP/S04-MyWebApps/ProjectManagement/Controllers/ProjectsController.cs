using Microsoft.AspNetCore.Mvc;
using ProjectManagement.ActionFilters;
using ProjectManagement.Entities;
using ProjectManagement.ExtentionMethods;
using ProjectManagement.Repositories;
using ProjectManagement.ViewModels.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Controllers
{
    [AuthenticationFilter]
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            User loggedUser = this.HttpContext.Session.GetObject<User>("loggedUser");

            ProjectManagementDbContext context = new ProjectManagementDbContext();

            IndexVM model = new IndexVM();
            model.Items = context.Projects
                                    .Where(p => p.OwnerId == loggedUser.Id)
                                    .ToList();

            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            User loggedUser = this.HttpContext.Session.GetObject<User>("loggedUser");

            CreateVM model = new CreateVM();
            model.OwnerId = loggedUser.Id;

            return View(model);
        }

        [HttpPost]
        public IActionResult Create(CreateVM model)
        {
            User loggedUser = this.HttpContext.Session.GetObject<User>("loggedUser");

            if (model.OwnerId != loggedUser.Id)
            {
                ModelState.AddModelError("summaryError", "Owner impersonation attempt detected!");
                return View(model);
            }

            ProjectManagementDbContext context = new ProjectManagementDbContext();

            Project item = new Project();
            item.OwnerId = model.OwnerId;
            item.Title = model.Title;
            item.Description = model.Description;

            context.Projects.Add(item);
            context.SaveChanges();

            return RedirectToAction("Index", "Projects");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            User loggedUser = this.HttpContext.Session.GetObject<User>("loggedUser");

            ProjectManagementDbContext context = new ProjectManagementDbContext();
            Project item = context.Projects
                                        .Where(p => p.Id == id)
                                        .FirstOrDefault();

            if (item == null)
                return RedirectToAction("Index", "Projects");

            if (item.OwnerId != loggedUser.Id)
                return RedirectToAction("Index", "Projects");

            EditVM model = new EditVM();
            model.Id = item.Id;
            model.OwnerId = item.OwnerId;
            model.Title = item.Title;
            model.Description = item.Description;

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(EditVM model)
        {
            User loggedUser = this.HttpContext.Session.GetObject<User>("loggedUser");

            ProjectManagementDbContext context = new ProjectManagementDbContext();
            Project item = context.Projects
                                        .Where(p => p.Id == model.Id)
                                        .FirstOrDefault();

            if (item.OwnerId != loggedUser.Id)
            {
                ModelState.AddModelError("summaryError", "Owner impersonation attempt detected!");
                return View(model);
            }

            if (model.OwnerId != loggedUser.Id)
            {
                ModelState.AddModelError("summaryError", "Owner impersonation attempt detected!");
                return View(model);
            }

            item.Id = model.Id;
            item.OwnerId = model.OwnerId;
            item.Title = model.Title;
            item.Description = model.Description;

            context.Projects.Update(item);
            context.SaveChanges();

            return RedirectToAction("Index", "Projects");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            ProjectManagementDbContext context = new ProjectManagementDbContext();

            Project item = context.Projects
                                    .Where(i => i.Id == id)
                                    .FirstOrDefault();

            context.Projects.Remove(item);
            context.SaveChanges();

            return RedirectToAction("Index", "Projects");
        }
    }
}
