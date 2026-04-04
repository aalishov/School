public class Program
{
    public static void Main()
    {
        double eps = 0.001;
        double a = double.Parse(Console.ReadLine()!);
        double x = a / 2.0; // Initial guess
        double xs = x;
        do
        {
            xs = x;
            x = (xs + a / xs) / 2.0; // Update guess using the average
        } while (xs - x >= eps);
        Console.WriteLine($"{x:f3}");
    }
}