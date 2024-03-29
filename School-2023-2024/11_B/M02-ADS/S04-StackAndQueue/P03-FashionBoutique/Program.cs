public class Program
{
    static void Main()
    {
        int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        Stack<int> box = new Stack<int>(nums);
        int capacity = int.Parse(Console.ReadLine());
        int s = 0;
        int racks = 1;
        while (box.Count > 0)
        {
            int cloth = box.Pop();
            if (s+cloth > capacity)
            {
                s = cloth;
                racks++;
            }
            else
            {
                s += cloth;
            }
        }
        Console.WriteLine(racks);
    }
}

