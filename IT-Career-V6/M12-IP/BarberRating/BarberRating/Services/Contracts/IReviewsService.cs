using BarberRating.ViewModels.Reviews;

namespace BarberRating.Services.Contracts
{
    public interface IReviewsService
    {
        public Task<string> CreateReviewAsync(CreateReviewViewModel model, string userId);

        public Task<IndexReviewsUserViewModel> GetUserReviewsAsync(IndexReviewsUserViewModel model, string userId);
    }
}
