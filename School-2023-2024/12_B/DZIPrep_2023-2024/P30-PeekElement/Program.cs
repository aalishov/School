public class Program
{
    static void Main()
    {
        //1 1 1 1 1 1
        List<int> nums = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
        try
        {
            List<int> peekElements = new List<int>();
            if (nums[0] > nums[1])
            {
                peekElements.Add(nums[0]);
            }
            if (nums[nums.Count - 1] > nums[nums.Count - 2])
            {
                peekElements.Add(nums[nums.Count - 1]);
            }
            for (int i = 1; i < nums.Count - 1; i++)
            {
                if (nums[i] > nums[i - 1] && nums[i] > nums[i + 1])
                {
                    peekElements.Add(nums[i]);
                }
            }
            Console.WriteLine(peekElements.Max());
        }
        catch (Exception)
        {
            if (nums.Count>0)
            {
                Console.WriteLine(nums[0]);
            }
            else
            {
                Console.WriteLine("Collection does not have any elements");
            }
           
        }
    }
}
