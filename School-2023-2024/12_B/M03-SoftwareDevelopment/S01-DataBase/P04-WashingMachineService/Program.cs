using Castle.Components.DictionaryAdapter.Xml;
using System.Numerics;
using WashingMachineService.Data;
using WashingMachineService.Data.Models;
namespace WashingMachineService
{

    public class Program
    {
        private static AppDbContext context = new AppDbContext();
        public static void Main()
        {
            var result = context.Jobs.Where(x => x.Status == "Finished")
                .Select(x => new { 
                                     Id = x.JobId, 
                                     Total = x.PartsNeeded.Select(x => x.Quantity * x.Part.Price).Sum() 
                                })
                .OrderByDescending(x => x.Total)
                .ThenBy(x=>x.Id)
                .Take(3)
                .Select(a=>$"{a.Id} {a.Total:f2}");

            Console.WriteLine(string.Join(Environment.NewLine, result));
        }

        private static void GetAvailableMechanics()
        {
            var activeJobs = context.Jobs.Where(x => x.Status != "Finished").Select(x => x.MechanicId).Distinct().ToList();

            var result = context.Mechanics
                .Where(x => activeJobs.All(m => x.MechanicId != m))
                .OrderBy(x => x.MechanicId)
                .Select(x => $"{x.FirstName} {x.LastName}")
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, result));
        }

        //var result = context
        //          .Parts
        //          .Select(x => $"{x.PartId} {x.Description} {x.PartsNeeded.Sum(pn => pn.Quantity)} {x.OrdersParts.Sum(x => x.Quantity)}")
        //          .ToList();
        //Console.WriteLine(string.Join(Environment.NewLine, result));

        private static void GetMechanicPerformance()
        {
            var result = context.Mechanics.ToList()
                            .Select(x => $"{x.FirstName} {x.LastName} {Math.Floor(x.Jobs
                                .Where(j => j.Status == "Finished")
                                .Select(j => ((DateTime)j.FinishDate - j.IssueDate).TotalDays).Average())}");
            foreach (var m in result)
            {
                Console.WriteLine(m);
            }
        }

        private static void GetCurrentClients()
        {
            var result = context.Jobs
                .Where(j => j.Status != "Finished")
                .Select(x => $"{x.Client.FirstName} {x.Client.LastName} {(x.IssueDate - new DateTime(2017, 4, 24)).TotalDays} {x.Status}").ToList();
            foreach (var j in result)
            {
                Console.WriteLine(j);
            }
        }

        private static void GetMechanicAssignments()
        {
            var result = context.Mechanics
                  .OrderBy(m => m.MechanicId)
                  .Select(m => m.Jobs
                                .OrderBy(x => x.IssueDate)
                                .ThenBy(x => x.JobId)
                                .Select(j => $"{m.FirstName} {m.LastName} {j.Status} {j.IssueDate.ToString("yyyy-MM-dd")}"))
                  .ToList();

            foreach (var m in result)
            {
                Console.WriteLine(string.Join(Environment.NewLine, m));
            }

            //foreach (var m in context.Mechanics.OrderBy(x => x.MechanicId).ToList())
            //{
            //    foreach (var j in m.Jobs.OrderBy(x => x.IssueDate).ThenBy(x => x.JobId))
            //    {
            //        Console.WriteLine($"{m.FirstName} {m.LastName} {j.Status} {j.IssueDate.ToString("yyyy-MM-dd")}");
            //    }
            //}
        }

        public static void InsertClients()
        {
            try
            {
                List<Client> clients = new List<Client>()
                {
                    new Client() { FirstName = "Teri", LastName = "Ennaco", Phone = "570-889-5187" },
                    new Client() { FirstName = "Merlyn", LastName = "Lawyer", Phone = "201-588-7810" },
                    new Client()
                    { FirstName = "Georgene", LastName = "Montezuma", Phone = "925-615-5185" },
                    new Client()
                    { FirstName = "Jettie", LastName = "Mconnell", Phone = "908-802-3564" },
                    new Client()
                    { FirstName = "Lemuel", LastName = "Latzke", Phone = "631-748-6479" },
                    new Client()
                    { FirstName = "Melodie", LastName = "Knipp", Phone = "805-690-1682" },
                    new Client()
                    { FirstName = "Candida", LastName = "Corbley", Phone = "908-275-8357" }
            };

                context.Clients.AddRange(clients);
                context.SaveChanges();

                Console.WriteLine("Data added successfully");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
        public static void InsertParts()
        {
            try
            {
                List<Part> parts = new List<Part> {

                new Part() { SerialNumber= "WP8182119", Description="Door Boot Seal",Price=117.86m,VendorId=2 },
                new Part() { SerialNumber= "W10780048", Description="Suspension Rod",Price=42.81m,VendorId=1 },
                new Part() { SerialNumber= "W10841140", Description="Silicone Adhesive ",Price=6.77m,VendorId=4 },
                new Part() { SerialNumber= "WPY055980", Description="High Temperature Adhesive",Price=13.94m,VendorId=3 }

                };
                context.Parts.AddRange(parts);
                context.SaveChanges();
                Console.WriteLine("Parts added successfully!");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

    }
}