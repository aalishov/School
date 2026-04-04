public class Program
{
    public static void Main()
    {
        int a = int.Parse(Console.ReadLine()!);
        int b = int.Parse(Console.ReadLine()!);

        while (a % b != 0)
        {
            int r = a % b;
            a = b;
            b = r;
        }
        Console.WriteLine($"NOD = {b}");
    }
}