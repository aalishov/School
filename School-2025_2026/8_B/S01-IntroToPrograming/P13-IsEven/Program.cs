public class Program
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine()); //5

        bool isEven = num % 2 == 0;

        if (isEven)
        {
            Console.WriteLine($"{num} - even!");
        }
        else
        {
            Console.WriteLine($"{num} - odd!");
        }
    }
}

