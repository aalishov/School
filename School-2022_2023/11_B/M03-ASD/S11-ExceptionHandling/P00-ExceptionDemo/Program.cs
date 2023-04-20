using System;

public class Program
{
    public static void Main()
    {
        try
        {
            Console.Write("Enter num a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter num b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double result = MathOperation.Divide(a, b);
            Console.WriteLine($"{a} / {b} = {result:f2}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"{nameof(FormatException)} error...");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"{nameof(DivideByZeroException)} error...");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error...");
        }
        finally
        {
            Console.WriteLine("End...");
        }
    }
}

public static class MathOperation
{
    public static double Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException();
        }
        return a / b;
    }
}

