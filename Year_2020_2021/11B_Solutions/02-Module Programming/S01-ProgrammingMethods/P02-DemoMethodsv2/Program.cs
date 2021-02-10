using P01_IntroMethods;
using System;
using System.Security;
using System.Security.Cryptography;
using System.Text;

namespace P02_DemoMethodsv2
{
    public class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine($"SumRandom result: {SumRandom(3)}");
            //Console.WriteLine($"SumRandom result: {SumRandom()}");
            //Console.WriteLine($"ProductSumRandom: {ProductSumRandom(7, 11)}");
            Console.WriteLine(HashPass("12a3asd4"));
            Console.WriteLine(HashPass("1"));
        }

        //Метод-връща цяло число, сумира число, което му подаваме със случайно генерирано число в интервала 1...1000
        static int SumRandom(int num = 0)
        {
            Random random = new Random();
            int randomNum = random.Next(1, 1000);
            int result = num + randomNum;
            return result;
        }
        static int ProductSumRandom(int fNum, int sNum)
        {
            int first = SumRandom(fNum);
            int second = SumRandom(sNum);
            int result = first * second;
            return result;
        }

        static string HashPass(string userPass)
        {
            SHA512 shaM = new SHA512Managed();
            var data = Encoding.UTF8.GetBytes(userPass);
            var hash = shaM.ComputeHash(data);
            string result = Encoding.UTF8.GetString(hash);
            return result;
        }
    }
}
