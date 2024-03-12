using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MyFormWriter : IWriter
{
    Control formObject;

    public void Write(string text)
    {
        formObject.Text = text;
    }

    public void SetObject(Control formObject)
    {
        this.formObject = formObject;
    }
}
