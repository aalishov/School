using System;
using System.Collections.Generic;
using System.Text;

namespace P03_StackOfStrings
{
    public class StackOfStrings<String>:Stack<string>
    {
        public bool IsEmpty()
        {
            if (this.Count==0)
            {
                return true;
            }
            return false;
        }
    }
}
