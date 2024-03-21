public class Program
{
    static void Main()
    {
    }
}
public class Song
{
    public Song(Song song)
    {
        this.Title=song.Title;
        this.Singer=song.Singer;
    }
    public Song(string title, string singer)
    {
        this.Title = title;
        this.Singer = singer;
    }
    public Song(string title):base()
    {
        Title = title;
    }
    public Song()
    {
        Title = "unknown";
        Singer = "unknown";
    }

    public string Title { get; set; }
    public string Singer { get; set; }

}

