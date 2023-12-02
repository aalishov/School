using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class PersonException : Exception
{
    public PersonException(string invalidProperty) : base($"Person invalid {invalidProperty}!")
    {
    }
}

