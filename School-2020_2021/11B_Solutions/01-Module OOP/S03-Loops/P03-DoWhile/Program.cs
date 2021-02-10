using System;

namespace P03_DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            string cmd = "end";

            do
            {
                Console.WriteLine(cmd);
                Console.Write("Enter  cmd: ");
                cmd = Console.ReadLine();

            } while (cmd!="end");
        }
    }
}
