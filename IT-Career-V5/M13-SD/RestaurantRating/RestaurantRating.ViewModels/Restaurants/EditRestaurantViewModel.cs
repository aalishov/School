using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantRating.ViewModels.Restaurants
{
    public class EditRestaurantViewModel
    {
        public string Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(64)]
        [Display(Name = "Restaurant name")]
        public string Name { get; set; }

        public string? Description { get; set; }

        public string? Image { get; set; }

        [BindProperty]
        public IFormFile File { get; set; }
    }
}
