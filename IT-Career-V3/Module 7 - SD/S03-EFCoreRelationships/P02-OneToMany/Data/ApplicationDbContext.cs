namespace P02_OneToMany.Data
{
    using Microsoft.EntityFrameworkCore;
    using P02_OneToMany.Data.Models;
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Model> Models { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=manufacturersDb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Model>()
                .HasOne(mo => mo.Manufacturer)
                .WithMany(ma => ma.Models)
                .HasForeignKey(ma=>ma.ManufacturerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
