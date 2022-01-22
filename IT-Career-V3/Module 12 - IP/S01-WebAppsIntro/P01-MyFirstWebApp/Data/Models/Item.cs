using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace P01_MyFirstWebApp.Data.Models
{
    public class Item
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int ColorId { get; set; }

        public virtual Color Color { get; set; }

        public int? BoxId { get; set; }

        public virtual Box Box { get; set; }
    }
}
