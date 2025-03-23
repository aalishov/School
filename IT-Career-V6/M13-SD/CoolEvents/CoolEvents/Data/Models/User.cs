using Microsoft.AspNetCore.Identity;

namespace CoolEvents.Data.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;

        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; } = new HashSet<IdentityUserRole<string>>();

        public virtual ICollection<Ticket> Tickets { get; set; } = new HashSet<Ticket>();
    }
}
