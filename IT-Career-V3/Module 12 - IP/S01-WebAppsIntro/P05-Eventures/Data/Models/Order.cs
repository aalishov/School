using System;
using System.ComponentModel.DataAnnotations;

namespace P05_Eventures.Data.Models
{
    public class Order
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public DateTime OrderedOn { get; set; } = DateTime.Now;
        public string EventId { get; set; }
        public virtual Event Event { get; set; }
        public string CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public int TicketsCount { get; set; }
    }
}
