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
        private const string ConnectionString = @"Server=.; Database=OneToOneEf; Trusted_Connection=True; TrustServerCertificate=True";
        public virtual DbSet<Person> People { get; set; }

        public virtual DbSet<Passport> Passports { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Passport>()
                .HasOne<Person>()
                .WithOne(x=>x.Passport)
                .HasForeignKey<Person>(x=>x.PassportId);



            base.OnModelCreating(modelBuilder);
        }
    }
}
