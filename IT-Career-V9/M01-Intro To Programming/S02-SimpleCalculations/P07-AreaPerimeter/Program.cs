using System.Globalization;

public class Program
{
    public static void Main()
    {
        //Thread.CurrentThread.CurrentCulture = new CultureInfo("gb-GB");

        Console.OutputEncoding = System.Text.Encoding.ASCII;

        double r = double.Parse(Console.ReadLine());

        double area = Math.PI * r * r;
        double perimeter = 2 * Math.PI * r;

        Console.WriteLine($"Площ = {area:f2}");
        Console.WriteLine($"Perimeter = {perimeter:f2}");
    }
}

