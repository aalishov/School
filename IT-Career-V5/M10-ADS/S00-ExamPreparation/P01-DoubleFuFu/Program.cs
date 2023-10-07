namespace P01_DoubleFuFu
{
    internal class Program
    {
        static List<char> data = new List<char>();
        static List<string> text = new List<string>();

        static void Main(string[] args)
        {
            for (int i = 'a'; i <= 'z'; i++)
            {
                data.Add((char)i);
            }

            Variations(data.ToArray(), 2);
            
            text.RemoveAll(x => x[0] == x[1]);
            string input = Console.ReadLine();

            for (int i = 0; i < text.Count; i++)
            {
                if (text[i] == input)
                {
                    Console.WriteLine(i+1);
                    break;
                }
            }
        }

        // Variation = Вариации = O(N!/(N-K)!)
        public static void Variations<T>(T[] array, int k)
        {
            var vector = new int[k];
            while (true)
            {
                VariationPrint(array, vector);
                var index = k - 1;
                while (index >= 0 && vector[index] == array.Length - 1)
                {
                    index--;
                }
                if (index < 0) break;
                vector[index]++;
                for (int i = index + 1; i < vector.Length; i++)
                {
                    vector[i] = 0;
                }
            }
        }

        private static void VariationPrint<T>(T[] array, int[] vector)
        {
            string result = "";
            for (int i = 0; i < vector.Length; i++)
            {
                //Console.Write("{0} ", array[vector[i]]);
                result += array[vector[i]];

            }
            text.Add(result);
            result = "";
            //Console.WriteLine();
        }
    }


}