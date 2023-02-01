using Microsoft.EntityFrameworkCore;
using P01_Airport.Data;

namespace P01_Airport
{
    public class Program
    {
        public static void Main()
        {
            SoftUniContext context = new SoftUniContext();

            

            foreach (var address in context.Addresses.ToList())
            {
                Console.WriteLine($"{address.AddressId} - {address.AddressText} - {address.Town.Name}");
            }
        }
    }
}