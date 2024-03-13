
public class Program
{
    public static void Main()
    {
        List<int> nums = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
        //string[] command = Console.ReadLine().Split(" ");
        while (true)
        {
            string[] command = Console.ReadLine().Split(" ");

            if (command[0] == "Add")
            {
                int number = int.Parse(command[1]);
                nums.Add(number);

            }
            else if (command[0] == "Insert")
            {
                int number = int.Parse(command[1]);
                int index = int.Parse(command[2]);
                nums.Insert(index, number);

            }
            else if (command[0] == "Remove")
            {
                int index = int.Parse(command[1]);
                nums.RemoveAt(index);
            }
            else if (command[0] == "right")
            {
                int count = int.Parse(command[1]);
                for (int i = 0; i < count; i++)
                {
                    int lastNumber = nums[nums.Count - 1];
                    nums.RemoveAt(nums.Count - 1);
                    nums.Insert(0, lastNumber);
                }
            }
            else if (command[0] == "left")
            {
                int count = int.Parse(command[1]);
                for (int i = 0; i < count; i++)
                {
                    int firstNumber = nums[0];
                    nums.RemoveAt(0);
                    nums.Add(firstNumber);
                }
            }
            else if (command[0] == "end")
            {
                break;
            }
            Console.WriteLine(string.Join(" ", nums));
        }
        Console.WriteLine(string.Join(" ", nums));
    }
}
