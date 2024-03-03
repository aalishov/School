namespace BookManagement.Data
{
    using Models;
    using Microsoft.EntityFrameworkCore;

    public class AppDbContext : DbContext
    {
        private const string ConnectionString = @"Server=STEM-13\MSSQLSERVER01; Database=BooksDb; Trusted_Connection=True; TrustServerCertificate=True";
        public virtual DbSet<Book> Books { get; set; }

        public virtual DbSet<BookGanre> BooksGanres { get; set; }

        public virtual DbSet<Ganre> Ganres { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer(ConnectionString)
                    .UseLazyLoadingProxies();
            }
        }
    }
}
