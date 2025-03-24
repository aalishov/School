public class Program
{
    public static void Main()
    {
		try
		{
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            if (a <= 0 && b > 0)
            {
                Console.WriteLine($"Всички реални числа са решения");
            }
            else if (a > 0 && b > 0)
            {
                double root = Math.Sqrt(b / a);
                Console.WriteLine($"Решенията са (-{root:f2}; {root:f2})");
            }
            else if (a < 0 && b <= 0)
            {
                double root = Math.Sqrt(b / a);
                Console.WriteLine($"Решенията са (-inf; -{root:f2}) U ({root:f2}; +inf)");
            }
            else
            {
                Console.WriteLine($"Няма реални решения");
            }
        }
		catch (Exception)
		{

            Console.WriteLine("Некоректно въведено число");
		}
    }
}