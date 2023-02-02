namespace P02_EfOneToMany.Data
{
    using Microsoft.EntityFrameworkCore;
    using Data.Models;

    public class AppDbContext : DbContext
    {
        private const string ConnectionString = @"Server=STEM-13\MSSQLSERVER01; Initial Catalog=OneToManyEf; Integrated Security=true; Trusted_Connection=true";
        public virtual DbSet<Manufacturer> Manufacturers { get; set; }
        public virtual DbSet<Model> Models { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }
            optionsBuilder.UseLazyLoadingProxies();
        }

        //API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Manufacturer>(
                options =>
            {
                options
                    .HasMany(x => x.Models)
                    .WithOne(x => x.Manufacturer)
                    .OnDelete(DeleteBehavior.Cascade);
                options
                    .HasIndex(x => x.Name)
                    .IsUnique();
                options.Property(x => x.Name)
                    .IsUnicode();
            });
        }
    }
}
