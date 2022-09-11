public abstract class ColoredFigure
{
    protected ColoredFigure(string color, double size)
    {
        this.Color = color;
        this.Size = size;
    }
    public string Color { get; private set; }
    public double Size { get; private set; }
    public abstract string GetName();
    public abstract double GetArea();

    public override string ToString()
    {
        return $"{GetName()}:\nColor: {this.Color}\nArea: {GetArea():f2}";
    }
}

