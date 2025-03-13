using P02_Geography.Data.Models;

namespace P02_Geography
{
    public class Program
    {
        public static void Main()
        {
            GeographyContext context = new GeographyContext();
            List<Country> countries= context.Countries.ToList();

            foreach (Country country in countries) 
            {
                Console.WriteLine($"{country.CountryName}");
            }
        }
    }
}
