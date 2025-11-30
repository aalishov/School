public class Program
{
    public static void Main()
    {
        Console.Write("Еnter a number in the range [1...100]: ");
        int n = int.Parse(Console.ReadLine());

        //!(n >= 100 & n <= 100) == n<1 || n>100
        while (n < 1 || n > 100)
        {
            Console.WriteLine("Invalid number!");

            Console.Write("Еnter a number in the range [1...100]: ");
            n = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"The number is: {n}");
    }
}

