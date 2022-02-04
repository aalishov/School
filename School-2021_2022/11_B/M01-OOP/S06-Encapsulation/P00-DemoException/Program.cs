using System;

namespace P00_DemoException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int age = int.Parse(Console.ReadLine());

                if (age <= 0)
                {
                    throw new ArgumentException("Invalid age!");
                }

                Console.WriteLine($"Your age: {age}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Argument exception -> " + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Format exception -> " + ex.Message);
            }
        }
    }
}
