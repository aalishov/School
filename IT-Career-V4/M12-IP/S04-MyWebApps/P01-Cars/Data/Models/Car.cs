namespace P01_Cars.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Car
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(60)]
        public string Brand { get; set; }

        [Required]
        [MaxLength(60)]
        public string Model { get; set; }

        public decimal Price { get; set; }

        public bool IsAvailable { get; set; }

        public DateTime ProductionDate { get; set; }

        public Color Color { get; set; }

        public string ImageUrl { get; set; }
    }
}
