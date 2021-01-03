using System;
using System.Collections.Generic;
using System.Text;

namespace P09_ExIntefaceCars
{
    public class Tesla : ICar,IElectricCar
    {
        public Tesla(string model, string color, int battery)
        {
            this.Model = model;
            this.Color = color;
            this.Battery = battery;
        }

        public string Model { get; set; }
        public string Color { get; set; }
        public int Battery { get; set; }

        public string Start()
        {
            return $"{nameof(Seat)} engine start!";
        }

        public string Stop()
        {
            return $"{nameof(Seat)} engine stop!";
        }

        public override string ToString()
        {
            return $"{this.Color} {nameof(Tesla)} {this.Model} with {this.Battery} Batteries";
        }
    }
}
