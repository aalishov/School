using Microsoft.EntityFrameworkCore;
using P00_DemoDb.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P00_DemoDb.Data
{
    public class AppDbContext : DbContext
    {
        private const string ConnectionString = "Server=STEM-13\\MSSQLSERVER01; Database=MyDataBase; Trusted_Connection=True; TrustServerCertificate=True";

        public virtual DbSet<Employee> Employees { get; set; }

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
