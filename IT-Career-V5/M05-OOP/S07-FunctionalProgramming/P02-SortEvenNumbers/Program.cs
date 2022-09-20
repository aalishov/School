using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Func<int, bool> isEven = x => x % 2 == 0;

        int[] nums = Console.ReadLine() //"4, 2, 3, 5, 6"
              .Split(", ") //string[] {"4", "2", "3", "5", "6"}
              .Select(x => int.Parse(x)) //int[] {4, 2, 3, 5, 6}
              .Where(x => isEven(x)) //int[] {4, 2, 6}
              .OrderBy(x => x) //int[] {2, 4, 6}
              .ToArray(); //List<int> {2, 4, 6};
        Console.WriteLine(String.Join(", ", nums));
    }
}

