namespace BinarySearch
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = { -5, 12, 24, -9,19, 47, 0, 9, 6, -9, 15, 21 };
            Array.Sort(nums);
            Console.WriteLine(string.Join(", ",nums));
            int result = Search.Binary(nums, 20);
            Console.WriteLine(result);
        }
    }


    public class Search
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
