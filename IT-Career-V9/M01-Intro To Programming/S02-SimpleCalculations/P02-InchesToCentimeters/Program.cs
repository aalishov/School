public class Program
{
    private const double InchToCentimeter = 2.54;
    public static void Main()
    {
        Console.Write("Inches = ");
        double inches = double.Parse(Console.ReadLine());
        double centimeters = inches * InchToCentimeter;
        Console.WriteLine($"Centimeters = {centimeters}");
    }
}

