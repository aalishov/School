using System;
using System.Collections.Generic;
using System.Text;

namespace _01_DemoFormatException
{
    public class CustomException : Exception
    {
        static string message2 = "Garage exception: ";
        public CustomException() : base(message2)
        {

        }

        public CustomException(string message):base(message2+message)
        {

        }
    }
}
