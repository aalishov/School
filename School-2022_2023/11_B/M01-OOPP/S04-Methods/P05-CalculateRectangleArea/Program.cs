using System;

public class Program
{
    public static void Main()
    {
        
        double a =double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine(GetRectangleArea(a,b));
    }
    static double GetRectangleArea(double a ,double b ) 
    {
        double area = a * b;
        return area;
    }
}
