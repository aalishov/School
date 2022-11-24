using System;


internal class Program
{
    static void Main()
    {
        Car car1= new Car();
        Car car2= new Car("Audi","SR7");
        Car car3 = new Car("Dacia", "Duster", 2022);
        Car car4 = new Car("Fors", "Escort", 2002, 15, 8);
    }
}

