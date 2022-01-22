using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace P01_MyFirstWebApp.Data.Models
{
    public class Box
    {
        public Box()
        {
            this.Items = new HashSet<Item>();
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public int MaxCapacity { get; set; }

        public int ColorId { get; set; }

        public virtual Color Color { get; set; }

        public virtual ICollection<Item> Items { get; set; }
    }
}
