public class Program
{
    public static void Main()
    {
        Console.WriteLine($"Area: {CalculateArea(ReadNumber(), ReadNumber())}");
    }

    private static double CalculateArea(double a, double b)
    {
        return a * b;
    }

    private static double ReadNumber()
    {
        Console.Write("Enter number: ");
        double a = double.Parse(Console.ReadLine());
        return a;
    }
}
