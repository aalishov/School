namespace RealEstates.Importer
{
    using RealEstates.Data;
    using RealEstates.Data.Models;
    using RealEstates.Services;
    using RealEstates.ViewModels;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json;
    class Program
    {
        static void Main(string[] args)
        {
            var json = File.ReadAllText("imot.bg-raw-data-2020-07-23.json");
            var properties = JsonSerializer.Deserialize<IEnumerable<JosnProperty>>(json);
            var db = new ApplicationDbContext();
            PropertiesService service = new PropertiesService(db);

            foreach (var property in properties)
            {
                try
                {
                    service.Create(new PropertyInputViewModel()
                    {
                        District = property.District,
                        Size = property.Size,
                        Year = property.Year,
                        Price = property.Price,
                        PropertyType = property.Type,
                        BuildingType = property.BuildingType,
                        Floor = property.Floor,
                        TotalFloors = property.TotalFloors
                    });
                    Console.WriteLine("Add...");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
