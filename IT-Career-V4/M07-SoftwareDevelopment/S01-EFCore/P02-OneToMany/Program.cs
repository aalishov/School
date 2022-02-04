using P02_OneToMany.Data;
using P02_OneToMany.Data.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace P02_OneToMany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDbContext context = new AppDbContext();
            //Manufacturer bmw = new Manufacturer()
            //{
            //    Name = "BMW",
            //    EstablishedOn = DateTime.ParseExact("01/03/1916", "dd/mm/yyyy", CultureInfo.InvariantCulture)
            //};
            //Manufacturer tesla = new Manufacturer()
            //{
            //    Name = "Tesla",
            //    EstablishedOn = DateTime.ParseExact("01/01/2003", "dd/mm/yyyy", CultureInfo.InvariantCulture)
            //};
            //Model x1 = new Model() { Name = "X1", Manufacturer = bmw };
            //Model x5 = new Model() { Name = "X5", Manufacturer = bmw };
            //Model s = new Model() { Name = "Model S", Manufacturer = tesla };
            //Model x = new Model() { Name = "Model X", Manufacturer = tesla };
            //Model m3 = new Model() { Name = "Model 3", Manufacturer = tesla };

            //context.Models.AddRange(x1, x5, s, x, m3);
            //context.SaveChanges();

            List<Model> models = context.Models.ToList();
            foreach (var model in models)
            {
                Console.WriteLine($"{model.Name} => {model.Manufacturer.Name} ");
            }
        }
    }
}
