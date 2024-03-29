
public class Program
{
    public static void Main()
    {
        Queue<string> playlist = new Queue<string>(Console.ReadLine().Split(", "));

        while (playlist.Count > 0)
        {
            string[] input = Console.ReadLine().Split(" ");
            string cmd = input[0];
            if (cmd =="Play")
            {
                playlist.Dequeue();
            }
            else if (cmd =="Add")
            {
                string song=string.Join(" ", input.Skip(1));
                if (playlist.Contains(song))
                {
                    Console.WriteLine($"{song} is already contained!");
                }
                else
                {
                    playlist.Enqueue(song);
                }
            }
            else if(cmd =="Show")
            {
                Console.WriteLine(string.Join(", ",playlist));
            }
        }
        Console.WriteLine("No more songs");
    }
}

