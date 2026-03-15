public class Program
{
    private const double MicroscopePrice = 6000;
    private const double ScalpelPrice = 1500;
    private const double SyringePrice = 100;

    public static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);

        double totalPrice = 0;

        for (int i = 0; i < n; i++)
        {
            string product = Console.ReadLine()!;

            switch (product)
            {
                case "microscope":
                    totalPrice += MicroscopePrice;
                    break;
                case "scalpel":
                    totalPrice+= ScalpelPrice;
                    break;
                case "syringe":
                    totalPrice += SyringePrice;
                    break;
            }
        }
        Console.WriteLine($"{totalPrice:f2}");
    }
}