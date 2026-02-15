public class Program
{
    public static void Main()
    {
        List<string> names = Console.ReadLine()!
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        for (int i = names.Count - 1; i >= 0; i--)
        {
            List<string> fullName = names[i]
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToList();

            Console.WriteLine(string.Join(" ", fullName));
        }
    }
}