using RealEstates.Data;
using RealEstates.Services;
using System;

namespace RealEstates.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext applicationDbContext = new ApplicationDbContext();
            PropertiesService propertiesService = new PropertiesService(applicationDbContext);
            Engine engine = new Engine(propertiesService);
            engine.ListOperations();
        }
    }
}
