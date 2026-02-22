public class Program
{
    public static void Main()
    {
        int[,] twoDimensionalArray = new int[4, 6];
        int[,,] threeDimensionalArray = new int[2, 3, 5];

        Console.WriteLine($"2Dimensional array length: {twoDimensionalArray.Length}");
        Console.WriteLine($"2Dimensional array rows count: {twoDimensionalArray.GetLength(0)}");
        Console.WriteLine($"2Dimensional array cols count: {twoDimensionalArray.GetLength(1)}");
        Console.WriteLine($"3Dimensional array length: {threeDimensionalArray.Length}");
        Console.WriteLine($"3Dimensional array x count: {threeDimensionalArray.GetLength(0)}");
        Console.WriteLine($"3Dimensional array y count: {threeDimensionalArray.GetLength(1)}");
        Console.WriteLine($"3Dimensional array z count: {threeDimensionalArray.GetLength(2)}");
    }
}

