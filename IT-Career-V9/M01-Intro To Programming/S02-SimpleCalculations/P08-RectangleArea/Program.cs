public class Program
{
    public static void Main()
    {
        //Input point A(x1;y1)
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        //Input point B(x2;y2)
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        //Calculations
        double a = Math.Abs(y1 - y2);
        double b = Math.Abs(x1 - x2);

        double s = a * b;
        double p = 2 * a + 2 * b;

        //Output
        Console.WriteLine(s);
        Console.WriteLine(p);
    }
}

