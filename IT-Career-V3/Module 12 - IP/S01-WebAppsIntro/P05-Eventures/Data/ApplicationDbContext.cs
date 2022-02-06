using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using P05_Eventures.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using P05_Eventures.ViewModels.Events;

namespace P05_Eventures.Data
{
    public class ApplicationDbContext : IdentityDbContext<Customer>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

    }
}
