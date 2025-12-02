using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace P01_DemoDbFirst.Data.Models;

public partial class ShoesApplicationDatabaseContext : DbContext
{
    public ShoesApplicationDatabaseContext()
    {
    }

    public ShoesApplicationDatabaseContext(DbContextOptions<ShoesApplicationDatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Brand> Brands { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Shoe> Shoes { get; set; }

    public virtual DbSet<Size> Sizes { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server= STEM-13\\MSSQLSERVER01; Database= ShoesApplicationDatabase; Integrated Security=True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Brand>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Brands__3214EC275E4D975C");

            entity.HasIndex(e => e.Name, "UQ__Brands__737584F68353E429").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Orders__3214EC27B14904BA");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.HasOne(d => d.Shoe).WithMany(p => p.Orders)
                .HasForeignKey(d => d.ShoeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_orders_shoes");

            entity.HasOne(d => d.Size).WithMany(p => p.Orders)
                .HasForeignKey(d => d.SizeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_orders_sizes");

            entity.HasOne(d => d.User).WithMany(p => p.Orders)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_orders_users");
        });

        modelBuilder.Entity<Shoe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Shoes__3214EC27076B2499");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Model).HasMaxLength(30);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Brand).WithMany(p => p.Shoes)
                .HasForeignKey(d => d.BrandId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_shoes_brands");

            entity.HasMany(d => d.Sizes).WithMany(p => p.Shoes)
                .UsingEntity<Dictionary<string, object>>(
                    "ShoesSize",
                    r => r.HasOne<Size>().WithMany()
                        .HasForeignKey("SizeId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_ShoesSize_Sizes"),
                    l => l.HasOne<Shoe>().WithMany()
                        .HasForeignKey("ShoeId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_ShoesSize_Shoes"),
                    j =>
                    {
                        j.HasKey("ShoeId", "SizeId").HasName("pk_ShoesSizes");
                        j.ToTable("ShoesSizes");
                    });
        });

        modelBuilder.Entity<Size>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Sizes__3214EC278FA3239B");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Cm)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("CM");
            entity.Property(e => e.Eu)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("EU");
            entity.Property(e => e.In)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("IN");
            entity.Property(e => e.Uk)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("UK");
            entity.Property(e => e.Us)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("US");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Users__3214EC271E813D14");

            entity.HasIndex(e => e.Username, "UQ__Users__536C85E4118C4F64").IsUnique();

            entity.HasIndex(e => e.Email, "UQ__Users__A9D105343145B675").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FullName).HasMaxLength(100);
            entity.Property(e => e.PhoneNumber).HasMaxLength(15);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
