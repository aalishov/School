using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace P01_MyFirstWebApp.Data.Models
{
    public class Color
    {
        public Color()
        {
            this.Boxes = new HashSet<Box>();
            this.Items = new HashSet<Item>();
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual ICollection<Box> Boxes { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}
