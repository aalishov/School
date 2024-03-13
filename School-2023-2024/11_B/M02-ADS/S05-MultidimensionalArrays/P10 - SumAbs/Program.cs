namespace P10___SumAbs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[,] ints = CreateRandomArray();
            PrintArray(ints);
            int s = 0;
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    s += ints[i, j];
                }
            }
            double average = s/ (double)ints.Length;
            List<int> nums = new List<int>();
            for (int i = 0;i < ints.GetLength(0); i++)
            {
                for(int j = 0;j < ints.GetLength(1); j++)
                {
                    if (ints[i,j] > average)
                    {
                        nums.Add(ints[i,j]);
                    }
                }
            }
            Console.WriteLine(string.Join(",", nums));
            Console.WriteLine(average);

        }

        private static void SumAbs(int[,] ints)
        {
            int s = 0;
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    s += Math.Abs(ints[i, j]);
                }
            }
            Console.WriteLine(s);
        }

        public static void PrintArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j],4}");
                }
                Console.WriteLine();
            }
        }

        public static int[,] CreateRandomArray()
        {
            int m = new Random().Next(2,8);
            int n = new Random().Next(2,8);

            int[,] arr = new int[m, n];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = new Random().Next(-50, 50);
                }
            }

            return arr;
        }
    }
}
