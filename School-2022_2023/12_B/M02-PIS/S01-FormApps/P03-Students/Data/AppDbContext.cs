using Microsoft.EntityFrameworkCore;
using P03_Students.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P03_Students.Data
{
    public class AppDbContext : DbContext
    {
        private const string ConnectionString = @"Server=STEM-13\MSSQLSERVER01; Initial Catalog=StudentsDbForm; Integrated Security=true; Trusted_Connection =true";

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
