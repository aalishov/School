using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolEvents.Data.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }


        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; } = new HashSet<IdentityUserRole<string>>();
        public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();

    }
}
