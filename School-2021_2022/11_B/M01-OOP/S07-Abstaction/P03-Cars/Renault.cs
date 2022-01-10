using System;

namespace P03_Cars
{
    public class Renault : ICar
    {
        public Renault(string model, string color)
        {
            Model = model;
            Color = color;
        }

        public string Model { get; set; }
        public string Color { get; set; }

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
