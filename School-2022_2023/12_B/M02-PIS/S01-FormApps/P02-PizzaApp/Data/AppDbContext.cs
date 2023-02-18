using Microsoft.EntityFrameworkCore;
using P02_PizzaApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P02_PizzaApp.Data
{
    public class AppDbContext:DbContext
    {
        private const string ConnectionString = "Server=STEM-13\\MSSQLSERVER01;Initial Catalog=PizzaCatalog; Integrated Security=true;";
        public virtual DbSet<Pizza> Pizzas { get; set; }
        public virtual DbSet<Size> Sizes { get; set; }
        public virtual DbSet<Paymant> Paymants { get; set; }
        public virtual DbSet<Extra> Extras { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
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
