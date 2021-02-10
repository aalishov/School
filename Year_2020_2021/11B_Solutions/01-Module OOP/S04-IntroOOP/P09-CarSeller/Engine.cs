using System;
using System.Collections.Generic;
using System.Text;


public class Engine
{
    //Полета - model, power, displacement, efficiency

    private string model;
    private int power;
    private int displacement;
    private string efficiency;

    //Конструктор
    public Engine(string model, int power)
    {
        this.Model = model;
        this.Power = power;
    }

    //Свойства

    public string Model
    {
        get { return this.model; }
        set
        {
            // IsNullOrWhiteSpace - проверява дали стринга е празен или се състои само от интервали
            // string.IsNullOrWhiteSpace("    ") - true
            // string.IsNullOrWhiteSpace("") - true
            // string.IsNullOrWhiteSpace(string.Empty) - true
            // string.IsNullOrWhiteSpace("Редови 6 цилиндров") - false
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Engine model can't be null or empty!");
            }
            this.model = value;
        }
    }
    public int Power
    {
        get { return this.power; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Engine power must be positive number!");
            }
            this.power = value;
        }
    }

    public int Displacement
    {
        get { return this.displacement; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Engine displacement must be positive number!");
            }
            this.displacement = value;
        }
    }

    public string Efficiency
    {
        get { return this.efficiency; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Engine efficiency can't be null or empty!");
            }
            this.efficiency = value;
        }
    }

    //Предефиниране на метода ToString()
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{this.Model}:");
        sb.AppendLine($"        Power: {this.Power}");
        string displacement = this.Displacement == 0 ? "n/a" : $"{this.Displacement}";
        sb.AppendLine($"        Displacement: {displacement}");
        string efficiency = this.Efficiency == null ? "n/a" : $"{this.Efficiency}";
        sb.AppendLine($"        Efficiency: {efficiency}");

        return sb.ToString().TrimEnd();
    }
}

