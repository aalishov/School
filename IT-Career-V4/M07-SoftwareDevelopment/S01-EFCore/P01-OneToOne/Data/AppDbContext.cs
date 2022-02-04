using Microsoft.EntityFrameworkCore;
using P01_OneToOne.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_OneToOne.Data
{
    public class AppDbContext : DbContext
    {
        private const string ConnectionString = "Server=.;Database=efOneToOneDb;Trusted_Connection=True;";
        public virtual DbSet<Passport> Passports { get; set; }
        public virtual DbSet<Person> People { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Passport>(option =>
            {
                option
                    .HasIndex(x => x.Number)
                    .IsUnique();
            } );
        }
    }
}
