using System;

public class Dice
{
    public string Type { get; set; }

    public int Side { get; set; }

    public void Roll()
    {
        Random r = new Random();
        int result = r.Next(1, this.Side+1);
        Console.WriteLine($"Dice {this.Type.ToLower()} roll result: {result}");
    }
}