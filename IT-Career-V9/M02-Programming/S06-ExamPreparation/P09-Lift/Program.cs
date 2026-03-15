public class Program
{
    public static void Main()
    {
        int peopleCount = int.Parse(Console.ReadLine() ?? "0");

        int[] lift = Console.ReadLine()!
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        for (int i = 0; i < lift.Length; i++)
        {
            int freePlaces = 4 - lift[i];
            if (peopleCount > freePlaces)
            {
                lift[i] += freePlaces;
                peopleCount -= freePlaces;
            }
            else
            {
                lift[i] += peopleCount;
                peopleCount = 0;
                break;
            }
        }
        if (peopleCount > 0) { Console.WriteLine($"There isn't enough space! {peopleCount} people in a queue!"); }
        else { Console.WriteLine("The lift has empty spots!"); }
        Console.WriteLine(string.Join(" ", lift));
    }
}