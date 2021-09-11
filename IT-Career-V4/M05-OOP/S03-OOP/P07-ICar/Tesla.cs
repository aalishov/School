using System;
using System.Collections.Generic;
using System.Text;

namespace P07_ICar
{
    public class Tesla : ICar, IElectricCar
    {
        public Tesla(string model, string color, int battery)
        {
            this.Model = model;
            this.Color = color;
            this.Battery = battery;
        }

        public string Model { get ; set ; }
        public string Color { get ; set ; }
        public int Battery { get ; set ; }
        public string Start()
        {
            return $"{GetType().Name} => Engine start";
        }
        public string Stop()
        {
            return $"{GetType().Name} => Breaaak!";
        }
        public override string ToString()
        {
            return $"{this.Color} {this.GetType().Name} {this.Model} with {this.Battery} Batteries";
        }
    }
}
