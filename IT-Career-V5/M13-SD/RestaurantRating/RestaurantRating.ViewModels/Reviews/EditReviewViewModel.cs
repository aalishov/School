using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantRating.ViewModels.Reviews
{
    public class EditReviewViewModel
    {
        public string Id { get; set; }
        public string RestaurantName { get; set; }
        public DateTime DateTime { get; set; } = DateTime.UtcNow;
        public double Rating { get; set; }
        public string Description { get; set; }

    }
}
