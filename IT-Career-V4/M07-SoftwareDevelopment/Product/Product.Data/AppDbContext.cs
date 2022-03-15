namespace Product.Data
{
    using Microsoft.EntityFrameworkCore;
    using Product.Models;
    public class AppDbContext : DbContext
    {
        private const string ConnectionString = "Server=.;Database=productsDb;Trusted_Connection=True;";
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
                optionsBuilder.UseLazyLoadingProxies();
            }
        }
    }
}
