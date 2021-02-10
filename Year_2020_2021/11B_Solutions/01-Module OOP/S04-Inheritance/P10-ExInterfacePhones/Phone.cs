using System;
using System.Collections.Generic;
using System.Text;

namespace P10_ExInterfacePhones
{
    public class Phone : ICalling, IBrowsing
    {
        public Phone(string model)
        {
            this.Model = model;
        }

        public string Model { get; set; }

        public string Browse(string url)
        {
            bool isValid = true;
            foreach (var letter in url)
            {
                if (char.IsDigit(letter))
                {
                    isValid = false;
                    break;
                }
            }
            if (isValid)
            {
                return $"Browsing: {url}";
            }
            else
            {
                return "Invalid URL!";
            }
        }

        public string Call(string phoneNumber)
        {
            return $"Calling... {phoneNumber}";
        }
    }
}
