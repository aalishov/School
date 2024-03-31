using RestaurantRating.ViewModels.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantRating.Services.Contracts
{
    public interface IReviewsService
    {
        public Task<IndexReviewsViewModel> GetMyReviewsAsync(IndexReviewsViewModel model);


        public Task<EditReviewViewModel> GetReviewToEditAsync(string id);
        public Task<bool> EditRestaurantAsync(EditReviewViewModel model);
    }
}
