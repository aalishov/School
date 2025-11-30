public class Program
{
    public static void Main()
    {
        NumValidator(5,20);
    }

    private static int NumValidator(int min = 1, int max = 100)
    {
        while (true)
        {
            Console.Write($"Еnter a number in the range [{min}...{max}]: ");
            int n = int.Parse(Console.ReadLine());

            if (n < min || n > max)
            {
                Console.WriteLine("Invalid number!");
            }
            else
            {
                Console.WriteLine($"The number is: {n}");
                return n;
            }
        }
    }
}

