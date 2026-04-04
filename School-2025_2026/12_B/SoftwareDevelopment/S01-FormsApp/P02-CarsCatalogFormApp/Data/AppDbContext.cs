using Microsoft.EntityFrameworkCore;
using P02_CarsCatalogFormApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P02_CarsCatalogFormApp.Data
{
    public class AppDbContext : DbContext
    {
        private const string ConnectionString = @"Server=STEM-13\MSSQLSERVER01; Database=CarsCatalogFormAppDb; Trusted_Connection=True; TrustServerCertificate=True; MultipleActiveResultSets=True";

        public virtual DbSet<Manufacturer> Manufacturers { get; set; }

        public virtual DbSet<Model> Models { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }
        }
    }
}