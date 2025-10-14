public class Program
{
    public static void Main()
    {
        SortedSet<int> winers = new SortedSet<int>();
        int loopsCount = 0;

        while (winers.Count < 5)
        {
            int num = new Random().Next(1, 35);
            winers.Add(num);
            loopsCount++;
        }
        Console.WriteLine(string.Join(", ", winers));
        Console.WriteLine($"Loops count: {loopsCount}");
    }
}