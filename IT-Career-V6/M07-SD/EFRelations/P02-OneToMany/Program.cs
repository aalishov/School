using P02_OneToMany.Data;
using P02_OneToMany.Data.Models;
using System.Globalization;

namespace P02_OneToMany
{
    public class Program
    {
        private static AppDbContext context = new AppDbContext();
        public static void Main(string[] args)
        {
            var models = context.Models
                .OrderBy(x=>x.Name)
                .ToList();

            foreach (var m in models)
            {
                Console.WriteLine($"{m.Name} => {m.Manufacturer.Name}");
            }

        }

        private static void InitalData()
        {
            var bmw = new Manufacturer() { Name = "BMW", EstablishedOn = DateTime.Parse("01-03-1916", CultureInfo.InvariantCulture) };
            var tesla = new Manufacturer() { Name = "Tesla", EstablishedOn = DateTime.Parse("01-01-2003", CultureInfo.InvariantCulture) };
            var lada = new Manufacturer() { Name = "Lada", EstablishedOn = DateTime.Parse("01-05-1966", CultureInfo.InvariantCulture) };


            var models = new List<Model>()
            {
                new Model(){Name="X1",Manufacturer=bmw},
                new Model(){Name="i6",Manufacturer=bmw},
                new Model(){Name="Model S",Manufacturer=tesla},
                new Model(){Name="Model X",Manufacturer=tesla},
                new Model(){Name="Model 3",Manufacturer=tesla},
                new Model(){Name="Nova",Manufacturer=lada},
            };

            context.Models.AddRange(models);
            context.SaveChanges();
        }
    }
}
