public class Program
{
    private static List<double> points = new List<double>();

    public static void Main()
    {
        ReadPoints();
        Console.WriteLine($"valid works - {points.Count}");
        Console.WriteLine($"minimal difference - {МinDpoints():f3}p.");
        Console.WriteLine($"laureates - {Laureates()}");
    }

    private static int Laureates()
    {
        double third = points[points.Count - 3];

        return points.Count(x => x >= third);
    }

    private static double МinDpoints()
    {
      
        double minDiff = 100;
        for (int i = 0; i < points.Count - 1; i++)
        {
            double result = points[i + 1] - points[i];
            if (result > 0 && result < minDiff)
            {
                minDiff = result;
            }
        }
        return minDiff;
    }

    private static void ReadPoints()
    {
        int n = ReadNumber(3, 10000);

        for (int i = 0; i < n; i++)
        {
            double studentPoints = ReadNumber(-100.0, 100.0);
            if (studentPoints > 0) { points.Add(studentPoints); }
        }
        points = points.OrderBy(x => x).ToList();
    }

    private static int ReadNumber(int min, int max)
    {
        while (true)
        {
            Console.WriteLine($"Enter students count (between {min} and {max}): ");
            int num = int.Parse(Console.ReadLine());
            if (num >= min && num <= max) { return num; }
            Console.WriteLine("Invalid number!");
        }
    }
    private static double ReadNumber(double min, double max)
    {
        while (true)
        {
            Console.WriteLine($"Enter student points between {min} and {max}: ");
            double num = double.Parse(Console.ReadLine());
            if (num >= min && num <= max) { return num; }
            Console.WriteLine("Invalid number!");
        }
    }
}