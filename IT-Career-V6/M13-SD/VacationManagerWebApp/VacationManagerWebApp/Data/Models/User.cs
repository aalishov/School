using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace VacationManagerWebApp.Data.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; } = new HashSet<IdentityUserRole<string>>();


        public string? TeamId { get; set; }

        public virtual Team? Team { get; set; }

        public string? LeadOnTeamId { get; set; }

        public virtual Team? LeadOnTeam { get; set; }
    }
}
