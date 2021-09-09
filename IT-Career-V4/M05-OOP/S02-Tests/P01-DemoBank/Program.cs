using System;
using System.Collections.Generic;

namespace P01_DemoBank
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(1,100);
           
            Console.WriteLine(account);

        }
    }
}
