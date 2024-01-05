using Microsoft.EntityFrameworkCore;
using P05_RailwayStation.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_RailwayStation.Data
{
    public class AppDbContext:DbContext
    {
        private const string ConnectionString = "Server=STEM-13\\MSSQLSERVER01; Database=RailwayEf2; Trusted_Connection=True; TrustServerCertificate=True";
        public virtual DbSet<MaintenanceRecord> MaintenanceRecords { get; set; }
        public virtual DbSet<Passenger> Passengers { get; set; }
        public virtual DbSet<RailwayStation> RailwayStations { get; set; }

        public virtual DbSet<Ticket> Tickets{ get; set; }
        public virtual DbSet<Town> Towns { get; set; }
        public virtual DbSet<Train> Trains { get; set; }
        public virtual DbSet<TrainsRailwayStation> TrainsRailwayStations { get; set; }

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
