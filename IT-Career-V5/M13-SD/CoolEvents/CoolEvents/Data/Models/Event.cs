using System.ComponentModel.DataAnnotations;

namespace CoolEvents.Data.Models
{
    public class Event
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [MaxLength(64)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string? Description { get; set; }

        public string? Image { get; set; }

        public DateTime PremiereDate { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}
