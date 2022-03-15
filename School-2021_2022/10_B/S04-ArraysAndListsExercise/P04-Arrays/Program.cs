using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[ArrLength()];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Enter element value: ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        MaxElement(arr);
        Console.WriteLine(string.Join(", ", arr));
    }

    public static void MaxElement(int[] arr)
    {
        //5 12 8 12 6
        int max = int.MinValue;
        int index = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (max < arr[i])
            {
                max = arr[i];
                index = i;
            }
        }
        Console.WriteLine($"Max element: {max}");
        Console.WriteLine($"Max element index: {index}");
    }

    static int ArrLength()
    {
        while (true)
        {
            Console.Write("Enter array length: ");
            int length = int.Parse(Console.ReadLine());
            if (length >= 2 && length <= 60)
            {
                return length;
            }
            Console.WriteLine("Error..");
        }
    }
}

