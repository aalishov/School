using System;

public class Program
{
    private static List<double> points = new List<double>();

    public static void Main(string[] args)
    {
        ReadPoints();

        Output();
    }

    private static void Output()
    {
        Console.WriteLine($"valid works - {points.Count}");
        Console.WriteLine($"minimal difference - {МinDpoints()} p.");
        Console.WriteLine($"laureates - {Laureates()}");
        Console.WriteLine(Laureates2(points));
    }
    //Код на мон
    static int Laureates2(List<double> points)
    {
        int countLaureates = 1, cntTo3 = 1;
        for (int i = 1; i < points.Count; i++)
        {
            if (points[i] != points[i - 1])
            {
                cntTo3++;
                if (cntTo3 > 3) break;
            }
            countLaureates++;
        }
        return countLaureates;
    }

    public static int Laureates()
    {
        return points.Where(x => x >= points.OrderByDescending(x => x)
        .Distinct()
        .Skip(2)
        .FirstOrDefault())
        .Count();
    }

    public static double МinDpoints()
    {
        List<double> finalPoints = points.Distinct().OrderBy(x => x).ToList();
        List<double> diff = new List<double>();

        for (int i = 0; i < finalPoints.Count - 1; i++)
        {
            double first = finalPoints[i];
            double second = finalPoints[i + 1];
            diff.Add(second - first);
        }
        return Math.Round(diff.OrderBy(x => x).FirstOrDefault(), 3);
    }

    private static void ReadPoints()
    {
        int n = ReadValidNumber(3, 10000);

        for (int i = 0; i < n; i++)
        {
            double num = ReadValidNumber(-100.0, 100.0);
            if (num > 0)
            {
                points.Add(num);
            }
        }
    }

    public static int ReadValidNumber(int min, int max)
    {
        while (true)
        {
            try
            {
                Console.Write($"Enter number [{min};{max}]:");
                int num = int.Parse(Console.ReadLine());
                if (num >= min && num <= max) { return num; }
                throw new ArgumentException();
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
    public static double ReadValidNumber(double min, double max)
    {
        while (true)
        {
            try
            {
                Console.Write($"Enter number [{min};{max}]:");
                double num = double.Parse(Console.ReadLine());
                if (num >= min && num <= max) { return num; }
                throw new ArgumentException();
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}
