using System;
using System.Collections.Generic;
using System.Text;

namespace P05_Smartphone
{
    public class Smartphone : ICalling, IBrowsing
    {
        public string Browse(string sait)
        {
            return $"Browsing: {sait}!";
        }

        public string Call(string number)
        {
            return $"Calling... {number}";
        }
    }
}
