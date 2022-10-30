using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int midCol = n / 2;
        int mid = (2 * n) - 4 - (2 * (n / 2));
        int space = 2 * n - 2;

        //First row
        string colString = Col('/', '^', midCol, '\\');
        string midString = $"{new string('_', mid)}";
        Console.WriteLine($"{colString}{midString}{colString}");

        //Mid rows
        for (int i = 1; i <= n - 3; i++)
        {
            Console.WriteLine($"|{new string(' ', space)}|");
        }

        Console.WriteLine($"|{new string(' ', midCol + 1)}{midString}{new string(' ', midCol + 1)}|");
        //Last row
        string lastColString= Col('\\', '_', midCol, '/');
        Console.WriteLine($"{lastColString}{new string(' ', mid)}{lastColString}");
    }

    public static string Col(char left, char mid, int midCount, char right)
    {
        return $"{left}{new string(mid, midCount)}{right}";
    }
}
