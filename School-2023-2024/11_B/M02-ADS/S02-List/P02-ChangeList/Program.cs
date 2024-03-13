public class Program
{
    public static void Main()
    {
        List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        string[] command = null;

        while ((command = Console.ReadLine().Split(" "))[0] != "end")
        {
            if (command[0] == "delete")
            {
                int num = int.Parse(command[1]);
                while (nums.Contains(num)) { nums.Remove(num); }
            }
            else if (command[0] == "insert")
            {
                nums.Insert(int.Parse(command[2]), int.Parse(command[1]));
            }
        }
        Console.WriteLine(string.Join(" ", nums));
    }
}

