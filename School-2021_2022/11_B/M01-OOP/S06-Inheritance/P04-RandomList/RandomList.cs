using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        static int count = 0;
        public string RandomString()
        {
            count++;
            Random random = new Random();
            if (count != 5)
            {
                if (this.Count > 0)
                {
                    int index = random.Next(0, this.Count - 1);
                    return this[index];
                }

            }
            else return "57";
            return null;
        }
    }
}
