public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, Piece> pieces = new Dictionary<string, Piece>();
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split("|");
            string pianistName = input[0];
            string composer = input[1];
            string key = input[2];
            Piece piece = new Piece(composer, key);
            pieces.Add(pianistName, piece);
        }
        while (true)
        {
            string[] input = Console.ReadLine().Split("|");
            string cmd = input[0];
            if (cmd == "Stop")
            {
                break;
            }
            else if (cmd == "Add")
            {
                string pieceName = input[1];
                if (pieces.ContainsKey(pieceName))
                {
                    Console.WriteLine($"{pieceName} is already in the collection!");
                }
                else
                {
                    string composer = input[2];
                    string key = input[3];
                    Piece piece = new Piece(composer, key);
                    pieces.Add(pieceName, piece);
                    Console.WriteLine($"{pieceName} by {composer} in {key} added to the collection!");
                }
            }
            else if (cmd == "Remove")
            {
                string pieceName = input[1];
                if (!pieces.ContainsKey(pieceName))
                {
                    Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
                }
                else
                {
                    pieces.Remove(pieceName);
                    Console.WriteLine($"Successfully removed {pieceName}!");
                }
            }
            else if (cmd == "ChangeKey")
            {
                string pieceName = input[1];

                if (!pieces.ContainsKey(pieceName))
                {
                    Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
                }
                else 
                { 
                    string newKey = input[2];
                    pieces[pieceName].Key = newKey;
                    Console.WriteLine($"Changed the key of {pieceName} to {newKey}!");
                }
            }
        }
        foreach (var piece in pieces) 
        {
            Console.WriteLine($"{piece.Key} -> Composer: {piece.Value.Composer}, Key: {piece.Value.Key}");
        }
    }
}
public class Piece
{
    public Piece(string composer, string key)
    {

        Composer = composer;
        Key = key;
    }


    public string Composer { get; set; }
    public string Key { get; set; }
}
