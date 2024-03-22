using System.Globalization;
using System.IO;

public class Program
{
    static void Main(string[] args)
    {
        string parent = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        string day = Console.ReadLine();
        string path = $@"{parent}\{day}.txt";

        CultureInfo bg = new CultureInfo("bg-BG");

        Console.WriteLine($"{bg.DateTimeFormat.DayNames[int.Parse(day)]} {
            File.ReadLines(path)
            .Select(x => x.Split(" ").LastOrDefault())
            .Where(x => x != "-")
            .Count()}");
    }
}

