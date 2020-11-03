using System;

namespace P04_DemoExamTest
{
    class Program
    {
        static void Main()
        {

            var num = 15; // int - цяло число
            num *= 2; // 15*2 = 30

            Console.WriteLine(num++); // Печата  30, 30+1=31
            Console.WriteLine(++num); // 31+1=32, Печата 32

            var num1 = "15"; //string - низ, текст

            var num2 = 15.2d; //double - число с плаваща запетая

            var num3 = 45.36m; //decimle - число с плаваща запетая (с по-висока точност)

            var o = '0'; //char - симовл

            // || - или
            // && - и
            // ! - отрицание
            // != - различно
            // true - истина, вярно
            // false - лъжа, грешно
            // % - остатък от целочислено деление
            // / - цяла част от целочислено деление

            var isNum = 5 > 2; //bool - логическа променлива

            var div = 12 % 3; // 12 % 3 = 0 => int

            var div1 = 12 / 3; // 12 / 3 = 4 => int

            var isTrue = (12 % 3 == 0) || (6 % 2 != 1); // true

            var isTrue2 = (8 / 3 == 2) && !(12 == 8); // true

            var str1 = "one"; //string
            var str2 = "two"; //string

            var isTrue3 = !(12 + 3 != 15) || (str1 != str2); //true

            //if (isTrue3)
            //{
            //    Console.WriteLine(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}

        }
    }
}
