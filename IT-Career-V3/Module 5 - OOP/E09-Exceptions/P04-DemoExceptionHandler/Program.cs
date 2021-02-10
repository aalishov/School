using System;

namespace P04_DemoExceptionHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter command: ");
                try
                {
                    string cmd = Console.ReadLine();
                    if (cmd.Length < 3)
                    {
                        throw new ArgumentException();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid command!");
                }

            }
        }
    }
}
