namespace P01_ArraysBasics
{
    public class Program
    {
        public static void Main()
        {
            int[] nums = { 1, 2, 3, 4,5 };
            int[] nums2 = new int[nums.Length * 2];

            Console.WriteLine($"L1={nums.Length}");
            Console.WriteLine($"L2={nums2.Length}");

            for (int i = 0; i < nums.Length; i++)
            {
                nums2[i] = nums[i];
            }

            nums = nums2;

            nums[0] = 10;
            nums2[0] = 20;
            nums[2] = 4;

            Console.WriteLine(string.Join(", ",nums));
            Console.WriteLine(string.Join(", ", nums2));
        }

        public static int[] ReadArrayFromSingleLine()
        {
            return Console.ReadLine()   //1 25 98 74 35
                .Split(" ")             //"1" "25" "98" "74" "35"
                .Select(x=>int.Parse(x))//1 25 98 74 35
                .ToArray();             //[1 25 98 74 35]
        }

        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Item[{i}] = {array[i]}");
            }
        }

        public static int[] CreateArray(int length)
        {
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = new Random().Next(-100, 100);
                //array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }
    }
}
