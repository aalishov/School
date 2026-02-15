public class Program
{
    public static void Main()
    {
        List<int> nums =Console.ReadLine()
            .Split(" ")
            .Select(int.Parse)
            .OrderBy(x=>x)
            .ToList();

        Console.WriteLine(string.Join(" <= ", nums));
    }
}

