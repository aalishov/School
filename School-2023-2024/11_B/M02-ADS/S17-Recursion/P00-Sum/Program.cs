public class Program
{
    public static void Main(string[] args)
    {
        Sum(new int[] { 2, 5, 7, 8 }, 0);
    }

    public static int Sum(int[] array, int index)
    {
        if (index == array.Length - 1)
        {
            return array[index];
        }

        return array[index] + Sum(array, index + 1);
    }
}


