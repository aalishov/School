using System;
using System.Collections.Generic;
using System.Text;

namespace P05_CarManufacturer
{
    class Car
    {
        private string make;
        private string model;
        private int year;
        public string Make
        {
            get { return this.make; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Make length must be more then 3 symbols");
                }
                this.make = value;
            }
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid car model");
                }
                this.model = value;
            }
        }

        public int Year
        {
            get { return this.year; }
            set
            {
                if (value < 1950 || value > DateTime.Now.Year)
                {
                    throw new ArgumentException("Invalid car year");
                }
                this.year = value;
            }
        }
    }
}
