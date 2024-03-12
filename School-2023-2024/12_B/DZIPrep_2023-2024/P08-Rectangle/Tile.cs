public class Tile
{
    public Tile(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public int Width { get; set; }

    public int Height { get; set; }

    public int Area { get => Width * Height; }
}

