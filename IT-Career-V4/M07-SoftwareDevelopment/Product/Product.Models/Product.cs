

namespace Product.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public int Stock { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
