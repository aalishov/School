public class Program
{
    public static void Main()
    {
       
    }

    public static void ChangeNum(int[] a)
    {
        a[0] += 15;
    }

    public static void PrintNumbers()
    {
        for (int i = 0; i <= 100; i++)
        {
            Console.WriteLine($"{i}");
        }
    }
    public static string PrintNumbersTwo()
    {
        for (int i = 0; i <= 100; i++)
        {
            Console.WriteLine($"{i}");
        }
        return "";
    }
    public static int Sum(int a, int b)
    {
        return a + b;
    }
}
