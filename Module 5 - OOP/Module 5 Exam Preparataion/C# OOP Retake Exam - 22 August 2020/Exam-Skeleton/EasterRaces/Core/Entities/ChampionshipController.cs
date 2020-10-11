namespace EasterRaces.Core.Entities
{
    using EasterRaces.Core.Contracts;
    using EasterRaces.Models.Cars.Contracts;
    using EasterRaces.Models.Cars.Entities;
    using EasterRaces.Models.Drivers.Contracts;
    using EasterRaces.Models.Drivers.Entities;
    using EasterRaces.Models.Races.Contracts;
    using EasterRaces.Models.Races.Entities;
    using EasterRaces.Repositories.Entities;
    using EasterRaces.Utilities.Messages;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class ChampionshipController : IChampionshipController
    {
        private readonly DriverRepository drivers;
        private readonly CarRepository cars;
        private readonly RaceRepository races;

        public ChampionshipController()
        {
            drivers = new DriverRepository();
            cars = new CarRepository();
            races = new RaceRepository();
        }

        public string AddCarToDriver(string driverName, string carModel)
        {
            IDriver driver = drivers.GetByName(driverName);
            ICar car = cars.GetByName(carModel);
            if (driver == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.DriverNotFound, driverName));
            }
            if (car == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.CarNotFound, carModel));
            }
            driver.AddCar(car);
            return string.Format(OutputMessages.CarAdded, driverName, carModel);
        }

        public string AddDriverToRace(string raceName, string driverName)
        {
            IRace race = races.GetByName(raceName);
            IDriver driver = drivers.GetByName(driverName);
            if (race == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceNotFound, raceName));
            }
            if (driver == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.DriverNotFound, driverName));
            }
            race.AddDriver(driver);
            return string.Format(OutputMessages.DriverAdded, driverName, raceName);
        }

        public string CreateCar(string type, string model, int horsePower)
        {
            ICar car = cars.GetByName(model);
            if (car != null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.CarExists, model));
            }
            else
            {
                switch (type)
                {
                    case "Muscle":
                        cars.Add(new MuscleCar(model, horsePower));
                        break;
                    case "Sports":
                        cars.Add(new SportsCar(model, horsePower));
                        break;
                }
                return string.Format(OutputMessages.CarCreated, type + "Car", model);
            }
        }

        public string CreateDriver(string driverName)
        {
            IDriver driver = drivers.GetByName(driverName);
            if (driver != null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.DriversExists, driverName));
            }
            else
            {
                drivers.Add(new Driver(driverName));
                return string.Format(OutputMessages.DriverCreated, driverName);
            }
        }

        public string CreateRace(string name, int laps)
        {
            IRace race = races.GetByName(name);
            if (race != null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceExists, name));
            }
            races.Add(new Race(name, laps));
            return string.Format(OutputMessages.RaceCreated, name);
        }

        public string StartRace(string raceName)
        {
            IRace race = races.GetByName(raceName);
            if (race==null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceNotFound,raceName));
            }
            if (race.Drivers.Count<3)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceInvalid, raceName,3));
            }
            List<IDriver> currentRaceDrivers = race
                 .Drivers
                 .OrderByDescending(x => x.Car.CalculateRacePoints(race.Laps))
                 .ToList();
            IDriver first = currentRaceDrivers.First();
            IDriver second = currentRaceDrivers.Skip(1).First();
            IDriver third = currentRaceDrivers.Skip(2).First();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format(OutputMessages.DriverFirstPosition, first.Name, raceName));
            sb.AppendLine(string.Format(OutputMessages.DriverSecondPosition, second.Name, raceName));
            sb.AppendLine(string.Format(OutputMessages.DriverThirdPosition, third.Name, raceName));

            return sb.ToString().TrimEnd();
        }
    }
}
