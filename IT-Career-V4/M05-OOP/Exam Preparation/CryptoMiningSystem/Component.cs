using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoMiningSystem
{
    public abstract class Component : IComponent
    {
        private string model;
        private decimal price;
        private int generation;
        private int lifeWorkingHours;

        protected Component(string model, decimal price, int generation,int lifeWorkingHours)
        {
            Model = model;
            Price = price;
            Generation = generation;
            this.LifeWorkingHours = lifeWorkingHours;
        }

        public string Model
        {
            get { return model; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Model cannot be null or empty!");
                }
                model = value;
            }
        }
        public decimal Price
        {
            get { return price; }
            private set
            {
                if (value <= 0 || value > 10000)
                {
                    throw new ArgumentException("Price cannot be less or equal to 0 and more than 10000!");
                }
                price = value;
            }
        }
        public virtual int Generation
        {
            get { return generation; }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Generation cannot be 0 or negative!");
                }
                generation = value;
            }
        }
        public int LifeWorkingHours
        {
            get { return lifeWorkingHours; }
            set
            {
                lifeWorkingHours = value;
            }
        }
    }
}
