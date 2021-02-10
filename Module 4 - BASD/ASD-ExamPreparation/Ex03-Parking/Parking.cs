using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Ex03_Parking
{
    public class Parking
    {
        private readonly LinkedList<Car> cars;
        public Parking()
        {
            this.cars = new LinkedList<Car>();
        }

        public Car Head { get => cars.First.Value; }
        public Car Tail { get => cars.Last.Value; }
        public int Count { get => cars.Count; }


        public void AddCar(string carNumber)
        {
            Car newCar = new Car() { CarNumber = carNumber };
            if (cars.Any())
            {
                cars.Last.Value.CarNext = newCar;
            }            
            cars.AddLast(newCar);
        }

        public void AddFancyCar(string carNumber)
        {
            Car newCar = new Car() { CarNumber = carNumber };
            cars.AddFirst(newCar);
        }

        public Car CheckCarIsPresent(string carNumber)
        {
            Car car = cars.ToList().FirstOrDefault(x => x.CarNumber == carNumber);
            if (car!=null)
            {
                Car findCar = cars.Find(car).Value;
                if (findCar != null)
                {
                    return findCar;
                }
            }
            return null;
        } 

        public bool ReleaseCar(string carNumber)
        {
            Car car = cars.ToList().FirstOrDefault(x=>x.CarNumber==carNumber);
            LinkedListNode<Car> nodeCar = cars.Find(car);
            if (nodeCar != null)
            {
                cars.Remove(nodeCar);
                return true;
            }
            return false;
        }

        public bool ReleaseCar(int index)
        {

            if (index<0||index>=cars.Count)
            {
                return false;
            }

            Car car = cars.ToList()[index];
            LinkedListNode<Car> nodeCar = cars.Find(car);
            if (nodeCar!=null)
            {
                cars.Remove(nodeCar);
                return true;
            }
            return false;
        }

        public StringBuilder ParkingInformation()
        {
            if (cars.Any())
            {
                StringBuilder sb = new StringBuilder();
                foreach (var car in cars)
                {
                    sb.AppendLine(car.ToString());
                }
                return sb;
            }
            else
            {
                return new StringBuilder("Parking is empty!");
            }
        }

    }
}
