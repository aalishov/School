using System;
public class Program
{
    public static void Main()
    {
        double height = double.Parse(Console.ReadLine()) * 100;
        double width = double.Parse(Console.ReadLine()) * 100 - 100;

        int rows = (int)Math.Floor(height / 120);
        int cols = (int)Math.Floor(width / 70);
        int seats = rows * cols - 3;
        Console.WriteLine(seats);
    }
}