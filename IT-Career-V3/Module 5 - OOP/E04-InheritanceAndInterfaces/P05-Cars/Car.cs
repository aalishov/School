using System;
using System.Collections.Generic;
using System.Text;

namespace P05_Cars
{
    public abstract class Car : ICar
    {
        public string Model { get; set; }
        public string Color { get; set; }

        public string Start()
        {
            return $"{this.ToString()} -> Start!";
        }

        public string Stop()
        {
            return $"{this.ToString()} -> Stop!";
        }

        public override string ToString()
        {
            return $"I'm {this.GetType().Name} {this.Model} with {this.Color} color!";
        }
    }
}
