public class Program
{
    public static void Main()
    {
        Console.Write("Enter numbers: ");
        int[] nums = Console.ReadLine()                  // "5 10 9 7 8"
            .Split(" ")                                 // ["5" "10" "9" "7" "8"]
            .Select(x => int.Parse(x))  //(int.Parse)   // [5 10 9 7 8]
            .ToArray();

        Console.WriteLine($"Length: {nums.Length}");
        Console.WriteLine(string.Join(", ", nums));

    }
}

