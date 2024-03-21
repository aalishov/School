public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter point x1: ");
        double x1 = double.Parse(Console.ReadLine());
        Console.Write("Enter point y1: ");
        double y1 = double.Parse(Console.ReadLine());
        Console.Write("Enter point x2: ");
        double x2 = double.Parse(Console.ReadLine());
        Console.Write("Enter point y2: ");
        double y2 = double.Parse(Console.ReadLine());

        Point point1 = new Point(x1,y1);
        Point point2 = new Point(x2,y2);
        Console.WriteLine($"Euclidean - {Distances.Euclidean(point1,point2)}");
        Console.WriteLine($"Manhattan - {Distances.Manhattan(point1, point2)}");
        Console.WriteLine($"Chebyshev - {Distances.Chebyshev(point1, point2)}");
    }
}
public static class Distances
{
    public static double Euclidean(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
    }
    public static double Euclidean(Point point1, Point point2)
    {
        return Math.Sqrt(Math.Pow((point1.X - point2.X), 2) + Math.Pow((point1.Y - point2.Y), 2));
    }
    public static double Manhattan(double x1, double y1, double x2, double y2)
    {
        return Math.Abs(x1 - x2) + Math.Abs(y1 - y2);
    }
    public static double Manhattan(Point point1, Point point2)
    {
        return Math.Abs(point1.X - point2.X) + Math.Abs(point1.Y - point2.Y);
    }
    public static double Chebyshev(double x1, double y1, double x2, double y2)
    {
        return Math.Max(Math.Abs(x1 - x2), Math.Abs(y1 - y2));
    }
    public static double Chebyshev(Point point1, Point point2)
    {
        return Math.Max(Math.Abs(point1.X - point2.X), Math.Abs(point1.Y - point2.Y));
    }
}
public class Point
{
    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double X { get; private set; }
    public double Y { get; private set; }
}

