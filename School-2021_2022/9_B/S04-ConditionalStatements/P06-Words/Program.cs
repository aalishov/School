using System;

namespace P06_Words
{
    class Program
    {
        static void Main()
        {
            string firstWord = Console.ReadLine().ToLower();
            string secondWord = Console.ReadLine().ToLower();

            //Console.WriteLine($"{firstWord} = {secondWord} ???");
            if (firstWord==secondWord)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
