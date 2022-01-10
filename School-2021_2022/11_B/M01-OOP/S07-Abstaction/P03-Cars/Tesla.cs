using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_Cars
{
    public class Tesla : ICar, IElectricCar
    {
        public Tesla(string model, string color, int battery)
        {
            Model = model;
            Color = color;
            Battery = battery;
        }

        public string Model { get ; set ; }
        public string Color { get ; set ; }
        public int Battery { get ; set ; }

        public void Start()
        {
            Console.WriteLine($"{GetType().Name} starting...");
        }

        public void Stop()
        {
            Console.WriteLine($"{GetType().Name} stopping...");
        }
    }
}
