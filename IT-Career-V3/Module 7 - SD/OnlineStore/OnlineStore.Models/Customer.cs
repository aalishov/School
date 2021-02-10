namespace OnlineStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public class Customer
    {
        public Customer()
        {
            this.Orders = new HashSet<Order>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime? BirthDay { get; set; }

        [ForeignKey(nameof(City))]
        public int CityId { get; set; }

        public virtual City City { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
