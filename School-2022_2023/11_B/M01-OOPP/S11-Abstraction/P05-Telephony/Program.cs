using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<string> phoneNumbers = Console.ReadLine().Split(' ').ToList();
        List<string> urls = Console.ReadLine().Split(' ').ToList();
        SmartPhone s = new SmartPhone();
        StationaryPhone st = new StationaryPhone();
        foreach (var phone in phoneNumbers)
        {
            if (phone.Length==7)
            {
                st.Call(phone);
            }
            else
            {
                s.Call(phone);
            }
        }
        foreach (var url in urls)
        {
            s.Browse(url);
        }
    }
}

