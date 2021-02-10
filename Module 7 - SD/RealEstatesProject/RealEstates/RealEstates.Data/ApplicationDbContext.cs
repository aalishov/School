namespace RealEstates.Data
{
    using Microsoft.EntityFrameworkCore;
    using RealEstates.Data.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public virtual DbSet<BuildingType> BuildingTypes { get; set; }
        public virtual DbSet<District>  Districts { get; set; }
        public virtual DbSet<Property> Properties { get; set; }
        public virtual DbSet<PropertyType> PropertyTypes { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<TagProperty> TagsProperties { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.; Database=RealEstadeDb; Integrated Security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TagProperty>(entity =>
            {
                entity.HasKey(x => new { x.PropertyId, x.TagId });
            });
        }
    }
}
