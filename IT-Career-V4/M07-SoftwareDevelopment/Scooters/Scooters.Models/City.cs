namespace Scooters.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class City
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(60)]
        public string Name { get; set; }
        public virtual ICollection<User> Users { get; set; } = new HashSet<User>();
    }
}
