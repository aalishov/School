using System;
namespace P07_ICar
{
    public class Seat : ICar
    {
        public Seat(string model, string color)
        {
            this.Model = model;
            this.Color = color;
        }

        public string Model { get ; set ; }
        public string Color { get ; set ; }
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
            return $"{this.Color} {this.GetType().Name} {this.Model}";
        }
    }
}
