using System;
using System.Collections.Generic;
using System.Text;

namespace P01_IntroMethods
{
    public static class StaticMethods
    {
        public static string PrintLineWithStars(char c, int num)
        {
            Random r = new Random();
            int n = r.Next(1, 10);
            return new string(c, num + n) + "=>";
        }
    }
}
