namespace EasterRaces.Models.Cars.Entities
{
    using EasterRaces.Models.Cars.Contracts;
    using EasterRaces.Utilities.Messages;
    using System;
    public abstract class Car : ICar
    {
        private string model;
        private int minHorsePower;
        private int maxHorsePower;
        private int horsePower;

        protected Car(string model, int horsePower, double cubicCentimeters, int minHorsePower, int maxHorsePower)
        {
            this.Model = model;
            this.HorsePower = horsePower;
            this.CubicCentimeters = cubicCentimeters;
            this.minHorsePower = minHorsePower;
            this.maxHorsePower = maxHorsePower;
        }
        //TODO: Check modifier
        public string Model
        {
            get { return model; }

            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 4)
                {
                    //throw new ArgumentException($"Model {value} cannot be less than 4 symbols.");
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidName,value,4));
                }
                model = value;
            }
        }

        public int HorsePower
        {
            get { return horsePower; }
            private set
            {
                if (value < minHorsePower || value > maxHorsePower)
                {
                    //throw new ArgumentException($"Invalid horse power: {value}.");
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidHorsePower, value));
                }
                horsePower = value;
            }
        }

        public double CubicCentimeters { get; private set; }

        public double CalculateRacePoints(int laps)
        {
            return this.CubicCentimeters / (double)this.HorsePower * (double)laps;
        }
    }
}
