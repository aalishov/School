using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Ex05_P07_SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vip = new HashSet<string>();
            HashSet<string> regular = new HashSet<string>();

            while (true)
            {
                string number = Console.ReadLine();
                if (number == "PARTY")
                {
                    break;
                }
                if (char.IsDigit(number[0]))
                {
                    vip.Add(number);
                }
                else
                {
                    regular.Add(number);
                }
            }

            while (true)
            {
                string number = Console.ReadLine();
                if (number == "END")
                {
                    break;
                }
                vip.Remove(number);
                regular.Remove(number);
            }

            Console.WriteLine(vip.Count + regular.Count);
            string resultVip = vip.Any() ? "VIP: "+string.Join(", ", vip) :"VIP: "+"none";

            //if (vip.Any())
            //{
            //    resultVip = string.Join(", ", vip);
            //}
            //else
            //{
            //    resultVip = "none";
            //}

            Console.WriteLine(resultVip);
            string resultReg = regular.Any() ?"Regular: " +string.Join(", ", regular) : "Regular: " + "none";
            Console.WriteLine(resultReg);
        }
    }
}
