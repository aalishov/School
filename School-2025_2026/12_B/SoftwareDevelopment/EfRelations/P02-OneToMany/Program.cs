using P02_OneToMany.Data;
using P02_OneToMany.Data.Models;

namespace P02_OneToMany
{
    public class Program
    {
        private static AppDbContext context = new AppDbContext();
        public static void Main()
        {
            InsertInitalData();
            AddModel("BMW", "E90 335xi");

            PrintManufacturerInfo();
        }
        public static void AddModel(string manufacturerName, string modelName)
        {
            Manufacturer m = context.Manufacturers.FirstOrDefault(x => x.Name == manufacturerName);
            if (m == null) { Console.WriteLine("Invalid manufacturer"); return; }
            Model model = m.Models.FirstOrDefault(x => x.Name == modelName);
            if (model != null) { Console.WriteLine("Already exist!"); return; }

            model = new Model() { Name = modelName, Manufacturer = m };
            context.Models.Add(model);
            int result = context.SaveChanges();
            if (result!=0)
            {
                Console.WriteLine("Model added!");
            }
        }
        public static void PrintManufacturerInfo()
        {
            foreach (var m in context.Manufacturers)
            {
                Console.WriteLine($"{m.Name} - {m.EstablishedOn.Value.ToShortDateString()}");
                foreach (var model in m.Models)
                {
                    Console.WriteLine($"\t-{model.Name}");
                }
            }
        }
        public static void InsertInitalData()
        {
            if (context.Manufacturers.Any()) { return; }
            Manufacturer bmw = new Manufacturer()
            {
                Name = "BMW",
                EstablishedOn = new DateTime(1916, 03, 7)
            };
            Manufacturer tesla = new Manufacturer()
            {
                Name = "Tesla",
                EstablishedOn = new DateTime(2003, 01, 01)
            };
            Manufacturer lada = new Manufacturer()
            {
                Name = "Lada",
                EstablishedOn = new DateTime(1966, 05, 11)
            };
            List<Model> models = new List<Model>()
            {
                new Model(){Name="X1",Manufacturer=bmw},
                new Model(){Name="i6",Manufacturer=bmw},
                new Model(){Name="Model S",Manufacturer=tesla},
                new Model(){Name="Model X",Manufacturer=tesla},
                new Model(){Name="Model 3",Manufacturer=tesla},
                new Model(){Name="Nova",Manufacturer=lada},
            };
            context.Models.AddRange(models);
            int result = context.SaveChanges();
            Console.WriteLine($"Entries chnaged: {result}");
        }
    }
}
