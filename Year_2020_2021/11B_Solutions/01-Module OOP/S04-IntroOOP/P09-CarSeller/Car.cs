using System;
using System.Collections.Generic;
using System.Text;

public class Car
{
    //Полета - model, engine, weight, color
    private string model;
    private Engine engine;
    private double weight;
    private string color;

    //Конструктор
    public Car(string model, Engine engine)
    {
        this.Model = model;
        this.Engine = engine;
    }

    //Свойства
    public string Model
    {
        //Дава достъп за четене
        get { return this.model; }
        //Дава достъп за промяна
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Model can't be null or empty!");
            }
            this.model = value;
        }
    }

    public Engine Engine
    {
        get { return this.engine; }
        set
        {
            if (value == null)
            {
                throw new ArgumentException("Engine can't be null!");
            }
            this.engine = value;
        }
    }

    public double Weight
    {
        get { return this.weight; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Car weight must be positive number!");
            }
            this.weight = value;
        }
    }
    public string Color
    {
        get { return this.color; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Car color can't be null or empty!");
            }
            this.color = value;
        }
    }

    //Предефиниране на метода ToString()
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{this.Model}:");
        sb.AppendLine($"    {this.Engine.ToString()}:");
        string weight = this.Weight == 0 ? "n/a" : $"{this.Weight}";
        sb.AppendLine($"    Weight: {weight}");
        string color = this.Color == null ? "n/a" : $"{ this.Color}";
        sb.AppendLine($"    Color: {color}");

        return sb.ToString().TrimEnd();
    }
}

