public class Program
{
    public static void Main()
    {
        List<int> nums = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

        while (true)
        {
            string[] args = Console.ReadLine().Split(" ").ToArray();
            string cmd = args[0];

            switch (cmd)
            {
                case nameof(Add):
                    Add(nums, args);
                    break;
                case nameof(AddMany):
                    AddMany(nums, args);
                    break;
                case nameof(Contains):
                    Contains(nums, args);
                    break;
                case nameof(Remove):
                    Remove(nums, args);
                    break;
                case nameof(Shift):
                    Shift(nums, args);
                    break;
                case nameof(SumPairs):
                    nums = SumPairs(nums);
                    break;
                case nameof(Print):
                    Print(nums);
                    break;
                default:
                    Console.WriteLine("Invalid command!");
                    break;
            }
        }
    }

    private static void Print(List<int> nums)
    {
        Console.WriteLine(string.Join(", ", nums));
    }

    private static List<int> SumPairs(List<int> nums)
    {
        List<int> summedPairs = new List<int>();
        for (int i = 0; i < nums.Count; i += 2)
        {
            int firstNum = nums[i];
            int secondNum = (i + 1 < nums.Count) ? nums[i + 1] : 0;
            summedPairs.Add(firstNum + secondNum);
        }
        nums = summedPairs;
        return nums;
    }

    private static void Shift(List<int> nums, string[] args)
    {
        int count = int.Parse(args[1]);
        for (int i = 0; i < count; i++)
        {
            int firstElement = nums[0];
            nums.RemoveAt(0);
            nums.Add(firstElement);
        }
    }

    private static void Remove(List<int> nums, string[] args)
    {
        int index = int.Parse(args[1]);
        nums.RemoveAt(index);
    }

    private static void Contains(List<int> nums, string[] args)
    {
        int element = int.Parse(args[1]);
        int index = nums.FindIndex(x => x == element);
        Console.WriteLine(index);
    }

    private static void AddMany(List<int> nums, string[] args)
    {
        int index = int.Parse(args[1]);
        List<int> newItems = args.Skip(2).Select(int.Parse).ToList();
        nums.InsertRange(index, newItems);
    }

    private static void Add(List<int> nums, string[] args)
    {
        int index = int.Parse(args[1]);
        int element = int.Parse(args[2]);
        nums.Insert(index, element);
    }
}

