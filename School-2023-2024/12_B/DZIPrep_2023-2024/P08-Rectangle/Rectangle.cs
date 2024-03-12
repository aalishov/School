public class Rectangle
{
    private readonly int width;
    private readonly int height;
    private readonly int p;
    private readonly int s;

    public Rectangle(Point upperPoint, Point lowerPoint)
    {
        UpperPoint = upperPoint;
        LowerPoint = lowerPoint;
    }

    public Point UpperPoint { get; set; }

    public Point LowerPoint { get; set; }

    public int Width
    {
        get
        {
            return Math.Abs(LowerPoint.X - UpperPoint.X);
        }
    }


    public int Height
    {
        get
        {
            return Math.Abs(UpperPoint.Y - LowerPoint.Y);
        }
    }

    public int Perimeter
    {
        get
        {
            return (Width * 2) + (Height * 2);
        }
    }
    public int Area
    {
        get
        {
            return Height * Width;
        }
    }
}

