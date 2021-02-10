using MachinesCommon;
using System;

namespace MachineConsoleApp
{
    public class Program
    {
        static void Main()
        {
            Car car = new Car();
            LawnMower lawnMower = new LawnMower();

            MachineOperator mo = new MachineOperator(car);
            Console.WriteLine(mo.Start());//пускаме машината
            Console.WriteLine(mo.Stop()); //спираме машината
            mo.Entity = lawnMower; //сменяме машината
            Console.WriteLine(mo.ChangeMessage());
            Console.WriteLine(mo.Start());
            Console.WriteLine(mo.Stop());

        }
    }
}
