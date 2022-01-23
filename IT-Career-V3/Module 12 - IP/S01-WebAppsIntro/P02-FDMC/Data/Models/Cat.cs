using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace P02_FDMC.Data.Models
{
    public class Cat
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Breed { get; set; }
        [Required]
        public string ImageUrl { get; set; }
    }
}
