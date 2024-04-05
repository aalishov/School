using RestaurantRating.ViewModels.Shared;
using RestaurantRating.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantRating.ViewModels.Restaurants
{
    public class IndexRestaurantsViewModel : PagingViewModel
    {
        public IndexRestaurantsViewModel() : base(0)
        {

        }

        public IndexRestaurantsViewModel(int elementsCount, int itemsPerPage = 10, string action = "Index") : base(elementsCount, itemsPerPage, action)
        {
        }

        public string Filter { get; set; }
        public ICollection<IndexRestaurantViewModel> Restaurants { get; set; } = new List<IndexRestaurantViewModel>();
    }
}
