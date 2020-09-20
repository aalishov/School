namespace _01_DemoFormatException
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections.Generic;

    class Program
    {

        static void Main(string[] args)
        {
            Garage garage = new Garage("N1");
            try
            {
                Console.WriteLine(DemoRecursion(3,0));
                short num = 12700;
                num*=10;
                Console.WriteLine(num);
                garage.Cars.Add(12);
                CreateException();
            }
            catch (Exception fe)
            {
                Console.WriteLine($"{fe.Message}");
            }

        }

        static void CreateException()
        {
            int a = 10;
            int b = 0;
            Console.WriteLine(a / b); ;
        }

        static int DemoRecursion(int num, int sum)
        {
            if (num==0)
            {
                return 1;
            }
            
            return sum+DemoRecursion(--num,sum);
        }
    }

}
