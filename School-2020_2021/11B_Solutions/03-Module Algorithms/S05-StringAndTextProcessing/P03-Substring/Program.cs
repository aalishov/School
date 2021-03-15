using System;
using System.Text;
using System.Linq;
class Program
{
    static void Main()
    {
        string remove = Console.ReadLine().ToLower();
        string result = Console.ReadLine().ToLower();


        while (true)
        {
            int index = result.IndexOf(remove);
            if (index == -1)
            {
                break;
            }
            result = result.Replace(remove, "");
        }
        Console.WriteLine(result);
    }
}

