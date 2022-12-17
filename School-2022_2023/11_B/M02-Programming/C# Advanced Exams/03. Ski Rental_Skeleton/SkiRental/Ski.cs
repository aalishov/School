using System;
using System.Collections.Generic;
using System.Text;

namespace SkiRental
{
    public class Ski
    {
        public Ski(string manufacturer, string model, int year)
        {
            Manufacturer = manufacturer;
            Model = model;
            Year = year;
        }

        public string Manufacturer { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }
        public override string ToString()
        {
            return $"{Manufacturer} - {Model} - {Year}";
        }

    }
}
