using RestaurantRating.ViewModels.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantRating.ViewModels.Users
{
    public class IndexUsersViewModel : PagingViewModel
    {
        public IndexUsersViewModel(int elementsCount, int itemsPerPage = 5, string action = "Index") : base(elementsCount, itemsPerPage, action)
        {
        }

        public ICollection<IndexUserViewModel> Users { get; set; } = new List<IndexUserViewModel>();

    }
}
