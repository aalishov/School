using Microsoft.EntityFrameworkCore.Storage;
using P01_DemoDbFirst.Data.Models;

namespace P01_DemoDbFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShoesApplicationDatabaseContext context = new ShoesApplicationDatabaseContext();
                        

            foreach (var item in context.Users.ToList())
            {
                Console.WriteLine($"{item.FullName} - {item.Email}");
            }
        }
    }
}
