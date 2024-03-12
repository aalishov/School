public class Worker
{
    public double AllTiles(Rectangle r, Tile tile)
    {
        return Math.Ceiling((double)r.Area / tile.Area);
    }

}
