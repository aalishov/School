public class Program
{
    public static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine(SmallestOfThreeNumbers(a, b, c));
    }

    public static int SmallestOfThreeNumbers(int a, int b, int c)
    {
        if (a < b && a < c) return a;
        else if (b < a && b < c) return b;
        else return c;

        // return Math.Max(Math.Max(a,b),c);
    }
}

