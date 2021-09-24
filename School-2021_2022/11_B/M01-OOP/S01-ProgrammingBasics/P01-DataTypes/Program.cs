namespace P01_DataTypes
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int number = 600;
            double number1 = 15.2d;
            decimal number2 = 15.2m;
            float number3 = 12.3f;
            string s1 = $"{{value}}";
            //Console.WriteLine(s1);
            //интерполиран стринг
            string s2 = $"{number} + {number2} = {number+number2}";
            //конкатенация
            string s3 = s1 + " " + s2;

            char c1 = 'c';
            char c2 = '!';
            char c3 = '1';

            bool isTrue = true;
            bool isTrue1 = 5 > 2; //true
            bool isTrue2 = 5 > 2 && 9<8; //false
            bool isTrue3 = 5 > 2 || 9 < 8; //true
            bool isTrue4 = (5 * 3) > (2 + 4) && 3 != 2;//true
            bool isTrue5 = (5 * 3) > (2 + 4) && 3 != 2 || 2 < 8;//true
            bool isTrue6 = !((5 * 3) > (2 + 4) && 3 != 2 || 2 < 8);//false
            bool isTrue7 = !(5 == 3) && (2 != 4) || 3 != 2 || 12 < 8;
            bool isTrue8 = (!(5 == 3) && (2 != 4)) || (3 != 2 && 12 < 8);
            bool isTrue9 = (!(5 == 3) && (2 != 4))  && (3 != 2 && 12 < 8);

            Console.WriteLine(isTrue9);
        }
    }
}
