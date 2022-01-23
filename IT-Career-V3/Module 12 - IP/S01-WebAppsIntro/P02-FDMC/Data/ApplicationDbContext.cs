using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using P02_FDMC.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P02_FDMC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cat> Cats { get; set; }
    }
}
