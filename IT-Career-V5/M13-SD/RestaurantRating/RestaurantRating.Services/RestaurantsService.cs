using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RestaurantRating.Common;
using RestaurantRating.Data;
using RestaurantRating.Data.Models;
using RestaurantRating.Services.Contracts;
using RestaurantRating.ViewModels.Restaurants;
using RestaurantRating.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantRating.Services
{
    public class RestaurantsService : IRestaurantsService
    {
        private ApplicationDbContext context;

        public RestaurantsService(ApplicationDbContext context)
        {
            this.context = context;
        }


        public async Task<IndexRestaurantsViewModel> GetRestaurantsAsync(IndexRestaurantsViewModel model)
        {
            if (model == null)
            {
                model = new IndexRestaurantsViewModel();
            }

            IQueryable<Restaurant> restaurants = null;

            if (!string.IsNullOrWhiteSpace(model.Filter))
            {
                restaurants = context.Restaurants.Where(x => x.Name.Contains(model.Filter));
            }
            else
            {
                restaurants = context.Restaurants;
            }
            model.ElementsCount = await restaurants.CountAsync();
            model.Restaurants = await restaurants
                .Skip((model.Page - 1) * model.ItemsPerPage)
                .Take(model.ItemsPerPage)
                .Select(x => new IndexRestaurantViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Image = x.Image,
                })
                .ToListAsync();

            return model;
        }

        public async Task<int> GetRestaurantsCountAsync()
        {
            return context.Restaurants.Count();
        }

        public async Task<DetailsRestaurantViewModel> GetRestaurantDetails(string id)
        {
            Restaurant restaurant = await context.Restaurants.FindAsync(id);

            if (restaurant == null) { return null; }

            return new DetailsRestaurantViewModel()
            {
                Id = restaurant.Id,
                Name = restaurant.Name,
                Description = restaurant.Description,
                Image = restaurant.Image,
                Reviews = restaurant.Reviews.Select(x => $"{x.User.FirstName} {x.User.LastName}: rating {x.Rating}, {x.Description}-,{x.Date.ToString("dd-MM-yyyy, HH:mm")}").ToList()
            };
        }

        public async Task<string> CreateRestaurantAsync(CreateRestaurantViewModel model)
        {
            Restaurant restaurant = new Restaurant()
            {
                Name = model.Name,
                Description = model.Description,
                Image = await ImageToStringAsync(model.File)
            };
            context.Add(restaurant);
            await context.SaveChangesAsync();

            return restaurant.Id;
        }

        public async Task<EditRestaurantViewModel> GetRestaurantToEditAsync(string id)
        {
            Restaurant restaurant = await context.Restaurants.FindAsync(id);

            if (restaurant == null)
            {
                return null;
            }

            return new EditRestaurantViewModel()
            {
                Id = restaurant.Id,
                Description = restaurant.Description,
                Image = restaurant.Image
            };
        }

        public async Task<bool> EditRestaurantAsync(EditRestaurantViewModel model)
        {
            Restaurant restaurant = await context.Restaurants.FindAsync(model.Id);


            if (restaurant == null)
            {
                return false;
            }

            restaurant.Name = model.Name;
            restaurant.Description = model.Description;
            if (model.File != null)
            {
                restaurant.Image = await ImageToStringAsync(model.File);
            }
            else
            {
                restaurant.Image = GlobalConstants.DefaultImage;
            }

            context.Update(restaurant);
            await context.SaveChangesAsync();
            return true;
        }

        private async Task<string> ImageToStringAsync(IFormFile file)
        {
            List<string> imageExtensions = new List<string>() { ".JPG", ".BMP", ".PNG" };


            if (file != null) // check if the user uploded something
            {
                var extension = Path.GetExtension(file.FileName); //get file extension
                if (imageExtensions.Contains(extension.ToUpperInvariant()))
                {
                    using var dataStream = new MemoryStream();
                    await file.CopyToAsync(dataStream);
                    byte[] imageBytes = dataStream.ToArray();
                    string base64String = Convert.ToBase64String(imageBytes);
                    return base64String;
                }
            }
            return null;
        }

        public async Task<int> DeleteRestaurantAsync(string id)
        {
            var restaurant = await context.Restaurants.FindAsync(id);
            if (restaurant != null)
            {
                context.Restaurants.Remove(restaurant);
            }

            return await context.SaveChangesAsync();
        }

        public async Task<int> ReviewAsync(CreateReviewViewMdoel model)
        {
            Review review = new Review()
            {
                RestaurantId = model.Restaurant.Id,
                UserId = model.UserId,
                Rating = model.Rating,
                Description = model.Description
            };
            context.Reviews.Add(review);
            return await context.SaveChangesAsync();
        }
    }
}
