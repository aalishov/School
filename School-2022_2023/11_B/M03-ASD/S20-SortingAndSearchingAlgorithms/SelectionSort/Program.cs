using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // Масив
            var numbers = new int[] { 9, -9, 8, -8, 7, -7, 6, -6, 5, -5, 4, -4, 3, -3, 2, -2, 1, -1, 0 };

            var numbers2 = Enumerable.Range(0, 1000).ToArray();
            
           
           
            // Печат
            //Console.WriteLine(string.Join(" ", numbers));
            

            // Разбъркване
            //Sort.Shuffle(numbers);
            Sort.Shuffle(numbers2);
            Console.WriteLine(string.Join(", ", numbers2));
            // Печат

            // Сортиране по метода на пряката селекция = O(N ^ 2)
            Sort.Selection(numbers);
            Sort.Selection(numbers2);
            // Печат
            Console.WriteLine(string.Join(" ", numbers2));
        }
    }
}
