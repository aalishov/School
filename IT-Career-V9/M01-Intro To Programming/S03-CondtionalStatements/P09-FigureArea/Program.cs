public class Program
{
    public static void Main()
    {
        string type = Console.ReadLine();
        double result = 0.0;

        switch (type)
        {
            case "square":
                double a = double.Parse(Console.ReadLine());
                result = a * a;
                break;
            case "circle":
                double r = double.Parse(Console.ReadLine());
                result = Math.PI * r * r;
                break;
            case "rectangle":
                double a1 = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                result = a1 * b;
                break;
            case "triangle":
                double c = double.Parse(Console.ReadLine());
                double hc = double.Parse(Console.ReadLine());
                result = (c * hc) / 2;
                break;
        }

        Console.WriteLine($"{Math.Round(result, 3)}");
    }
}

