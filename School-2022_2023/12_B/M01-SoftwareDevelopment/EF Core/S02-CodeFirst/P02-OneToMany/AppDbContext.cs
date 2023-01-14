using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AppDbContext : DbContext
{
    private string ConnectionString = @"Server=STEM-13\MSSQLSERVER01;Initial Catalog=EFOneToMany; Integrated Security=true; Trust Server Certificate=True";
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
}

