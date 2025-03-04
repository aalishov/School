namespace P02_ArrayStatistics
{
    public class Program
    {
        public static void Main()
        {
            int[] arr = CreateArray(100);

            Console.WriteLine(string.Join(" ", arr));

            Console.WriteLine($"Sum = {SumArray(arr)}");
            Console.WriteLine($"Max = {GetMax(arr)} ");
            //Console.WriteLine($"Min = {GetMin(arr)} ");

            Console.WriteLine($"Average = {GetAverage(arr)}");
            Console.WriteLine($"Positive numbers count = {CountPositive(arr)}");
            //Console.WriteLine($"Negative numbers count = {CountNegative(arr)}");

            arr[50] = 100;
            Console.WriteLine($"Get element index: {GetElementIndex(arr,100)}");


        }
        public static bool IsContain(int[] arr, int element)
        {
            bool isContain = false;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == element)
                {
                    isContain = true;
                    break;
                }
            }
            return isContain;
        }

        public static int GetElementIndex(int[] arr, int element)
        {
            int index = -1;

            for (int i = 0; i < arr.Length; i++) 
            { 
                if (arr[i] == element)
                {
                    index = i;
                }
            }   

            return index;
        }

        public static int CountPositive( int[] arr)
        {
            int count= 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0) { count++; }
            }

                return count;
        }

        public static double GetAverage(int[] arr)
        {
            int sum = SumArray(arr);
            return sum / (double)arr.Length;
        }

        public static int GetMax(int[] arr)
        {
            int max = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        public static int SumArray(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }

        public static int[] CreateArray(int length, int min = -500, int max = 500)
        {
            int[] array = new int[length];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(min, max);
            }

            return array;
        }
    }
}