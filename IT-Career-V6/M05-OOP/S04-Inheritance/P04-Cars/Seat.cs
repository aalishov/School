﻿public class Seat : ICar
{
    public Seat(string model, string color)
    {
        Model = model;
        Color = color;
    }
    public string Model { get; set; }
    public string Color { get; set; }
    public string Start()
    {
       return "Engine start";
    }
    public string Stop()
    {
        return "Breaaak!";
    }
    public override string ToString()
    {
        return $"{Color} {Model}\n\r{Start()}\n\r{Stop()}";
    }
}

