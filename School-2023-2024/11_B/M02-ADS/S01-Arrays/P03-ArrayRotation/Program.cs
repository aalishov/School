public class Program
{
    public static void Main()
    {
        int[] arr = Console.ReadLine()
            .Split(" ")
            .Select(int.Parse)
            .ToArray();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int[] newArr = new int[arr.Length];

            newArr[newArr.Length - 1] = arr[0];

            Array.Copy(arr, 1, newArr, 0, arr.Length - 1);

            arr = newArr;
        }


        Console.WriteLine(string.Join(" ", arr));
    }
}
