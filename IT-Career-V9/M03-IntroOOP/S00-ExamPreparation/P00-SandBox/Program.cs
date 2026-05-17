public class Program
{
    public static void Main()
    {
        List<int> numbers = new List<int> {1,3,3,4,5 };
        Console.WriteLine($"Count: {numbers.Count}");
        Console.WriteLine($"Capacity: {numbers.Capacity}");
    }
}