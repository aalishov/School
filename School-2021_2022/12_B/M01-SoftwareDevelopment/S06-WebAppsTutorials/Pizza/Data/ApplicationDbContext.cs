using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pizza.Data.Models;

namespace Pizza.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public virtual DbSet<AppPizza> AppPizzas { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AppPizza>(option =>
            {
                option.HasData(
                    new AppPizza() {Id=1, Name = "Вегетариана" },
                    new AppPizza() {Id=2, Name = "Маргарита" },
                    new AppPizza() {Id=3, Name = "Калцоне" },
                    new AppPizza() {Id=4, Name = "Капричоза" },
                    new AppPizza() {Id=5, Name = "Тоскана" }
                    );
            });
            base.OnModelCreating(builder);
        }
    }
}
