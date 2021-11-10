using P01_SoftUni.Data;
using P01_SoftUni.Data.Models;
using System;

namespace P01_SoftUni
{
    class Program
    {
        static void Main()
        {
            ApplicationDbContext dbContext = new ApplicationDbContext();

            dbContext.Towns.Add(new Town { Name = "Plovdiv" });

            dbContext.SaveChanges();
        }
    }
}
