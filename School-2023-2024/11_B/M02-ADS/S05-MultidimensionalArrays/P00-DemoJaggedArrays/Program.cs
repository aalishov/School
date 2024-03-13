public class Program
{
    public static void Main()
    {
        int[][] arr = new int[5][];

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            //arr[i]= new int[new Random().Next(1,6)];
            arr[i]=Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
        }

        Console.WriteLine();
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            Console.WriteLine(string.Join(", ", arr[i]));
        }
    }
}

