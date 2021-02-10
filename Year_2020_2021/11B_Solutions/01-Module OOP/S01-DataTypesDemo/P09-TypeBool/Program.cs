using System;

namespace P09_TypeBool
{
    class Program
    {
        static void Main()
        {
            //bool isTrue = 5<=4;
            //Console.WriteLine(isTrue);

            bool isTrue1 = 4 > -4;
            bool isTrue2 = 5 == 5;

            bool isTrue = 5 != 4 || (isTrue1 && isTrue2) || 19 <= 18;

            // 5 + 3 = 3 + 5
            // isTrue1 && isTrue2 = isTrue2 && isTrue1
        }
    }
}
