using Microsoft.EntityFrameworkCore.Internal;
using P02_PizzaApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P02_PizzaApp.Data
{
    public class Seeder
    {
        public void Seed()
        {
            using(AppDbContext context = new AppDbContext())
            {
                if (!context.Sizes.Any())
                {
                    SeedSize();
                }
                if (!context.Paymants.Any())
                {
                    SeedPayment();
                }
                if (!context.Extras.Any())
                {
                    SeedExtars();
                }
            }
        }
        public void SeedSize()
        {
            using (AppDbContext context = new AppDbContext())
            {
                Size small = new Size()
                {
                    Width = "Small",
                    PricePerc = 0,
                };
                Size big = new Size()
                {
                    Width = "Big",
                    PricePerc = 5,
                };
                Size family = new Size()
                {
                    Width = "Family",
                    PricePerc = 10,
                };
                context.AddRange(new Size[] { small, big, family });
                context.SaveChanges();
            }
           
        }
        public void SeedPayment() 
        {
            using (AppDbContext context = new AppDbContext())
            {
                Paymant inCash = new Paymant()
                {
                    PaymantMethod = "In Cash"
                };
                Paymant online = new Paymant()
                {
                    PaymantMethod = "Online"
                };
                context.AddRange(new Paymant[] {inCash, online});
                context.SaveChanges();
            }            
        }
        public void SeedExtars()
        {
            using(AppDbContext context = new AppDbContext())
            {
                Extra ketchup = new Extra()
                {
                    Name = "Ketchup",
                    Price = 0.5m,
                };
                Extra mayo = new Extra()
                {
                    Name = "Mayonnaise",
                    Price = 0.5m,
                };
                Extra mustard = new Extra()
                {
                    Name = "Mustard",
                    Price = 0.5m,
                };
                Extra garlicSauce = new Extra()
                {
                    Name = "Garlic Sauce",
                    Price = 0.6m,
                };
                Extra soySauce = new Extra()
                {
                    Name = "Soy Sauce",
                    Price = 0.5m,
                };
                Extra chili = new Extra()
                {
                    Name = "Chili",
                    Price = 0.7m,
                };
                context.AddRange(new Extra[] {ketchup, mayo,mustard, garlicSauce,soySauce, chili});
                context.SaveChanges();
            }
        }
    }
    
}
