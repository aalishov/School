namespace P00_SandBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            SumHalves(arr);
            
        }
        //public static int FindSecondLargest(int[] numbers)
        //{
          

        //}
        static void SumHalves(int[] numbers)
        {
            int sum1 = 0;
            int sum2 = 0;   
            for (int i = 0; i < numbers.Length / 2; i++)
            {
                sum1 += numbers[i];
            }
            for (int i = numbers.Length - 1; i >= numbers.Length / 2 + 1; i--)
            {
                sum2 += numbers[i];
            }
            Console.WriteLine($"Първата половина: {sum1}");
            Console.WriteLine($"Втората половина: {sum2}");
        }
        public static int[] DoubleElements(int[] numbers)
        {
            int[] result = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                result[i] = 2*numbers[i];
            }
            return result;
        }
        static bool ContainsNumber(int[] numbers, int target) 
        {
            for (int i = 0; i < numbers.Length; i++) 
            {
                if (numbers[i] == target)
                {
                    return true;
                }
            }
            return false;
        }
        static int CountEvenNumbers(int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
        static int FindRange(int[] arr)
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return max - min;
        }


        static bool Same(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != numbers[1])
                {
                    return false;
                }
            }
            return true;
        }
        static int CountInRange(int[] numbers, int min, int max)
        {
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= min && numbers[i] <= max)
                {
                    count++;
                }
            }
            return count;
        }
        static int CountNegativeNumbers(int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    count++;
                }

            }
            return count;

        }
        static bool ContainsZero(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 0)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
