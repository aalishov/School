using Microsoft.EntityFrameworkCore;
using P02_OneToMany.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_OneToMany.Data
{
    public class AppDbContext : DbContext
    {
        private const string ConnectionString = @"Server=.; Database=OneToManyEf; Trusted_Connection=True; TrustServerCertificate=True";

        public virtual DbSet<Manufacturer> Manufacturers { get; set; }

        public virtual DbSet<Model> Models { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
