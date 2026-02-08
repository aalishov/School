public class Program
{
    public static void Main()
    {
        double day1 = 12;
        double day2 = 12.3;
        double day3 = 8;

        int[] nums = { 15, 20, 12, 3, 45 };
        double[] t = new double[10];


        for (int i = 0; i <= t.Length; i++)
        {
            Console.Write($"t[{i}] = ");
            t[i] = double.Parse(Console.ReadLine());
        }

        for (int i = 0; i < t.Length; i++)
        {
            Console.WriteLine($"t[{i}] = {t[i]}");
        }
    }
}

