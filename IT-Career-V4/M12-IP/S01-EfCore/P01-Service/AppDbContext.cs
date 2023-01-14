using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


public class AppDbContext : DbContext
{
    private string conectionString = @"Server=STEM-13\MSSQLSERVER01;Initial Catalog=EfServices; Integrated Security=true; Trusted_Connection = True";
    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<Employee> Employees { get; set; }
    public virtual DbSet<Category> Categories { get; set; }
    public virtual DbSet<Status> Status { get; set; }
    public virtual DbSet<Report> Reports { get; set; }
    public virtual DbSet<Department> Departments { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       
        modelBuilder.Entity<User>()
            .HasIndex(u => u.Username)
            .IsUnique();

        modelBuilder.Entity<Report>()
            .HasOne(r => r.User)
            .WithMany(u => u.Reports)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Employee>()
            .HasMany(e=>e.Reports)
            .WithOne(r=>r.Employee)
            .OnDelete(DeleteBehavior.NoAction);
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(conectionString);
        }
        optionsBuilder.UseLazyLoadingProxies(true);
    }
}

