using System;
using System.Collections.Generic;
using System.Text;

namespace P08_Phones
{
    public class SmartPhone : ICalling, IBrowseing
    {
        public string Browse(string address)
        {
            for (int i = 0; i < address.Length; i++)
            {
                if (char.IsDigit(address[i]))
                {
                    return "Invalid URL!";
                }
            }
            return $"Browsing: {address}!";
        }

        public string Call(string phoneNumber)
        {
            for (int i = 0; i < phoneNumber.Length; i++)
            {
                if (!char.IsDigit(phoneNumber[i]))
                {
                    return "Invalid number!";
                }
            }
            return $"Calling... {phoneNumber}";
        }
    }
}
