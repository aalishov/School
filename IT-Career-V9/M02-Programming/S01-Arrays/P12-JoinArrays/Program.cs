public class Program
{
    public static void Main()
    {
        int[] first = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int[] second = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

        int[] result = new int[first.Length + second.Length];

        int fIndex = 0;
        int sIndex = 0;

        for (int i = 0; i < result.Length; i++)
        {
            if (first[fIndex] < second[sIndex])
            {
                result[i] = first[fIndex];
                if (fIndex < first.Length - 1) { fIndex++; }
                else { first[fIndex] = int.MaxValue; }
            }
            else
            {
                result[i] = second[sIndex];
                if (sIndex < second.Length - 1) { sIndex++; }
                else { second[sIndex] = int.MaxValue; }
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}

