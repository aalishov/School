using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class MyFormReader : IReader
{
    TextBox textBox;
    public MyFormReader(TextBox textBox)
    {
        this.textBox = textBox;
    }
    public string Read()
    {
        return textBox.Text;
    }
}
