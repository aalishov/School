namespace CoolEvents.Data.Models
{
    public class Ticket
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string UserId { get; set; }

        public virtual User User { get; set; }

        public string EventId { get; set; }

        public virtual Event Event { get; set; }
    }
}
