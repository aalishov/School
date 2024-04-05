using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RestaurantRating.Common;
using RestaurantRating.Data;
using RestaurantRating.Data.Models;
using RestaurantRating.Services.Contracts;
using RestaurantRating.ViewModels.Restaurants;
using RestaurantRating.ViewModels.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantRating.Services
{
    public class ReviewsService : IReviewsService
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<User> userManager;

        public ReviewsService(ApplicationDbContext context, UserManager<User> userManager)
        {
            this.context = context;
            this.userManager = userManager;
        }
        public async Task<IndexReviewsViewModel> GetMyReviewsAsync(IndexReviewsViewModel model)
        {
            User? user = await userManager.FindByIdAsync(model.UserId);

            IQueryable<Review> reviews = null;

            if (await userManager.IsInRoleAsync(user, GlobalConstants.AdminRole))
            {
                reviews = context.Reviews;
                model.ElementsCount = await reviews.CountAsync();
            }
            else
            {
                reviews = context.Reviews
                     .Where(x => x.UserId == model.UserId);
                model.ElementsCount = await GetMyReviewsCountAsync(model.UserId);
            }
           
            model.Reviews = await reviews
                .Skip((model.Page - 1) * model.ItemsPerPage)
                .Take(model.ItemsPerPage)
                .Select(x => new IndexReviewViewModel()
                {
                    Id = x.Id,
                    RestaurantName = x.Restaurant.Name,
                    Description = x.Description,
                    DateTime = x.Date.ToString("dd-MM-yyyy, HH:mm"),
                    Rating = x.Rating.ToString(),
                })
                .ToListAsync();

            return model;
        }

        public async Task<int> GetMyReviewsCountAsync(string userId)
        {
            return context.Reviews.Count(x => x.UserId == userId);
        }


        public async Task<EditReviewViewModel> GetReviewToEditAsync(string id)
        {
            Review review = await context.Reviews.FindAsync(id);

            if (review == null)
            {
                return null;
            }

            return new EditReviewViewModel()
            {
                Id = review.Id,
                RestaurantName = review.Restaurant.Name,
                Description = review.Description,
                Rating = review.Rating,
                DateTime = review.Date,
            };
        }

        public async Task<bool> EditRestaurantAsync(EditReviewViewModel model)
        {
            Review review = await context.Reviews.FindAsync(model.Id);


            if (review == null)
            {
                return false;
            }

            review.Description = model.Description;
            review.Rating = model.Rating;
            review.Date = model.DateTime;


            context.Update(review);
            await context.SaveChangesAsync();
            return true;
        }
    }
}
