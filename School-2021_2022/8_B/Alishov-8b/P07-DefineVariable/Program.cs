using System;

namespace P07_DefineVariable
{
    class Program
    {
        static void Main()
        {
            string townName = "Velingrad";
            var name = "John";
            Console.WriteLine(name.Length);
            char letter = '@';
            var firstLetter = townName[0];
            char lastLetter =townName[townName.Length-1];
            
            Console.WriteLine(letter);
            Console.WriteLine(firstLetter);
            Console.WriteLine(lastLetter);
            Console.WriteLine(townName);
            Console.WriteLine(townName.Length);
        }
    }
}
