using System;
using System.ComponentModel.DataAnnotations;

namespace P01_Cars.Data.Models
{
    public class Owner
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        public DateTime Birthdate { get; set; }
    }
}
