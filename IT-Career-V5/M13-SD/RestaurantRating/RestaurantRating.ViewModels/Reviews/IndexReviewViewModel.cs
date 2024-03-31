using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantRating.ViewModels.Reviews
{
    public class IndexReviewViewModel
    {
        public string Id { get; set; }

        public string RestaurantName { get; set; }

        public string DateTime { get; set; }

        public string Rating { get; set; }

        public string Description { get; set; }
    }
}
