using System.Text;

public class Engine
{
    public Engine(string model, double power)
    {
        Model = model;
        Power = power;
    }

    public Engine(string model, double power, double displacement) : this(model, power)
    {
        Displacement = displacement;
    }

    public Engine(string model, double power, string efficiency) : this(model, power)
    {
        Efficiency = efficiency;
    }

    public Engine(string model, double power, double displacement, string efficiency) : this(model, power, displacement)
    {
        Efficiency = efficiency;
    }

    public string Model { get; set; }

    public double Power { get; set; }

    public double Displacement { get; set; }

    public string Efficiency { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{Model}:");
        sb.AppendLine($"\t\tPower: {Power}");
        string displacement = Displacement != 0 ? Displacement.ToString() : "n/a";
        sb.AppendLine($"\t\tDisplacement: {displacement}");
        string efficiency = Efficiency != null ? Efficiency : "n/a";  
        sb.AppendLine($"\t\tEfficiency: {efficiency}");
        return sb.ToString().TrimEnd();
    }
}

