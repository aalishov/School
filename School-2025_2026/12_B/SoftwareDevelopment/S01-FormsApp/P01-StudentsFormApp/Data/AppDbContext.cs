using Microsoft.EntityFrameworkCore;
using P01_StudentsFormApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P01_StudentsFormApp.Data
{
    public class AppDbContext : DbContext
    {
        private const string ConnectionString = @"Server=STEM-13\MSSQLSERVER01; Database=StudentFormAppDb; Trusted_Connection=True; TrustServerCertificate=True; MultipleActiveResultSets=True";

        public virtual DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }
        }
    }
}
