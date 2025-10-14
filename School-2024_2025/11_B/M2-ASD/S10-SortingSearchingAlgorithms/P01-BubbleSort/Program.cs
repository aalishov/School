namespace BubbleSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = {20,-5, 5, 12, 34, 23 };
           // BubbleSort.Sort.Bubble(nums);
            

            //Array.Sort(nums);
            nums=nums.OrderBy(x => x).ToArray();
            Console.WriteLine(string.Join(", ", nums));
        }
    }
}
