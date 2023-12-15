using Microsoft.EntityFrameworkCore;
using P02_OneToOne.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_OneToOne.Data
{
    public class AppDbContext : DbContext
    {
        private const string ConnectionString = "Server=STEM-13\\MSSQLSERVER01; Database=OneToOneEf; Trusted_Connection=True; TrustServerCertificate=True";

        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Passport> Passports { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }
            optionsBuilder.UseLazyLoadingProxies();
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //    modelBuilder.Entity<Person>(x =>
        //    {
        //        x.HasOne(p => p.Passport)
        //        .WithOne(p => p.Person);

        //    });

        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
