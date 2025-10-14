public class Program
{
    public static void Main()
    {
        HashSet<int> first = new HashSet<int>();
        SortedSet<int> second = new SortedSet<int>();

        first.Add(1);
        first.Remove(1);
        bool isContain = first.Contains(1);
        first.Add(5);
        first.Add(9);
        first.Add(2);
        first.Add(6);

        second.Add(1);
        second.Remove(1);
        bool isContain2 = second.Contains(1);
        second.Add(5);
        second.Add(9);
        second.Add(2);
        second.Add(6);

        Console.WriteLine(string.Join(", ",first));
        Console.WriteLine(string.Join(", ", second));
    }
}