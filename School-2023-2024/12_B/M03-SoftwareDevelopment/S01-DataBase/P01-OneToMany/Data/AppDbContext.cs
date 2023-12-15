using Microsoft.EntityFrameworkCore;
using P01_OneToMany.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_OneToMany.Data
{
    public class AppDbContext : DbContext
    {
        private const string ConnectionString = "Server=STEM-13\\MSSQLSERVER01; Database=OneToManyEf; Trusted_Connection=True; TrustServerCertificate=True";
        public virtual DbSet<Manufacturer> Manufacturers { get; set; }
        public virtual DbSet<Model> Models { get; set; }

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
