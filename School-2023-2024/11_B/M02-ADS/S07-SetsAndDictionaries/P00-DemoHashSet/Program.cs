public class Program
{
    static void Main(string[] args)
    {
        HashSet<int> numsSet = new HashSet<int>();
        SortedSet<int> nums = new SortedSet<int>();
        nums.Add(1);
        nums.Add(20);
        nums.Add(20);
        nums.Add(4);
        nums.Add(5);

        Console.WriteLine(string.Join(", ",nums));
    }
}

