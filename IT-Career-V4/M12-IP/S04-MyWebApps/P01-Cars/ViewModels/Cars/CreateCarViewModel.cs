using P01_Cars.Data.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace P01_Cars.ViewModels.Cars
{
    public class CreateCarViewModel
    {
        [MinLength(1)]
        [MaxLength(60)]
        public string Brand { get; set; }

        [MinLength(1)]
        [MaxLength(60)]
        public string Model { get; set; }
        public DateTime ProductionDate { get; set; }

        [Range(1000, 500000)]
        public decimal Price { get; set; }

        public Color Color { get; set; }

        public string ImageUrl { get; set; }
    }
}
