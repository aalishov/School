using System;
using System.Collections.Generic;
using System.Linq;
public class SmartPhone : IBrowsing, ICalling
{
    public void Browse(string url)
    {
        if (url.Any(x=>char.IsDigit(x)))
        {
            Console.WriteLine("Invalid url!");
        }
        else
        {
            Console.WriteLine($"Browsing: {url}!");
        }
    }
    
    public void Call(string phoneNumber)
    {
        if (phoneNumber.Any(x=>!char.IsDigit(x)))
        {
            Console.WriteLine("Invalid number!");
        }
        else
        {
            Console.WriteLine($"Calling... {phoneNumber}");
        }
        
    }
}

