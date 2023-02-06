using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace P02_Eventures.Data.Models
{
    public class Event
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Place { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public int TotalTickets { get; set; }

        public decimal PricePerTicket { get; set; }

        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
