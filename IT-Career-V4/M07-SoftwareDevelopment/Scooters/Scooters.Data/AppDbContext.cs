namespace Scooters.Data
{
    using Microsoft.EntityFrameworkCore;
    using Scooters.Models;

    public class AppDbContext : DbContext
    {
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Rent> Rents { get; set; }
        public virtual DbSet<Scooter> Scooters { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=DESKTOP-OFMEDPC\\SQLEXPRESS;Database=scootersDb;Trusted_Connection=True;";
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
            optionsBuilder.UseLazyLoadingProxies();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>(option =>
            {
                option.HasData(new City() { Id = 1, Name = "Velingrad" });
            });
        }
    }
}
