public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
       
        for (int i = 0; i <= n; i++)
        {
            string spaces = new string(' ', n - i);
            string stars = new string('*', i);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{spaces}{stars}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($" | ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{stars}");
        }
    }
}

