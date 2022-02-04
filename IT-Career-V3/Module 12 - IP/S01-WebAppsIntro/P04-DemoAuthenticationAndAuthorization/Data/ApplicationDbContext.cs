using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using P04_DemoAuthenticationAndAuthorization.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P04_DemoAuthenticationAndAuthorization.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
