namespace Scooters.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class User
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Username { get; set; }
        [Required]
        [MaxLength(16)]
        public string Password { get; set; }
        [Required]
        [MaxLength(60)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(60)]
        public string LastName { get; set; }
        public decimal Balance { get; set; }
        public int CityId { get; set; }
        public virtual City City { get; set; }
        public DateTime RegisterDate { get; set; }
        public virtual ICollection<Rent> Rents { get; set; } = new HashSet<Rent>();
    }
}
