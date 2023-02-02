using System.ComponentModel.DataAnnotations;

namespace P02_EfOneToMany.Data.Models
{
    public class Model
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]    
        public string Name { get; set; }

        public int ManufacturerId { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }
    }
}
