public class Program
{
    public static void Main()
    {
        Variant1();
    }

    private static void Variant2()
    {
        List<string> names = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        for (int i = names.Count - 1; i >= 1; i--)
        {
            Console.Write(names[i] + "; ");
        }
        Console.WriteLine(names[0]);
    }

    private static void Variant1()
    {
        List<string> names = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Reverse()
            .ToList();

        Console.WriteLine(string.Join("; ", names));
    }
}

