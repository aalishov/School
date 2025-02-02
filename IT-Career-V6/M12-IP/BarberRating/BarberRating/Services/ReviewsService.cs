using BarberRating.Data;
using BarberRating.Data.Models;
using BarberRating.Services.Contracts;
using BarberRating.ViewModels.Barbers;
using BarberRating.ViewModels.Reviews;
using Microsoft.EntityFrameworkCore;

namespace BarberRating.Services
{
    public class ReviewsService : IReviewsService
    {
        private readonly ApplicationDbContext context;

        public ReviewsService(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<string> CreateReviewAsync(CreateReviewViewModel model, string userId)
        {
            Review review = new Review()
            {
                Rating = model.Rating,
                UserId = userId,
                ReviewText = model.ReviewText,
                BarberId = model.BarberId
            };

            await context.Reviews.AddAsync(review);
            await context.SaveChangesAsync();

            return review.Id;
        }

        public async Task<IndexReviewsUserViewModel> GetUserReviewsAsync(IndexReviewsUserViewModel model, string userId)
        {
            if (model == null)
            {
                model = new IndexReviewsUserViewModel(10);
            }
            IQueryable<Review> reviewsData = context.Reviews.Where(x => x.UserId == userId);

            model.ElementsCount = await reviewsData.CountAsync();

            model.UserReviews = await reviewsData
              .Skip((model.Page - 1) * model.ItemsPerPage)
              .Take(model.ItemsPerPage)
              .Select(x => new IndexReviewViewModel()
              {
                  ReviewId=x.Id,
                  BarberName = x.Barber.Name,
                  UserId = userId,
                  Rating=x.Rating,
                  ReviewText=x.ReviewText
              })
              .ToListAsync();

            return model;
        }
    }
}
