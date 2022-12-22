using System;
using System.Linq;

public class StationaryPhone:ICalling
{
    public void Call(string phoneNumber)
    {
        if (phoneNumber.Any(x => !char.IsDigit(x)))
        {
            Console.WriteLine("Invalid number!");
        }
        else
        {
            Console.WriteLine($"Dialing... {phoneNumber}");
        }
    }
}

