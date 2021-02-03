namespace P01_OneToOne
{
    using Microsoft.EntityFrameworkCore;
    using P01_OneToOne.Data.Models;

    public class ApplicationDbContext : DbContext
    {
        public DbSet<Person> People { get; set; }

        public DbSet<Passport> Passports { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=personsDb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Passport>(entity =>
            {
                entity
                .HasOne(pa => pa.Person)
                .WithOne(pe => pe.Passport)
                .HasForeignKey<Person>(pe => pe.PassportId);

                entity
                .HasIndex(e => e.Number)
                .IsUnique();
            });
        }
    }
}
