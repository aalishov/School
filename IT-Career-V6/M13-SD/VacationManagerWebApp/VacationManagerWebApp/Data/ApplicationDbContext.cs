using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VacationManagerWebApp.Data.Models;

namespace VacationManagerWebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<User, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public ApplicationDbContext() { }

        public virtual DbSet<Project> Projects { get; set; }

        public virtual DbSet<Team> Teams { get; set; }

        public virtual DbSet<Leave> Leaves { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<User>()
                    .HasMany(e => e.Roles)
                    .WithOne()
                    .HasForeignKey(e => e.UserId)
                    .IsRequired()
                    .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Team>()
                .HasMany(e=>e.Developers)
                .WithOne(t=>t.Team)
                .HasForeignKey(u=>u.TeamId);

            builder.Entity<Team>()
                .HasOne(e => e.TeamLead)
                .WithOne(x=>x.LeadOnTeam)
                .HasForeignKey<User>(x=>x.LeadOnTeamId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
