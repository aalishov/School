using System;
using System.Collections.Generic;
using System.Text;

public class Car
{
    //Полета
    private string make;
    private string model;
    private int year;

    //Свойства
    public string Make
    {
        get { return make; }
        set { make = value; }
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public int Year
    {
        get { return year; }
        set { year = value; }
    }
}

