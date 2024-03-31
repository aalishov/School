using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RestaurantRating.Common;
using RestaurantRating.Data;
using RestaurantRating.Data.Models;
using RestaurantRating.Services.Contracts;
using RestaurantRating.ViewModels.Restaurants;

namespace RestaurantRating.Web.Controllers
{
    public class RestaurantsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IRestaurantsService restaurantService;

        public RestaurantsController(ApplicationDbContext context, IRestaurantsService restaurantService)
        {
            _context = context;
            this.restaurantService = restaurantService;
        }

        // GET: Restaurants
        public async Task<IActionResult> Index(IndexRestaurantsViewModel? model)
        {
            model = await restaurantService.GetRestaurantsAsync(model);
            return View(model);
        }

        // GET: Restaurants/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restaurant = await restaurantService.GetRestaurantDetails(id);
            if (restaurant == null)
            {
                return NotFound();
            }

            return View(restaurant);
        }

        // GET: Restaurants/Create
        [Authorize(Roles =GlobalConstants.AdminRole)]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Restaurants/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = GlobalConstants.AdminRole)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateRestaurantViewModel model)
        {
            if (ModelState.IsValid)
            {
                await restaurantService.CreateRestaurantAsync(model);
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // GET: Restaurants/Edit/5
        [Authorize(Roles = GlobalConstants.AdminRole)]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var model = await restaurantService.GetRestaurantToEditAsync(id);
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        // POST: Restaurants/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = GlobalConstants.AdminRole)]
        public async Task<IActionResult> Edit(EditRestaurantViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await restaurantService.EditRestaurantAsync(model);

                if (result == false)
                {
                    return NotFound();
                }

                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // GET: Restaurants/Delete/5
        [Authorize(Roles = GlobalConstants.AdminRole)]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restaurant = await restaurantService.GetRestaurantDetails(id);
            if (restaurant == null)
            {
                return NotFound();
            }

            return View(restaurant);
        }

        // POST: Restaurants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = GlobalConstants.AdminRole)]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            await restaurantService.DeleteRestaurantAsync(id);
            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = GlobalConstants.AdminRole)]
        public async Task<IActionResult> Seed()
        {
            if (await restaurantService.GetRestaurantsCountAsync() < 5)
            {
                for (int i = 0; i < 50; i++)
                {
                    await restaurantService.CreateRestaurantAsync(new CreateRestaurantViewModel()
                    {
                        Name = $"Restaurant {i}",
                        Description = $"Restaurant description {i}",
                        File = null
                    });
                }
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Review(string id)
        {
            CreateReviewViewMdoel model = new CreateReviewViewMdoel()
            {
                Restaurant = await restaurantService.GetRestaurantDetails(id)
            };

            if (model.Restaurant==null)
            {
                return NotFound();
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Review(CreateReviewViewMdoel model)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            model.UserId = userId;

            await restaurantService.ReviewAsync(model);

            return RedirectToAction(nameof(Index));
        }
    }
}
