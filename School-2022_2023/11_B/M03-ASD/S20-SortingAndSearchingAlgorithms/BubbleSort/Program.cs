using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // Масив
            var numbers = new int[] { 9,  2, -2, 1, -1, 0 };
          

            //// Печат
            //Console.WriteLine(string.Join(" ", numbers));

            //// Разбъркване
            //Sort.Shuffle(numbers);

            //// Печат
            //Console.WriteLine(string.Join(" ", numbers));

            //// Сортиране по метода мехурчето = O(N^2)
            Sort.Bubble2(numbers);

            //// Печат
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
