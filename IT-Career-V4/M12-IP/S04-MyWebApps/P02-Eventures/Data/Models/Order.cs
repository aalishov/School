using System;

namespace P02_Eventures.Data.Models
{
    public class Order
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public DateTime OrderedOn { get; set; } = DateTime.UtcNow;

        public string CustomerId { get; set; }

        public virtual User Customer { get; set; }

        public string EventId { get; set; }

        public virtual Event Event { get; set; }

        public int TicketsCount { get; set; }
    }
}
