using System;
using System.Collections.Generic;
using System.Text;

namespace P02_RandomList
{
    public class RandomList<T>:List<T>
    {
        public string RandomString()
        {

            if (this.Count==0)
            {
                return "List is empty!";
            }
            Random random = new Random();
            int randIndex = random.Next(0, this.Count);

            string returnString = this[randIndex].ToString();
            this.RemoveAt(randIndex);
            return returnString;
        }
    }
}
