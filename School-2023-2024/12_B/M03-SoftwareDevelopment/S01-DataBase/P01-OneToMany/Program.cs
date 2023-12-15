using P01_OneToMany.Data;
using P01_OneToMany.Data.Models;
using System.Text;

namespace P01_OneToMany
{
    public class Program
    {
       static AppDbContext db = new AppDbContext();
        public static void Main()
        {
            while (true)
            {
                string data = Console.ReadLine();
                if (data=="End")
                {
                    break;
                }
                string modelName = string.Empty;
                string manufacturerName = string.Empty;
                switch (data)
                {
                    case "Create manufacturer":
                        Console.Write($"Enter manufacturer name: ");
                        modelName = Console.ReadLine();
                        Console.Write("Enter year, month and day of establishment: ");
                        int[] dateInfo = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                        int year = dateInfo[0];
                        int month = dateInfo[1];
                        int day = dateInfo[2];
                        Console.WriteLine(CreateManufacturer(modelName, year, month, day));
                        break;
                    case "Create model":
                        Console.Write($"Enter model name: ");
                         modelName = Console.ReadLine();
                        Console.Write($"Enter manufacturer name: ");
                        manufacturerName = Console.ReadLine();
                        Console.WriteLine(CreateModel(modelName,manufacturerName));
                        break;
                    case "Get model info":
                        Console.Write($"Enter model name: ");
                        modelName = Console.ReadLine();
                        Console.WriteLine(GetModelInfo(modelName));
                        break;
                }
               
            }
           
        }

        public static string CreateModel(string modelName,string manufacturerName)
        {
            try
            {
                int manufacturerId = db.Manufacturers.FirstOrDefault(x => x.Name == manufacturerName).Id;
                Model model = new Model() { Name = modelName, ManufacturerId = manufacturerId };
                db.Models.Add(model);
                db.SaveChanges();
                return "New model is successfully added.";
            }
            catch (Exception)
            {
                return "Error...";
            }
             


        }

        public static string CreateManufacturer(string mName, int year, int month, int day)
        {
            try
            {
                DateTime establisheOn = new DateTime(year, month, day);
                Manufacturer m = new Manufacturer()
                { Name = mName, EstablishedOn = establisheOn };
                db.Manufacturers.Add(m);
                db.SaveChanges();
                return "Successfully added new manufacturer...";
            }
            catch (Exception)
            {
                return "Error...";
            }
        }
        public static string GetModelInfo(string modelName)
        {
            try
            {
                Model m = db.Models.FirstOrDefault(x => x.Name == modelName);
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Model info:");
                sb.AppendLine($"\tModel name: {modelName}");
                sb.AppendLine($"\tManufacturer name: {m.Manufacturer.Name}");
                sb.AppendLine($"\tManufacturer is established on: {((DateTime)(m.Manufacturer.EstablishedOn)).ToString("yyyy-MM-dd")}");
                return sb.ToString().TrimEnd();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
           
        }
    }
}