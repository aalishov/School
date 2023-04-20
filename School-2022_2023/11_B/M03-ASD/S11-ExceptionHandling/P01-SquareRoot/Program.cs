using System;


public class Program
{
    static void Main()
    {
		try
		{
			double number = double.Parse(Console.ReadLine());
			if (number < 0)
			{
				throw new ArgumentException("Invalid number.");
			}
			double result = Math.Sqrt(number);
			Console.WriteLine(result);

		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);

			
		}
		finally
		{
			Console.WriteLine("Good bye");
		}
    }
}

