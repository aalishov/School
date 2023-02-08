using Microsoft.EntityFrameworkCore;
using P01_AnimalsCatalog.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_AnimalsCatalog.Data
{
    public class AppDbContext : DbContext
    {
        private const string ConnectionString = "Server=STEM-13\\MSSQLSERVER01;Initial Catalog=AnimalCatalogDb; Integrated Security=true; Trust Server Certificate=True";
        public virtual DbSet<Animal> Animals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }
        }
    }
}
