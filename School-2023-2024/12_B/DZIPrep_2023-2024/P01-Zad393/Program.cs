public class Program
{
    public static void Main()
    {
        int[] a = ReadArray();

        double x = double.Parse(Console.ReadLine());

        double sum = 0;
        for (int i = 0; i < a.Length; i++)
        {
            sum += Sum3(x, a[i]);
        }
        Console.WriteLine(sum);

    }

    private static int[] ReadArray()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {

            a[i] = new Random().Next(1, 10);
        }
        Array.Sort(a);
        Array.Reverse(a);
        Console.WriteLine(string.Join(" ", a));
        return a;
    }

    private static void Run1()
    {
        double x = double.Parse(Console.ReadLine());

        double result = 10 * x * Sum3(x, 5) + Sum3(x, 2);
        Console.WriteLine(result);
    }

    public static double Sum3(double x, int a)
    {
        return Math.Pow((x + a), 3);
    }
}
