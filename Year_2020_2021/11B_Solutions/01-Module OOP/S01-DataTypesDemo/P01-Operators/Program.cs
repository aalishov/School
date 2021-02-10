using System;
using System.Globalization;
using System.Reflection.Emit;
using System.Text;

namespace P01_Operators
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            CultureInfo.CurrentCulture = new CultureInfo("es-ES", false);
            //Console.WriteLine(15+16);

            //Console.WriteLine(15/3);
            //Console.WriteLine(15/6);
            //Console.WriteLine(15%6);

            //Console.WriteLine(long.MaxValue);

            //Console.WriteLine(5.2+3.1);
            //Console.WriteLine($"{5.16 / 3.8999:c4}");

            //double doubleVariable = 15.7d;
            //double doubleVariable2 = double.Parse(Console.ReadLine());

            //decimal decimalVariable = 15.6m;
            //decimal decimalVariable2 = decimal.Parse(Console.ReadLine());


            //decimal num = decimalVariable + decimalVariable2;

            int a = 5;
            Console.WriteLine(++a);
            Console.WriteLine(a);

            a *= 5; //a=a*5;
            a += 10; //a=a+10;

            
        }
    }
}
