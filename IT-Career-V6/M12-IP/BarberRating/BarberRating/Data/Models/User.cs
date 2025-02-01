using Microsoft.AspNetCore.Identity;

namespace BarberRating.Data.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; } = new HashSet<IdentityUserRole<string>>();

        public virtual ICollection<Review> Reviews { get; set; } = new HashSet<Review>();
    }
}
