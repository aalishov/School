﻿namespace SpaceStation.Models.Astronauts
{
    public class Meteorologist : Astronaut
    {
        private const double InitialOxygen = 90;
        public Meteorologist(string name) : base(name, InitialOxygen)
        {
        }
    }
}
