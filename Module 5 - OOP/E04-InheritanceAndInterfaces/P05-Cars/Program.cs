using System;
using System.Collections.Generic;

namespace P05_Cars
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ICar car1 = new Seat() { Model = "Leon", Color = "red" };
            ICar car2 = new Tesla() { Model = "Model 3", Color = "black" };
            ICar car3 = new Tesla() { Model = "Model X", Color = "grey", Battery = 50 };
            ICar car4 = new Seat() { Model = "Ibiza", Color = "green" };

            List<ICar> cars = new List<ICar>() { car1, car2, car3,car4 };

            foreach (var car in cars)
            {
                Console.WriteLine(car);
                Console.WriteLine(car.Start());
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.Stop());
            }
        }
    }
}
