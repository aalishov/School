using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main(string[] args)
    {
        double[] numbers = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse)
            .ToArray();

        SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

        foreach (double number in numbers)
        {
            {
                if (!counts.ContainsKey(number))
                {
                    counts[number] = 0;
                }
                counts[number]++;
            }
        }

        foreach (var item in counts)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}
