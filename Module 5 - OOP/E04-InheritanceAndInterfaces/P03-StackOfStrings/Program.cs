using System;

namespace P03_StackOfStrings
{
   public class Program
    {
       public static void Main()
        {
            StackOfStrings<string> s = new StackOfStrings<string>();
            s.Push("sadasd");
            Console.WriteLine(s.IsEmpty());
        }
    }
}
