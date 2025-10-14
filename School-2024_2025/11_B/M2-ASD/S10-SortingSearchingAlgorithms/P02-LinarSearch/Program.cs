namespace LinearSearch
{
    using System;
    public class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "a", "ab", "ac" };
            int[] nums = { 1, 2, 3 };

            Search.Linear(words, "n");
            Search.Linear(nums, 3);


            Car car1 = new Car("Red", 170, 10);
            Car car2 = new Car("Blue", 150, 10);
            Car[] cars = { car1, car2 };
            Console.WriteLine(car1.CompareTo(car2));
            Search.Linear(cars, new Car("Black", 200, 5));
        }
    }

    public class Car : IComparable
    {
        public Car(string color, int horsePower, double fuelConsumption)
        {
            Color = color;
            HorsePower = horsePower;
            FuelConsumption = fuelConsumption;
        }

        public string Color { get; set; }

        public int HorsePower { get; set; }

        public double FuelConsumption { get; set; }


        public int CompareTo(object? obj)
        {
            if (this.HorsePower > ((Car)obj).HorsePower)
            {
                return 1;
            }
            else if (this.HorsePower < ((Car)obj).HorsePower)
            {
                return -1;
            }
            return 0;
        }
    }


    public class Search
    {
        // LinearSearch = Линейно търсене = O(n)
        public static int Linear<T>(T[] elements, T key) where T : IComparable
        {
            for (int index = 0; index < elements.Length; index++)
            {
                if (elements[index].CompareTo(key) == 0)
                {
                    return index; // Found
                }
            }
            return -1; // Not Found
        }
    }
}

