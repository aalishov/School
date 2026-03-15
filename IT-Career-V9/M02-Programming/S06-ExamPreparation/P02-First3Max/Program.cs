public class Program
{
    public static void Main()
    {
        List<int> result= Console.ReadLine()!
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .OrderByDescending(x => x)
            .Take(3)
            .ToList();
        Console.WriteLine(string.Join(" ",result));
    }
}