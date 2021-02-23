using Microsoft.AspNetCore.Identity;
using System;

namespace DemoStef.Data.Models
{
    public class AppUser : IdentityUser
    {
        public AppUser()
        {
            this.Id = Guid.NewGuid().ToString();
            this.CreatedOn = DateTime.UtcNow;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
