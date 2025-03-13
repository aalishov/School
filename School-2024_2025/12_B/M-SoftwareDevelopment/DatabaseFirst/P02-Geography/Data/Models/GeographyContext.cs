using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace P02_Geography.Data.Models;

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

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server= STEM-13\\MSSQLSERVER01; Database=Geography; Integrated Security=True; TrustServerCertificate=True;");

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
                        j.ToTable("CountriesRivers");
                        j.IndexerProperty<string>("CountryCode")
                            .HasMaxLength(2)
                            .IsUnicode(false)
                            .IsFixedLength();
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
                        j.ToTable("MountainsCountries");
                        j.IndexerProperty<string>("CountryCode")
                            .HasMaxLength(2)
                            .IsUnicode(false)
                            .IsFixedLength();
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

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
