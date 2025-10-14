public class Program
{
    public static void Main(string[] args)
    {
        int[] setsLength = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        HashSet<int> set1 = new HashSet<int>();
        HashSet<int> set2 = new HashSet<int>();

        for (int i = 0; i < setsLength[0]; i++)
        {
            set1.Add(int.Parse(Console.ReadLine()));
        }
        for (int i = 0; i < setsLength[1]; i++)
        {
            set2.Add(int.Parse(Console.ReadLine()));
        }

        foreach (var num in set1)
        {
            if (set2.Contains(num))
            {
                Console.Write($"{num} ");
            }
        }
        Console.WriteLine();
    }
}