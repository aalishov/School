using RestaurantRating.ViewModels.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantRating.ViewModels.Reviews
{
    public class IndexReviewsViewModel : PagingViewModel
    {
        public IndexReviewsViewModel() : base(0)
        {

        }
        public IndexReviewsViewModel(int elementsCount, int itemsPerPage = 5, string action = "Index") : base(elementsCount, itemsPerPage, action)
        {
        }

        public string UserId { get; set; }

        public ICollection<IndexReviewViewModel> Reviews { get; set; } = new List<IndexReviewViewModel>();

    }
}
