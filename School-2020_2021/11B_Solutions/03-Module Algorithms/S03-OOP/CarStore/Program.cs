using System;

namespace CarStore
{
    class Program
    {
        static void Main()
        {
            Car fiat = new Car(1545, 5000);
            Car audi = new Car(2545, 10000);
            Car opel = new Car(2595, 7000);
            Store mobile = new Store("Mobile.bg");

            mobile.AddCar(fiat);
            mobile.AddCar(audi);
            mobile.AddCar(opel);

            Console.WriteLine(mobile.CalculateTotalPrice());

            Console.WriteLine(mobile);
        }
    }
}
