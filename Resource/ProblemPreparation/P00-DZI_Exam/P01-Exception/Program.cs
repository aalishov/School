using System;

public class Program
{
    public static void Main(string[] args)
    {
        string result = "";
        int[] numbers = { 4, 5, 6, 1, 8, 56, 55, 3, 2, 21 };
        Console.WriteLine("Въведете две цели числа:");
        try
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int s = numbers[a] + numbers[b];
            Console.WriteLine(s);
        }
        catch (FormatException)
        {
            result = "Вие не въведохте число";
            Console.WriteLine(result);
        }
        catch (IndexOutOfRangeException)
        {
            result = "Вие излязохте извън границите на масива."; 
        Console.WriteLine(result);
        }
    }
}
