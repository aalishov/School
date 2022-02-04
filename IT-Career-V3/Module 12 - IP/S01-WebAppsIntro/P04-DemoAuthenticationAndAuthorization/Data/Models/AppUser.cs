using Microsoft.AspNetCore.Identity;
using System;

namespace P04_DemoAuthenticationAndAuthorization.Data.Models
{
    public class AppUser : IdentityUser
    {
        public DateTime BirthDate { get; set; }
    }
}
