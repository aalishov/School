using System;
using System.Collections.Generic;

namespace CryptoMiningSystem
{
    public class StartUp
    {
        public static void Main()
        {
            double[] arr = new double[] { 12, 3 };
            List<double> list = new List<double> { 12.6, 65.8 };
            HashSet<double> set = new HashSet<double> { 13.6, 65.8 };
            Sum(arr);
            Sum(list);
            Sum(set); 
        }

        public static double Sum(ICollection<double> nums)
        {
            double sum = 0;
            foreach (var num in nums)
            {
                sum += num;
            }
            return sum;
        }
    }
}
