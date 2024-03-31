using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantRating.ViewModels.Restaurants
{
    public class CreateReviewViewMdoel
    {
        
        public DetailsRestaurantViewModel Restaurant { get; set; } = new DetailsRestaurantViewModel();

        public string UserId { get; set; }

        [MaxLength(250)]
        public string Description { get; set; }

        [Range(0, 10)]
        public double Rating { get; set; }
    }
}
