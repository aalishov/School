using System;

namespace P02_FoodVauchers
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            //Сума на ваучерите
            int money = days * 20;
            //Брой ваучери от 100 лева
            int vauchers100 = money / 100;
            //Сума на ваучерите по 20 лева
            int money20lv = money % 100;
            //Брой ваучери от 20 лева
            int vauchers20 = money20lv / 20;

            //Общ брой ваучери
            Console.WriteLine(vauchers100+vauchers20);
        }
    }
}
