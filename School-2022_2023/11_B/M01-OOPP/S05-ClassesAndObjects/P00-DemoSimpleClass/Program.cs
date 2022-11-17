using System;
using System.Threading;

namespace P00_DemoSimpleClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Student s1 = new Student();
            //s1.Name = "John";
            //s1.Age = 15;
            //s1.Grow();
            //Console.WriteLine($"{s1.Name} => {s1.Age}");

            //Student s2 = new Student("Alex", 6);

            //Console.WriteLine(s1);

            //Box box = new Box();

            Pen blackPen = new Pen("Brand 1", "Black");
            Pen redPen = new Pen("Brand 1", "Red");
            Pen greenPen = new Pen("Brand 1", "Green");

            greenPen.Write("asdasdasdasd");
            redPen.Write("asasdasdasdadas");
            blackPen.Write("123123123123123");
        }

        public void Print()
        {

        }
    }

    public class Pen
    {
        public Pen(string name, string color)
        {
            Name = name;
            Color = color;
        }
        public string Name { get; set; }
        public string Color { get; set; }

        public void Write(string text)
        {
            switch (Color)
            {
                case "Red":
                    for (int i = 0; i < 100; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Beep();
                        if (i > 10 && i < 30)
                        {
                            Thread.Sleep(10 * i);
                        }
                        else
                        {
                            Thread.Sleep(20);
                        }

                        Console.WriteLine(text);
                    }
                    break;
                case "Green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
            }
            Console.WriteLine(text);
        }
    }
    public class Student
    {
        //Поле (Field) - пази данни
        private int age;

        //Конструктор - по подразбиране
        public Student()
        {

        }
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }

        //Свойство (Propertie) - дава достъп до полето
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Invalid age!");
                }
                age = value;
            }
        }
        //Метод - поведение
        public void Grow()
        {
            Age++;
        }

        public int GetAgeAfter10Years()
        {
            return age + 10;
        }

        public override string ToString()
        {
            return $"{Name} => {Age}";
        }
    }
    public class Box
    {

    }
    public class Car
    {

    }
    public class Room
    {

    }
    public class Teacher
    {

    }
}
