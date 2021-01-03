using System;
using System.Collections.Generic;
using System.Text;

namespace P09_ExIntefaceCars
{
    public class Seat : ICar
    {
        public Seat(string model, string color)
        {
            this.Model = model;
            this.Color = color;
        }

        public string Model { get; set; }
        public string Color { get; set; }

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
            return $"{this.Color} {nameof(Seat)} {this.Model}";
        }
    }
}
