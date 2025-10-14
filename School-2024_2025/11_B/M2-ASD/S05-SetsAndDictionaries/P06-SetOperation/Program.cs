public class Program
{
    public static void Main(string[] args)
    {
        HashSet<int> set1 = new HashSet<int>() { 1, 2, 3, 4, 5 };
        HashSet<int> set2 = new HashSet<int>() { 4, 5, 6, 7 };

        HashSet<int> intersection = set1.Intersect(set2).ToHashSet();
        HashSet<int> union = set1.Union(set2).ToHashSet();

        Console.WriteLine($"Intersection: {string.Join(", ",intersection)}");
        Console.WriteLine($"Union: {string.Join(", ", union)}");

    }
}