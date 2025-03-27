public class Program
{
    public static void Main()
    {
        PrintOutput();
    }

    private static void PrintOutput()
    {
        try
        {
            List<double> points = ReadPoints();

            Console.WriteLine($"minimal difference - {МinDpoints(points)} p.");
            Console.WriteLine(string.Join(", ", points.OrderByDescending(x => x)));
            Console.WriteLine("laureates - " + Laureates(points));
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static int Laureates(List<double> points)
    {
        return points.Count(x => x >= points.Distinct().OrderByDescending(z => z).Skip(2).Take(1).First());
    }

    private static double МinDpoints(List<double> points)
    {
        List<double> unique = points.Distinct().ToList();
        double minValue = double.MaxValue;
        for (int i = 0; i < unique.Count - 1; i++)
        {
            if (unique[i + 1] - unique[i] < minValue)
            {
                minValue = unique[i + 1] - unique[i];
            }
        }
        return Math.Round(minValue, 3);
    }

    private static List<double> ReadPoints()
    {
        int n = int.Parse(Console.ReadLine());

        List<double> list = new List<double>();

        for (int i = 0; i < n; i++)
        {
            list.Add(double.Parse(Console.ReadLine()));
        }

        return list.Where(x => x > 0).OrderBy(x => x).ToList();
    }
}