namespace P02_Permutation
{
    public class Program
    {
        private static List<int[]> vectors = new List<int[]>();
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = Enumerable.Range(1, n).ToArray();
            Console.WriteLine(string.Join(", ", nums));
            PermuteNoRepeat(nums);

            for (int i = 0; i < vectors.Count; i++)
            {
                Console.WriteLine(string.Join(" | ", vectors[i]));
            }

            int sum = vectors.Sum(x => x[0]);
            Console.WriteLine(sum);
        }
        public static void PermuteNoRepeat(int[] array, int index = 0)
        {
            int[] vector = new int[array.Length];
            bool[] used = new bool[array.Length];
            PermuteNoRepeatAlgo(array, vector, used, index);
        }

        private static void PermuteNoRepeatAlgo(int[] array, int[] vector, bool[] used, int index)
        {
            if (index >= vector.Length)
            {
                vectors.Add(vector.ToArray());
                //Console.WriteLine(string.Join(" ", vector));
              
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (!used[i])
                    {
                        used[i] = true;
                        vector[index] = array[i];
                        PermuteNoRepeatAlgo(array, vector, used, index + 1);
                        used[i] = false;
                    }
                }
            }
        }
    }
}