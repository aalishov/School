using Microsoft.EntityFrameworkCore;
using P01_EfOneToOne.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P01_EfOneToOne.Data
{
    public class AppDbContext : DbContext
    {
        private const string ConnectionString = @"Server=STEM-13\MSSQLSERVER01; Initial Catalog=OneToOneEf; Integrated Security=true; Trusted_Connection=true";
        public virtual DbSet<Person> People { get; set; }

        public virtual DbSet<Passport> Passports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Person>()
                .HasOne(p => p.Passport)
                .WithOne(p => p.Person);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
