namespace P05_ArrayRotations
{
    public class Program
    {
        public static void Main()
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int rotateCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < rotateCount; i++)
            {
                arr = Rotate(arr);
            }
            Console.WriteLine(string.Join(" ", arr));
        }

        public static int[] Rotate(int[] array)
        {
            int[] result = new int[array.Length];
            result[result.Length - 1] = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                result[i - 1] = array[i];
            }

            return result;
        }
    }
}
