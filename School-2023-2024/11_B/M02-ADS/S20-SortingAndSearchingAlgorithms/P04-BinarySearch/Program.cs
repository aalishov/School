namespace P04_BinarySearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = { 25, 50, -14, 8, 0, 15, 4, 32, -1, 15 };
            Array.Sort(nums);

            int result = BinarySearch.Binary(nums, 15);

            Console.WriteLine(result);
        }


    }

    public class BinarySearch
    {
        // BinarySearch = O(log(n))
        public static int Binary<T>(T[] elements, T key) where T : IComparable
        {
            int start = 0, end = elements.Length - 1;
            while (end >= start)
            {
                // middle
                int mid = (start + end) / 2;

                // compare
                if (elements[mid].CompareTo(key) > 0)
                {
                    // (mid > key) => key must be on left 
                    end = mid - 1;
                }
                else if (elements[mid].CompareTo(key) < 0)
                {
                    // (mid < key) => key must be on right 
                    start = mid + 1;
                }
                else
                {
                    // (mid == key) => found
                    return mid;
                }
            }
            // not found
            return -1;
        }
    }

}
