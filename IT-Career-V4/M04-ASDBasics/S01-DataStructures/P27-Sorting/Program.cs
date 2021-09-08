using System;

namespace P27_Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 7, 3, 4, 5, 8 };
            Bubble(nums);
            Console.WriteLine(string.Join(" ",nums));
        }

        public static void Bubble(int[] elements) 
        {
            for (int i = 0; i < elements.Length; i++)
            {
                for (int j = 0; j < elements.Length; j++)
                {
                    if (IsLess(elements[i], elements[j]))
                    {
                        Swap(elements, i, j);
                    }
                }
            }
        }

        public static void Swap(int[] elements, int first, int second)
        {
            int temp = elements[first];
            elements[first] = elements[second];
            elements[second] = temp;
        }

        public static bool IsLess(IComparable first, IComparable second)
        {
            return first.CompareTo(second) < 0;
        }
    }
}
