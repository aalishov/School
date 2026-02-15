public class Program
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        if (num > 0)
        {
            Console.WriteLine($"{num} - positive number");
        }
        else if (num < 0)
        {
            Console.WriteLine($"{num} - negative number");
        }
        else
        {
            Console.WriteLine($"{num} - zero");
        }
    }
}

