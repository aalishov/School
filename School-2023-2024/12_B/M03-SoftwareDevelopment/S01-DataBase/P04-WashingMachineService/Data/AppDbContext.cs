using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WashingMachineService.Data.Models;

namespace WashingMachineService.Data
{
    public class AppDbContext:DbContext
    {
        private const string ConnectionString = "Server=STEM-13\\MSSQLSERVER01; Database=WMC; Trusted_Connection=True; TrustServerCertificate=True";

        public  virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<Mechanic> Mechanics { get; set; }
        public virtual DbSet<Model> Models { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderPart> OrderParts { get; set; }
        public virtual DbSet<Part> Parts { get; set; }
        public virtual DbSet<PartNeeded> PartsNeeded { get; set; }
            public virtual DbSet<Vendor> Vendors { get; set; }


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
