using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AppDbContext:DbContext
{
    private const string ConnectionString = @"Server=STEM-13\MSSQLSERVER01;Initial Catalog=EFAirport; Integrated Security=true; Trust Server Certificate=True";
    public DbSet<Passenger> Passengers { get; set; }
    public DbSet<Pilot> Pilots { get; set; }
    public DbSet<AircraftType> AircraftTypes { get; set; }
    public DbSet<Aircraft> Aircrafts { get; set; }
    public DbSet<PilotAircraft> PilotsAircrafts { get; set; }
    public DbSet<Airport> Airports { get; set; }
    public DbSet<FlightDestination> FlightDestinations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
        optionsBuilder.UseLazyLoadingProxies();
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PilotAircraft>
        (pa =>
             pa.HasKey(k => new { k.AircraftId, k.PilotId })
        );

        base.OnModelCreating(modelBuilder);
    }
}

