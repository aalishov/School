using P01_SoftUni.Data.Models;

namespace P01_SoftUni
{
    public class Program
    {
        //CRUD
        public static void Main(string[] args)
        {
            //UpdateTownName();
            DeleteTown();
            //AddTown();
            Console.WriteLine();
            //PrintAllTowns();
        }

        private static void DeleteTown()
        {
            Console.Write("Enter town id: ");
            int id = int.Parse(Console.ReadLine());

            SoftUniContext context = new SoftUniContext();
            Town t = context.Towns.Find(id);

            if (t != null)
            {
                context.Towns.Remove(t);
                context.SaveChanges();
                Console.WriteLine("Town is deleted");
            }
            else
            {
                Console.WriteLine("Invalid town id!");
            }
        }

        private static void UpdateTownName()
        {
            Console.Write("Enter town id: ");
            int id = int.Parse(Console.ReadLine());

            SoftUniContext context = new SoftUniContext();
            Town t = context.Towns.Find(id);

            if (t != null)
            {
                Console.Write($"Enter town {t.Name} new name: ");
                string newName = Console.ReadLine();
                t.Name = newName;
                context.Towns.Update(t);
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Invalid town id!");
            }
        }

        private static void AddTown()
        {
            Console.Write("Enter town name: ");
            string townName = Console.ReadLine();
            Town town = new Town() { Name = townName };

            SoftUniContext context = new SoftUniContext();
            context.Towns.Add(town);
            context.SaveChanges();
        }

        private static void PrintAllTowns()
        {
            SoftUniContext context = new SoftUniContext();

            List<Town> towns = context.Towns.ToList();
            

            foreach (Town t in towns)
            {
                Console.WriteLine($"{t.TownId} - {t.Name}");
            }
        }
    }
}
