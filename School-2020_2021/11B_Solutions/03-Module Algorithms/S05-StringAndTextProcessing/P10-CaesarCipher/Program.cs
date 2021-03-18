using System;

class Program
{
    static void Main()
    {
        char[] arr = Console.ReadLine().ToCharArray();

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = (char)(arr[i] + 3);
        }
        Console.WriteLine(string.Join("",arr));
    }
}

