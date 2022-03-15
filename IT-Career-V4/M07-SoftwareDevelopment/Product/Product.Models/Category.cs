namespace Product.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(60)]
        public string Name { get; set; }
        [MaxLength(250)]
        public string Description { get; set; }
        public virtual ICollection<Product> Products { get; set; }=new HashSet<Product>();
    }
}
