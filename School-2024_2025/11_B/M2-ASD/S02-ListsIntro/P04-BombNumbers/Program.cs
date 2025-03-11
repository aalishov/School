public class Program
{
    public static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split(" ")
            .Select(int.Parse)
            .ToList();

        int[] bombInfo = Console.ReadLine()
            .Split(" ")
            .Select(int.Parse)
            .ToArray();

        int bomb = bombInfo[0];
        int power = bombInfo[1];

        int bombIndex = numbers.FindIndex(x => x == bomb);
        int startIndex = bombIndex - power;
        int removeCount = power * 2 + 1;
        if (startIndex < 0)
        {
            removeCount+=startIndex;
            startIndex = 0;
        }
        else if (startIndex+removeCount>numbers.Count)
        {
            removeCount =numbers.Count-startIndex;
        }
        
        numbers.RemoveRange(startIndex, removeCount);

        Console.WriteLine(numbers.Sum());

    }
}

