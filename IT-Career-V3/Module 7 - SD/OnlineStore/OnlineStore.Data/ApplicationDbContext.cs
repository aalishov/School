namespace OnlineStore.Data
{
    using Microsoft.EntityFrameworkCore;
    using OnlineStore.Models;

    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<City> Cities { get; set; }

        public virtual DbSet<Customer> Customers { get; set; }

        public virtual DbSet<Item> Items { get; set; }

        public virtual DbSet<ItemType> ItemsTypes { get; set; }

        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<OrderItem> OrdersItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=onlineStoreDb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e.OrderId });
            });
        }


    }
}
