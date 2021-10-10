using System;

namespace P12_DepositCalculator
{
    class Program
    {
        static void Main()
        {
            //Входни данни
                //Депозит
            double deposit = double.Parse(Console.ReadLine());
                //Срок на депозита
            int time = int.Parse(Console.ReadLine());
                //Годишен лихвен процент
            double percent = double.Parse(Console.ReadLine());

            //1. изчисляваме натрупаната лихва: 200 * 5.7% = 11.4лв.
            double interest = deposit * percent / 100;

            //2. изчисляваме лихвата за 1 месец: 11.4лв./12 месеца = 0.95лв
            double montlyInterest = interest / 12.0;

            //3. общата сума е 200лв депозит + (3 (срок на депозита) * 0.95 лв)
            double total = deposit + (time * montlyInterest);

            //Изход
            Console.WriteLine(total);
        }
    }
}
