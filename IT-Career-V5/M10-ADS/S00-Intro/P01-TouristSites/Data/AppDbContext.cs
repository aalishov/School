using Microsoft.EntityFrameworkCore;
using P01_TouristSites.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_TouristSites.Data
{
    public class AppDbContext:DbContext
    {
        private string connectionString = "Server=STEM-13\\MSSQLSERVER01;Initial Catalog=NationalTouristSitesOfBulgaria; Integrated Security=true; Trust Server Certificate=True";
        public virtual DbSet<BonusPrize> BonusPrizes { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Site> Sites { get; set; }
        public virtual DbSet<SiteTourist> SiteTourists { get; set; }
        public virtual DbSet<Tourist> Tourists { get; set; }
        public virtual DbSet<TouristBonusPrize> TouristsBonusPrizes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
            optionsBuilder.UseLazyLoadingProxies();
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<TouristBonusPrize>(option =>
        //        {
        //            option.HasKey(t => new { t.BonusPrizeId, t.TouristId });
        //    });
        //    modelBuilder.Entity<SiteTourist>(option =>
        //    {
        //        option.HasKey(s => new { s.SiteId,s.TouristId });
        //    });
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
