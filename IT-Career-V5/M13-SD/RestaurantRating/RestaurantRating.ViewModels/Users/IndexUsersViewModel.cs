using RestaurantRating.ViewModels.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace RestaurantRating.ViewModels.Users
{
    public class IndexUsersViewModel : PagingViewModel
    {
        public IndexUsersViewModel() : base(0)
        {
                
        }
        public IndexUsersViewModel(int elementsCount, int itemsPerPage = 10, string action = "Index") : base(elementsCount, itemsPerPage, action)
        {
        }

        public ICollection<IndexUserViewModel> Users { get; set; } = new List<IndexUserViewModel>();

    }
}
