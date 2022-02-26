namespace Scooters.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class Scooter
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(60)]
        public string Model { get; set; }
        public string Position { get; set; }
        public bool IsTaken { get; set; }
        public virtual ICollection<Rent> Rents { get; set; } = new HashSet<Rent>();
    }
}
