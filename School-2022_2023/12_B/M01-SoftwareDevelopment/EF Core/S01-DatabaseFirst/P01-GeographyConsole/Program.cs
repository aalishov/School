
using P01_GeographyConsole.Data;

public class Program
{
    private static GeographyContext db = new GeographyContext();
    public static void Main()
    {
        PrintPeaksInfo();
    }
    public static void PrintPeaksInfo()
    {
        string header = $"{"Id",-5}|{"Name",-25}|{"Mountain",-20}";
        Console.WriteLine(header);
        Console.WriteLine(new string('-',header.Length));
        foreach (var p in db.Peaks.ToList())
        {
            Console.WriteLine($"{p.Id,-5}|{p.PeakName,-20}|{p.Mountain.MountainRange,-25}");
            Console.WriteLine(new string('-', header.Length));
        }
    }
    public static void PrintCountries()
    {
        List<Country> countries = db.Countries
            .ToList();
        foreach (var c in countries)
        {
            Console.WriteLine($"{c.CountryName} -> {c.ContinentCodeNavigation.ContinentName}");
        }
    }

    public static void PrintContinents()
    {
        List<Continent> continents = db.Continents
            .Where(x => x.ContinentName.StartsWith("A"))
            .OrderBy(x => x.ContinentName)
            .ToList();
        Console.WriteLine("Continents list:");
        foreach (var c in continents)
        {
            Console.WriteLine($"{c.ContinentCode} - {c.ContinentName}");
        }
    }
}
