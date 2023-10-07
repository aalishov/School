using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trucks.Data.Models;

namespace Trucks.Data
{
    public class AppDbContext:DbContext
    {
        private const string connectionString = "Server=STEM-13\\MSSQLSERVER01;Initial Catalog=Trucks; Integrated Security=true; Trust Server Certificate=True";

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<ClientTruck> ClientsTrucks { get; set; }

        public virtual DbSet<Despatcher> Despatchers { get; set; }

        public virtual DbSet<Truck> Trucks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString
                    );
            }
            optionsBuilder.UseLazyLoadingProxies();
        }

    }
}
