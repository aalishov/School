public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Print(n);
    }

    public static void Print(int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(i);
        }
    }
}

