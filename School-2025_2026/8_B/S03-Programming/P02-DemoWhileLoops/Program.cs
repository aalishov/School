public class Program
{
    public static void Main()
    {
        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine()!);
        while (a <= 50)
        {
            Console.Write("Enter a: ");
            a = int.Parse(Console.ReadLine()!);

            if (a == 0)
            {
                break;
            }
        }
    }
}

