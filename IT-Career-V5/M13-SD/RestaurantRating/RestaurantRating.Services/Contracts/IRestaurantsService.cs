using RestaurantRating.ViewModels.Restaurants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantRating.Services.Contracts
{
    public interface IRestaurantsService
    {
        public Task<IndexRestaurantsViewModel> GetRestaurantsAsync(IndexRestaurantsViewModel model);

        public Task<int> GetRestaurantsCountAsync();

        public Task<DetailsRestaurantViewModel> GetRestaurantDetails(string id);

        public Task<string> CreateRestaurantAsync(CreateRestaurantViewModel model);

        public Task<EditRestaurantViewModel> GetRestaurantToEditAsync(string id);

        public Task<bool> EditRestaurantAsync(EditRestaurantViewModel model);

        public Task<int> DeleteRestaurantAsync(string id);

        public Task<int> ReviewAsync(CreateReviewViewMdoel model);
    }
}
