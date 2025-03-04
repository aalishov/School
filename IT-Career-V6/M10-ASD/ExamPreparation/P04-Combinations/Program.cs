public class Program
{
    static void Main(string[] args)
    {
        int k=int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int[] nums = Enumerable.Range(1,n).ToArray();

        Variations(nums, k);
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
        for (int i = 0; i < vector.Length-1; i++)
        {
            Console.Write("{0}.", array[vector[i]]);
        }
        Console.WriteLine("{0}", array[vector[vector.Length-1]]);
    }
}

