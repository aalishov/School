using System;

namespace P01_IntroMethods
{
    public class StartUp
    {
        static void Main()
        {
            //bool isInt = IsIntNumber("0");
            //Console.WriteLine(isInt);
            //StringLineWithStars();
            PrintLineWithStars();
            PrintLineWithStars('5');
            PrintLineWithStars('!', 5);
            PrintLineWithStars(50);
            PrintLineWithStars('@', 47);
            PrintLineWithStars(10);
            PrintLineWithStars(13);
            PrintLineWithStars('?', 5);
            PrintLineWithStars(20);
        }

        static bool IsIntNumber(string text)
        {
            int num = default;
            return int.TryParse(text, out num);
        }

        static void PrintLineWithStars()
        {
            Console.WriteLine(new string('*', 10));
        }
        static void PrintLineWithStars(char c)
        {
            Console.WriteLine(new string(c, 10));
        }
        static void PrintLineWithStars(int num)
        {
            Console.WriteLine("=>" + new string('*', num));
        }
        public static string PrintLineWithStars(char c, int num)
        {
            Random r = new Random();
            int n = r.Next(1, 10);
            return new string(c, num + n) + "=>";
        }


    }
}
