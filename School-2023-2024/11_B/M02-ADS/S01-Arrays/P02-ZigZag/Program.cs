public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] first = new int[n];
        int[] second = new int[n];

        int index = 0;
        for (int i = 0; i < n/2; i++)
        {
            int[] arr1=Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            first[index] = arr1[0];
            second[index] = arr1[1];
            index++;
            first[index] = arr2[1];
            second[index] = arr2[0];
            index++;
        }
        Console.WriteLine(string.Join(" ",first));
        Console.WriteLine(string.Join(" ", second));
    }
}
