using System.Globalization;
using System.IO;

public class Program
{
    static void Main(string[] args)
    {
        string day = Console.ReadLine();
        string path = $@"C:\Users\aalis\Desktop\Repo\School\School-2023-2024\12_B\DZIPrep_2023-2024\P19-Success-2_6_3\{day}.txt";
        CultureInfo bg = new CultureInfo("bg-BG");

        Console.WriteLine($"{bg.DateTimeFormat.DayNames[int.Parse(day)]} {File.ReadLines(path)
            .Select(x => x.Split(" ").LastOrDefault()).Where(x => x != "-")
            .Count()}");
    }
}

