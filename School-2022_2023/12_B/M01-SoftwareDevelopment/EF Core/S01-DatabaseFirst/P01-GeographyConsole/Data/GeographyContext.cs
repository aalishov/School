using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace P01_GeographyConsole.Data;

public partial class GeographyContext : DbContext
{
    public GeographyContext()
    {
    }

    public GeographyContext(DbContextOptions<GeographyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Continent> Continents { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Currency> Currencies { get; set; }

    public virtual DbSet<Mountain> Mountains { get; set; }

    public virtual DbSet<Peak> Peaks { get; set; }

    public virtual DbSet<River> Rivers { get; set; }

    public virtual DbSet<VHighestPeak> VHighestPeaks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=STEM-13\\MSSQLSERVER01;Initial Catalog=Geography; Integrated Security=true; Trust Server Certificate=True");
        optionsBuilder.UseLazyLoadingProxies();
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Continent>(entity =>
        {
            entity.HasKey(e => e.ContinentCode);

            entity.Property(e => e.ContinentCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ContinentName).HasMaxLength(50);
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.CountryCode);

            entity.Property(e => e.CountryCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Capital)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ContinentCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CountryName)
                .HasMaxLength(45)
                .IsUnicode(false);
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IsoCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.ContinentCodeNavigation).WithMany(p => p.Countries)
                .HasForeignKey(d => d.ContinentCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Countries_Continents");

            entity.HasOne(d => d.CurrencyCodeNavigation).WithMany(p => p.Countries)
                .HasForeignKey(d => d.CurrencyCode)
                .HasConstraintName("FK_Countries_Currencies");

            entity.HasMany(d => d.Rivers).WithMany(p => p.CountryCodes)
                .UsingEntity<Dictionary<string, object>>(
                    "CountriesRiver",
                    r => r.HasOne<River>().WithMany()
                        .HasForeignKey("RiverId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_CountriesRivers_Rivers"),
                    l => l.HasOne<Country>().WithMany()
                        .HasForeignKey("CountryCode")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_CountriesRivers_Countries"),
                    j =>
                    {
                        j.HasKey("CountryCode", "RiverId");
                    });
        });

        modelBuilder.Entity<Currency>(entity =>
        {
            entity.HasKey(e => e.CurrencyCode);

            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Description).HasMaxLength(200);
        });

        modelBuilder.Entity<Mountain>(entity =>
        {
            entity.Property(e => e.MountainRange).HasMaxLength(50);

            entity.HasMany(d => d.CountryCodes).WithMany(p => p.Mountains)
                .UsingEntity<Dictionary<string, object>>(
                    "MountainsCountry",
                    r => r.HasOne<Country>().WithMany()
                        .HasForeignKey("CountryCode")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_MountainsCountries_Countries"),
                    l => l.HasOne<Mountain>().WithMany()
                        .HasForeignKey("MountainId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_MountainsCountries_Mountains"),
                    j =>
                    {
                        j.HasKey("MountainId", "CountryCode").HasName("PK_MountainsContinents");
                    });
        });

        modelBuilder.Entity<Peak>(entity =>
        {
            entity.Property(e => e.PeakName).HasMaxLength(50);

            entity.HasOne(d => d.Mountain).WithMany(p => p.Peaks)
                .HasForeignKey(d => d.MountainId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Peaks_Mountains");
        });

        modelBuilder.Entity<River>(entity =>
        {
            entity.Property(e => e.Outflow).HasMaxLength(50);
            entity.Property(e => e.RiverName).HasMaxLength(50);
        });

        modelBuilder.Entity<VHighestPeak>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Highest_Peak");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.PeakName).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
