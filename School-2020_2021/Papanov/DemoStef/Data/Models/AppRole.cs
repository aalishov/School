using Microsoft.AspNetCore.Identity;
using System;

namespace DemoStef.Data.Models
{
    public class AppRole : IdentityRole
    {
        public AppRole()
        {
            this.Id = Guid.NewGuid().ToString();
            this.CreatedOn = DateTime.UtcNow;
        }

        public DateTime CreatedOn { get; set; }
    }
}
