﻿using System;

namespace LinearSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Data Structures
            var numbers = new int[] { -5, 5, -4, 4, -3, 3, -2, 2, -1, 1 };
            var alphas = new char[] { 'm', 'a', 'g', 'g', 'i', 'c', 'h', 'a', 'p', 'p', 'e', 'n', 'd', 's', 'h', 'e', 'r', 'e' };

            // Search for Number
            Console.WriteLine("Linear Search for Number [-3] ...");
            if (Search.Linear(numbers, -3) == -1)
            {
                Console.WriteLine("Not Found");
            }
            else
            {
                Console.WriteLine("Found");
            }

            // Search for Char
            Console.WriteLine("Linear Search for Char ['z'] ...");
            if (Search.Linear(alphas, 'z') == -1)
            {
                Console.WriteLine("Not Found");
            }
            else
            {
                Console.WriteLine("Found");
            }

        }
    }
}
