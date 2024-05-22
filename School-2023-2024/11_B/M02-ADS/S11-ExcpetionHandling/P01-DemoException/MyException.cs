using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class MyException : Exception
{
    public MyException():base("My exception!")
    {
        
    }
    public MyException(string msg) : base(msg)
    {

    }
}

