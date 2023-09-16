using System.Diagnostics;

namespace P03_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            //LawnMower lawnMower = new LawnMower();
            Airplane airplane = new Airplane();
            //Truck truck = new Truck();

            MachineOperator mo = new MachineOperator(car);
            mo.Start(); //пускаме машината
            mo.Stop(); //спираме машината
            mo.Entity = airplane; //сменяме машината
            mo.Start();
            mo.Stop();

        }
    }
}