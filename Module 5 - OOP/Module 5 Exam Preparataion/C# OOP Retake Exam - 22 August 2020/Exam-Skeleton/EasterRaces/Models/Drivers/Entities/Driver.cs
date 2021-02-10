namespace EasterRaces.Models.Drivers.Entities
{
    using EasterRaces.Models.Cars.Contracts;
    using EasterRaces.Models.Drivers.Contracts;
    using EasterRaces.Utilities.Messages;
    using System;
    public class Driver : IDriver
    {
        private string name;

        public Driver(string name)
        {
            this.Name = name;
            this.CanParticipate = false;
        }
        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    //throw new ArgumentException($"Name {value} cannot be less than 5 symbols.");
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidName,value,5));
                }
                name = value;
            }
        }

        public ICar Car { get; private set; }

        public int NumberOfWins { get; private set; }

        public bool CanParticipate { get; private set; }

        public void AddCar(ICar car)
        {
            if (car == null)
            {
                //throw new ArgumentNullException("Car cannot be null.");
                throw new ArgumentNullException(ExceptionMessages.CarInvalid);
            }
            this.Car = car;
            this.CanParticipate = true;
        }


        public void WinRace()
        {
            this.NumberOfWins++;
        }
    }
}
